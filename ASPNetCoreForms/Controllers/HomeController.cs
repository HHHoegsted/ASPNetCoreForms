using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreForms.Models;

namespace ASPNetCoreForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = "";
            
            if (ModelState.IsValid)
            {
                message = "Product " + model.Name + " Rate " + model.Rating.ToString() + " with rating " + model.Rate.ToString() + " created successfully";
            }
            else
            {
                message = "Failed to create product. Please try again";
            }

            return Content(message);
        }
    }
}