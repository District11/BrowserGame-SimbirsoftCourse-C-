using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Browser_game.ViewModels
{
/// <summary>
///Модель для входа в систему
/// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Почта пользователя
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        /// <summary>
        /// метод для запоминания пароля
        /// </summary>
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
        /// <summary>
        /// Метод для возвращения URL
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
