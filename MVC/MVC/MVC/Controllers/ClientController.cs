using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Info(int id)
        {
            Client c = new Client() { Id = id, Name = "Jan Novák" };

            ViewData["boss"] = "Petr Krátký";

            return View(c);
        }
    }
}