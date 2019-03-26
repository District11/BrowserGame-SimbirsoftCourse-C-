using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Browser_game.Models;
using Microsoft.AspNetCore.Authorization;

namespace Browser_game.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public IActionResult Create(Player player)
        {
       
            if (string.IsNullOrEmpty(player.NickName))
            {
                ModelState.AddModelError("Никнейм", "Некорректный никнейм, поробуйте ввести другой");
            }
            else if (player.NickName.Length > 2)
            {
                ModelState.AddModelError("Никнейм", "Недопустимая длина строки");
            }


            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Запрос не прошел валидацию";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
