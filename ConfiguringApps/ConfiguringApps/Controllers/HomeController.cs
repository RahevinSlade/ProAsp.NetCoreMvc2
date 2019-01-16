using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps;
using Microsoft.Extensions.Logging;
using ConfiguringApps.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        private ILogger<HomeController> logger;

        public HomeController(UptimeService up, ILogger<HomeController> log)
        {
            uptime = up;
            logger = log;
        }

        public HomeController(UptimeService up) => uptime = up;

        public ViewResult Index(bool throwException = false)
        {
            logger.LogDebug($"Handled {Request.Path} at uptime {uptime.Uptime}");
            if (throwException)
            {
                throw new System.NullReferenceException();
            }
            return View (new Dictionary<string, string>{
                    ["Message"] = "This is the Index action",
                    ["Uptime"] = $"{uptime.Uptime}ms"
                });
            }

        public ViewResult Error() => View(nameof(Index),
            new Dictionary<string, string>
            {
                ["Message"] = "This is the Error action"
            });
        // GET: /<controller>/
        //public ViewResult Index() 
        //    => View(new Dictionary<string, string>{
        //    ["Message"] = "This is the Index action",
        //    ["Uptime"] = $"{uptime.Uptime}ms"
        //});
        }
}
