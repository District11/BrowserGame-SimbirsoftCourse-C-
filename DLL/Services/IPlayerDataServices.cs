using System;
using System.Collections.Generic;
using System.Text;
using Bg_DAL.Models;
using System.Threading.Tasks;

namespace Bg_DAL.Services
{
   public interface IPlayerDataServices
    {
  
        /// <summary>
        /// получение информации по ID
        /// </summary>
        /// <param name="PlayerID"></param>
        /// <returns></returns>
        Task<IList<PlayerData>>  GetPlayerData(int PlayerID);
        /// <summary>
        /// изменение информации об игроке
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        Task UpdatePlayer (PlayerData player);
        /// <summary>
        /// удаление  информации об игроке
        /// </summary>
        /// <param name="PlayerID"></param>
        /// <returns></returns>
        Task DeletePlayer(int PlayerID);
        /// <summary>
        /// Создание нового игрока в Базе данных
        /// </summary>
        /// <returns></returns>
        Task CreatePlayer(PlayerData player);
        /// <summary>
        ///Получение детальной информации об игрокке
        /// </summary>
        /// <param name="PlayerID"></param>
        /// <returns></returns>
        Task<PlayerData> GetDetails(int PlayerID);

        



    }
}
