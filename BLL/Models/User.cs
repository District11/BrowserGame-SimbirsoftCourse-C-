using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Bg_DAL
{ /// <summary>
/// Класс пользователя пользователя 
/// </summary>
    public class User : IdentityUser
    {/// <summary>
    /// Возраст игрока
    /// </summary>
       public int Year { get; set; }
        /// <summary>
        /// Персональная почта пользователя
        /// </summary>
       override public string  Email { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
       public string Name { get; set; }
    }
}