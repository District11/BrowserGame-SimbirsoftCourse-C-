using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Browser_game.Models
{
    public class Player
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        [ScaffoldColumn(false)]
        public int PlayerID { get; set; }
        /// <summary>
        /// Никнейм персонажа в игре
        /// </summary>
        [Required(ErrorMessage = "Не указано никнейм")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        [Display(Name ="Никнейм")]
        public string NickName { get; set; }
        /// <summary>
        /// Возраст персонажа
        /// </summary>
        [Required(ErrorMessage ="Не указан возраст")]
        [Range(1, 100, ErrorMessage = "Недопустимый возраст")]
        [Display(Name ="Ваш возраст")]
        public int Age { get; set; }
        /// <summary>
        /// Опыт персонажа в игре
        /// </summary>
        [Required(ErrorMessage = "Не указано опыт игры")]
        [Range(1, 1000000000000, ErrorMessage = "Недопустимый опыт")]
        [Display(Name ="Ваш опыт игр")]
        public int Expirians { get; set; }
        /// <summary>
        /// Рекорд игрока
        /// </summary>
        public double Records { get; set; }
      
    }
}
