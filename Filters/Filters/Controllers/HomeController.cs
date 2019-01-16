using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Filters.Infrastructure;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filters.Controllers
{   [Message("This is the Controller-Scoped Filter")]
    
    //[TypeFilter(typeof(DiagnosticsFilter))]//TypeFilter allows loosely coupled components
    //[ServiceFilter(typeof(TimeFilter))]//resolves all dependcies, the set of messages displayed builds up with each request
    //[TypeFilter(typeof(TimeFilter))]

    //[Profile]//hybrid with two custom filters
    //[ViewResultDetails]//applying our custom ViewResultDetail Filter
    //[RangeException]//applying our custom RangeException 

    //[Profile] //applying our ProfileAttribute filter

    //[HttpsOnly]//Applying our custom filter

    //[RequireHttps]//this can be used as a global filter, applies to all actions in this controller
    public class HomeController : Controller
    {
        [Message("This is the First Action-Scoped Filter")]
        [Message("This is the Second Action-Scoped Filter")]
        public ViewResult Index() => View("Message",
            "This is the Index action on the Home Controller");
        //[RequireHttps]//built in filter, it restricts access to action methods so that only Https requests are allowed
        //public ViewResult Index() => View("Message",
        //    "This is the Index action on the Home controller");

        ////[RequireHttps]
        //public ViewResult SecondAction() => View("Message",
        //    "This is the SecondAction action on the Home controller");

        //public ViewResult GenerateException(int? id)
        //{
        //    if(id == null)
        //    {
        //        throw new ArgumentNullException(nameof(id));
        //    } else if (id > 10)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(id));
        //    } else
        //    {
        //        return View("Message", $"The value is {id}");
        //    }
        //}

        //public IActionResult SecondAction() //this can cause a lot of clutter
        //{
        //    if (!Request.IsHttps)
        //    {
        //        return new StatusCodeResult(StatusCodes.Status403Forbidden);
        //    }
        //    else
        //    {
        //        return View("Message",
        //    "This is the SecondAction on the Home Controller");
        //    }
        //}

        //public ViewResult Index() => View("Message",
        //    "This is the Index action on the Home Controller");
    }
}
