using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Browser_game.Controllers
{
    public class ErrorController : Controller
    {
        public new int StatusCode { get; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Error");
        }

        public IActionResult Error(int? id, int statusCode = 404)
        {
            //StatusCode = statusCode;
            switch (statusCode)
            {
                case 404:
                    return View("Error404");
                case 500:
                    return View("Error500");
                case 401:
                    return View("Error401");
                case 403:
                    return View("Error403");
                default:
                    return null;
            }
        }
    }
}