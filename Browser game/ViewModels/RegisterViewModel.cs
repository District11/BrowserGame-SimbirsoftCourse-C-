using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Модель для регистрации пользователя
/// </summary>
namespace Browser_game.ViewModels
{/// <summary>
/// Класс предстваляющий регистрирующего пользователя
/// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// Почта пользователя
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        /// <summary>
        /// Дата рождения пользователя
        /// </summary>
        [Required]
        [Display(Name = "Год рождения")]
        public int Year { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        /// <summary>
        /// Сообщение об ошибке для пользователя
        /// </summary>
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
