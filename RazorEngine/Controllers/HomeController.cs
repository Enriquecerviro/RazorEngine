using Microsoft.AspNetCore.Mvc;
using RazorEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorEngine.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            ViewBag.StockLevel = 2;//THIS PROPERTY IS DEFINED HERE, COMO "VIEWBAG" ES DINAMICO NO TENGO QUE DECLARAR NADA
            return View(myProduct);
        }
    }

}

