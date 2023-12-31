﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StocksApp.Models;

namespace StocksApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("Error")]
        public IActionResult Index()
        {
            IExceptionHandlerPathFeature? exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionHandlerPathFeature != null && exceptionHandlerPathFeature.Error != null)
            {
                Error error = new Error() { ErrorMessage = exceptionHandlerPathFeature.Error.Message };
                return View(error);
            }
            else
            {
                Error error = new Error() { ErrorMessage = "Error encountered" };
                return View(error);
            }
        }
    }
}
