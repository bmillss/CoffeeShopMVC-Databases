using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
using CoffeeshopHWMVC.Models;

namespace CoffeeshopHWMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult product()
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            
            List<Product> allprods = db.GetAll<Product>().ToList();
            return View(allprods);
        }

    }
}
