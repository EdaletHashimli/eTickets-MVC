﻿using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("branch");
            return View();
        }
    }
}
