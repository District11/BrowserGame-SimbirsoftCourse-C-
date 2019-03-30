using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace Bg_DAL.Models
{ /// <summary>
/// Класс пользователя 
/// </summary>
    public class UserData : IdentityUser
    {/// <summary>
     /// Возраст игрока
     /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Персональная почта пользователя
        /// </summary>
        override public string Email { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
    }
}

