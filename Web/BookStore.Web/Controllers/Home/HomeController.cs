﻿namespace BookStore.Web.Controllers
{
    using System.Diagnostics;

    using BookStore.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Publishing()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        [Route("/NotFound")]
        public IActionResult PageNotFound()
        {
            return this.View();
        }
    }
}
