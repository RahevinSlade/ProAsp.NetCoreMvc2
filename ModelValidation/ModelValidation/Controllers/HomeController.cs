using System;
using ModelValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() =>
            View("MakeBooking", new Appointment { Date = DateTime.Now });

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt) =>
            View("Completed", appt);
    }
}
