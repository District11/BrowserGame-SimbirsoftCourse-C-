using System;
using System.Collections.Generic;
using System.Text;
using Bg_DAL.Data;
using Bg_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace Bg_DAL.Services.Implementation
{
    internal class PlayerDataServices : IPlayerDataServices
    {
        private ApplicationDbContext db;
        public PlayerDataServices(ApplicationDbContext context)
        {
            db = context;
        }
        public async Task CreatePlayer(PlayerData player)
        {
            this.db.Players.Add(player);
            await this.db.SaveChangesAsync();
        }

        public async Task DeletePlayer(int PlayerID)
        {
            var player = await db.Players.FindAsync(PlayerID);
            db.Players.Remove(player);
            await db.SaveChangesAsync();
        }


        public async Task<IList<PlayerData>> GetPlayerData(int PlayerID)
        {
             return await db.Players.ToListAsync();
        }

        public async Task<PlayerData> GetDetails(int id)
        {
            var records = db.Players
                .FirstOrDefaultAsync(m => m.PlayerID == id);

            return await records;
        }
        public async Task UpdatePlayer(PlayerData player)
        {
            this.db.Players.Update(player);
            await this.db.SaveChangesAsync();
        }
    }
}



