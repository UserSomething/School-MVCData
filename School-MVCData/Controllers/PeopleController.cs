using Microsoft.AspNetCore.Mvc;
using School_MVCData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCData.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService peopleService;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string phoneNumber, string city)
        {
            //peopleService.Add(name, phoneNumber, city);
            return View();
        }
    }
}
