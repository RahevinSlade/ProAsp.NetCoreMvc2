using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        //[Route("myroute")] //name of route
        //[Route("[controller]/MyAction")] //much like using the nameof expression
        //[Route("app/[controller]/actions/[action]/{id?}")] //this route provies app/customer/action as a target 
        [Route("app/[controller]/actions/[action]/{id:weekday?}")] //this route uses the weekdayconstraint
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });

        public ViewResult List(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(List),
            };
            r.Data["id"] = id ?? "<no value>";
            r.Data["catchall"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    }
}
