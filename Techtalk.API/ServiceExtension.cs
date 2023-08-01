using TechTalk.DBEngine;
using TechTalk.Repository;
using TechTalk.Repository.Interfaces;
using TechTalk.Repository.Repository;


namespace TechTalk.API
{
    /// <summary>
    ///  Service Extension  process 
    /// </summary>
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            // To access the files in web Browsers
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Sql Server Repository
            services.AddTransient<ISQLServerHandler, SQLServerHandler>();

            // student Module 
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}