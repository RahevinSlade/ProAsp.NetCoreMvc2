using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;
using DependencyInjection.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //private IRepository repository;
       // private ProductTotalizer totalizer;

       // public HomeController(IRepository repo, ProductTotalizer total)
       //public HomeController(IRepository repo)
       // {
       //     repository = repo;
       //     //totalizer = total;
       // }

        public ViewResult Index([FromServices] ProductTotalizer totalizer)
        {
            IRepository repository =
                HttpContext.RequestServices.GetService<IRepository>();

            ViewBag.HomeController = repository.ToString();
            ViewBag.Totalizer = totalizer.Repository.ToString();
            return View(repository.Products);
        }
        //public ViewResult Index()
        //{
        //    ViewBag.HomeController = repository.ToString();
        //    ViewBag.Totalizer = totalizer.Repository.ToString();
        //    return View(repository.Products);
        //}
        //public IRepository Repository { get; } = TypeBroker.Repository;
        //public ViewResult Index() => View(Repository.Products);//Decoupling Components for Unit Testing
        //public ViewResult Index() => View(new MemoryRepository().Products);//Loosely Coupled Components
    }
}
