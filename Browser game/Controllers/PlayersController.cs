using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Browser_game.Models;
using Bg_DAL.Services;
using Bg_DAL;

namespace Browser_game.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayerDataServices _player;

        public PlayersController(IPlayerDataServices player)
        {
            _player =player;
        }

        // GET: Players
        /// <summary>
        /// Получает список игроков 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            return View("Index", await _player.GetPlayerData(HttpContext.User.Identity.Name));
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _player.GetDetails((int)id);
        
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }
        /// <summary>
        /// Получаем страницу создание игрока
        /// </summary>
        /// <returns></returns>
        // GET: Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlayerID,NickName,Age,Expirians")] Player player)
        {
            if (ModelState.IsValid)
            {
                
                await _player.CreatePlayer(player);
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Players/Edit/5
        /// <summary>
        /// Получает стр редактирование игрока
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _player.GetDetails((int)id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        /// <summary>
        ///  Редактирование игрока информации об игроке
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlayerID,NickName,Age,Expirians")] Player player)
        {
            if (id != player.PlayerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _player.UpdatePlayer(player);
                }
                catch (DbUpdateConcurrencyException)
                {
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Players/Delete/5
        /// <summary>
        /// Получает стр удаление информации об игроке
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var player = await _player.GetDetails((int)id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        /// <summary>
        /// Удаляет информацию об игроке
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _player.DeletePlayer(id);
            return RedirectToAction(nameof(Index));
        }
 
    }
}
