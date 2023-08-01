using TechTalk.Models;
using Techtalk_api;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



// Add services to the container.
builder.Services.AddDIServices(builder.Configuration);


// To manage the browser  session manage configuration settings
builder.Services.AddSession(options =>
{
    options.Cookie.Name = "CHMS_Session";
    // Set a short timeout for easy testing.
    options.IdleTimeout = TimeSpan.FromHours(24);
    options.Cookie.HttpOnly = true;
    // Make the session cookie essential
    options.Cookie.IsEssential = true;
});

// JWT Authentication
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
                                                            //IWebHostEnvironment environment = builder.Environment;

var appSettingsSection = configuration.GetSection("JWTSetting");
builder.Services.Configure<JWTSetting>(appSettingsSection);

var appSettings = appSettingsSection.Get<JWTSetting>();
var Key = Encoding.ASCII.GetBytes(appSettings.SecurityKey);
var AllowOrgin = appSettings.AllowOrigin;

string[] sAllowOrgin = AllowOrgin.Split(";");

builder.Services.AddAuthentication(au =>
{
    au.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    au.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(jwt =>
{
    jwt.RequireHttpsMetadata = false;
    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };
});

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigins",
//        builder => builder.WithOrigins(AllowOrgin)
//        .AllowAnyMethod()
//        .AllowAnyHeader()
//        .AllowCredentials());
//});



builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowSpecificOrigins",
                      policy =>
                      {
                          policy.WithOrigins(sAllowOrgin).AllowAnyHeader().AllowAnyMethod();
                      });
});












// Add the Application Session mannagement
builder.Services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


builder.Services.AddEndpointsApiExplorer();
// Register the Swagger generator, defining 1 or more Swagger documents
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "OptionC CHMS",
        Version = "v1",
        Description = "An API to perform church management system project",
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });

    // Go to Project Properties --> Build --> Output  --> XML Documentation File --> Check the checkbox
    // Error and Warning  --> Suppress specific warning ass the ; 1591 and 
    // Output             --> Check the Documentation file
    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.UseStaticFiles();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "OPTIONC CHMS API");
        c.InjectStylesheet("/swagger.css");
        c.DocumentTitle = "OPTIONC CHMS API";
        c.DocExpansion(DocExpansion.None);//This will not expand all the API's.
    });
}

app.UseCors("AllowSpecificOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();