using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BirthdayCard.controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.CardInfo cardInfo)
        {
            if (ModelState.IsValid)
            {
                return View("CardSent", cardInfo);
            }
            else
            {
                return View();
            }
        }
    }
}