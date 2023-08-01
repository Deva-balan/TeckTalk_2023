using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechTalk.Framework;
using Techtalk_SMS.Models; 
using Newtonsoft.Json;  
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment; 
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq; 
using System.Data; 
using Microsoft.AspNetCore.Http; 

namespace Techtalk_SMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      
        [Route(UrlRouting.Home.GoHome)]
        public JsonResult GoHome()
        {

            //var Reportclient = new RestClient(baseUrl + "Reports/GetRptHeaderSettingsAsync?TitleId=" + (int)EnumCommand.ReportTittle.ViolationPointsOccurrence);
            //var Reportrequest = new RestRequest("", RestSharp.Method.Get);
            //Reportrequest.AddParameter("application/json", "", ParameterType.RequestBody);
            //Reportrequest.AddHeader("Authorization", "Bearer " + token);
            //RestResponse restresponse = Reportclient.Execute(Reportrequest);

            return Json("test");
        }
    }
}