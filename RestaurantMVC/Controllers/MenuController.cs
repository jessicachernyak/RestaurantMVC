using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.Models;

namespace RestaurantMVC.Controllers
{
    public class MenuController : Controller
    {
        static private readonly List<menuItem> menuItems = new List<menuItem>();

        public IActionResult Index()
        {
            ViewBag.menuItems = menuItems;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Menu/Add")]
        public IActionResult Add(int ID, string name, decimal price, string description, string category)
        {
            menuItem item = new menuItem(ID, name, price, description, category);
            menuItems.Add(item);

            return Redirect("/Menu");
        }

        [HttpPost]
        public IActionResult Remove(List<string> rmvitem)
        {
            menuItems.RemoveAll(item => rmvitem.Contains(item.Name));

            return Redirect("/Menu");

        }

        /* public IActionResult IsNew()
        {
            string varDateTime = System.DateTime.Now.ToString();
            return varDateTime;
        } */
    }
}