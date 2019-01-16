using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ControllersAndActions.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index() => View("SimpleForm");

        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city)
        {
            TempData["name"] = name;
            TempData["city"] = city;
            return RedirectToAction(nameof(Data));//recieves data from the user via post
        }

        public ViewResult Data()
        {
            string name = TempData["name"] as string;
            string city = TempData["city"] as string;
            return View("Result", $"{name} lives in {city}");
        }

        //public IActionResult ReceiveForm(string name, string city)
        //    => new CustomHtmlResult
        //    {
        //        Content = $"{name} lives in {city}"
        //    };

        //public void ReceiveForm(string name, string city)
        //{
        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html";
        //    byte[] content = Encoding.ASCII
        //        .GetBytes($"<html><body>{name} lives in {city}</body>");
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}

        //public ViewResult ReceiveForm(string name, string city)
        //    => View("Result", $"{name} lives in {city}");
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} lives in {city}");
        //}
    }
}
