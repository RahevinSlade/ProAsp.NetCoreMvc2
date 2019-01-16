using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public StatusCodeResult Index() => NotFound(); //sending404 result using a convienience class
        //public StatusCodeResult Index()
        //    => StatusCode(StatusCodes.Status404NotFound);//accepts an int value, sending a specific Http Result Code
        //public JsonResult Index() => Json(new[] {"Alice", "Bob", "Joe" });//returns the data that will converted into json

        //public VirtualFileResult Index()
        //    => File("/lib/bootstrap/dist/css/bootstrap.css", "text/css");
        //public ObjectResult Index() => Ok(new string[] { "Alice", "Bob", "Joe" });
        //public ContentResult Index()
        //    => Content("[\"Alice\",\"Bob\",\"Joe\"]", "application/ajson");//Doesnt know how to process
        //public ViewResult Index()
        //{
        //    ViewBag.Message = "Hello";
        //    ViewBag.Date = DateTime.Now;
        //    return View();
        //}

        public ViewResult Result() => View((object)"Hello World");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(HomeController.Index));//Redirects to another controller and action
       // public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));//redirects to an action method

        //public RedirectResult Redirect() => Redirect("/Example/Index"); //Redirects user to temporary redirection
        //public RedirectResult Redirect() => RedirectPermanent("/Example/Index");//Redirects user permanently 

        //public RedirectToRouteResult Redirect() =>//uses temporary redirect to a certain url
        //    RedirectToRoute(new
        //    {
        //        controller = "Example",
        //        action = "Index",
        //        ID = "MyID"
        //    });

    }
}
