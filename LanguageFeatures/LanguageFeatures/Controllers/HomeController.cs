using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //bool FilterByPrice(Product p)//see below to see a better version of this syntax
        //{
        //    return (p?.Price ?? 0) <= 20;
        //}

        //public ViewResult Index()
        //{
            //string[] names = new string[3];
            //names[0] = "Bob";
            //names[1] = "Joe";
            //names[2] = "Alice";

            //return View("Index", names); This is one way to display a array

            //return View("Index", new string[] { "Bob", "Joe", "Alice" }); //Here is another way to display an array

            //List<string> results = new List<string>(); //There are many ways to display these values
            //foreach (Product p in Product.GetProducts())
            //{
            //    //string name = p?.Name; //we use the ? as a work around just in case the object is null
            //    //decimal? price = p?.Price;
            //    //string relatedName = p?.Related?.Name;//will be null when p is null or when p.reelated is null
            //    string name = p?.Name ?? "<No Name>";//this is combining null conditional operator with null coalescing
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            //}

            //return View(results);

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    //{"Kayak", new Product{Name = "Kayak", Price = 275M}}, //We can do this to display products or
            //    //{"Lifejacket", new Product{Name = "Lifejacket", Price = 48.95M}}

            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M}, //or this alternatively
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M}
            //};
            //return View("Index", products.Keys);

            //object[] data = new object[] {275M, 29.95M,//Pattern Matching
            //    "apple", "orange", 100, 10};//Pattern Matching
            //decimal total = 0;//Pattern Matching
            //for (int i = 0; i < data.Length; i++) //Pattern Matching
            //{
            //    //if (data[i] is decimal d) //this is an example of pattern matching
            //    //{// ^ ^ is checking if the value is of decimal type and totaling them up
            //    //    total += d;
            //    //}
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50: //notice when, this is much like an if statement
            //            total += intValue;
            //            break;
            //    }

            //}
            //return View("Index", new string[] { $"Total: {total:C2}" });

            //ShoppingCart cart
                //= new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray =
            //{
            //    new Product {Name = "Kayak", Price = 275M},
            //    new Product {Name = "Lifejacekt", Price = 48.95M},
            //    new Product {Name = "Soccer ball", Price = 19.50M},
            //    new Product {Name = "Corner flag", Price = 34.95M}
            //};

            //Func<Product, bool> nameFilter = delegate (Product prod) //this can be considered harder to read
            //{
            //    return prod?.Name?[0] == 'S';
            //};
            // below is considered a lambda expression
            //decimal priceFilerTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();//use these, easier to read/understand
            //decimal nameFilterTotal = productArray.Filter(p => (p?.Name?[0] == 'S')).TotalPrices();

            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            //return View("Index", new string[] { $"Array Total: {priceFilerTotal:C2}",$"Name Total: {nameFilterTotal:C2}" });

            //return View(Product.GetProducts().Select(p => p?.Name)); //using Lambda expressions

            //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));//action methed expressed as lambda
        //}

        //public ViewResult Index()
        //{
        //    var products = new[]
        //    {
        //        new {Name = "Kayak", Price = 275M},
        //        new {Name = "Lifejacket", Price = 48.95M},
        //        new {Name = "Soccer ball", Price = 19.50M},
        //        new {Name = "Corner flag", Price = 34.95M}
        //    };
        //    return View(products.Select(p => p.Name));
        //}

        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}
        
        public ViewResult Index()
        {
                var products = new[]
                {
                    new {Name = "Kayak", Price = 275M},
                    new {Name = "Lifejacket", Price = 48.95M},
                    new {Name = "Soccer ball", Price = 19.50M},
                    new {Name = "Corner flag", Price = 34.95M}
                };
                return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

    }
}
