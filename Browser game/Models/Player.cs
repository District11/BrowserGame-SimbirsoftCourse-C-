using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Browser_game.Models
{
    public class Player
    {
        [ScaffoldColumn(false)]
        public int PlayerID { get; set; }
        [Required(ErrorMessage = "Не указано никнейм")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        [Display(Name ="Никнейм")]
        public string NickName { get; set; }
        [Required(ErrorMessage ="Не указан возраст")]
        [Range(1, 100, ErrorMessage = "Недопустимый возраст")]
        [Display(Name ="Ваш возраст")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Не указано опыт игры")]
        [Range(1, 1000000000000, ErrorMessage = "Недопустимый опыт")]
        [Display(Name ="Ваш опыт игр")]
        public int Expirians { get; set; }
      
    }
}
