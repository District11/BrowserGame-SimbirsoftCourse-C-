using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bg_DAL.Models
{
    public class PlayerData
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        public int PlayerID { get; set; }
        /// <summary>
        /// Никнейм персонажа в игре
        /// </summary>       
        public string NickName { get; set; }
        /// <summary>
        /// Возраст персонажа
        /// </summary>    
        public int Age { get; set; }
        /// <summary>
        /// Опыт персонажа в игре
        /// </summary>
        public int Expirians { get; set; }
      
    }
}
