using System;
using System.Collections.Generic;
using System.Text;
using Bg_DAL.Models;
using System.Threading.Tasks;

namespace Bg_DAL.Services
{
    public interface IUserDataServices
    {
        /// <summary>
        /// получение информации по Электронной почте пользователя
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        Task<IList<UserData>> GetUserData(string Email);
        /// <summary>
        /// изменение информации об Пользователе
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task UpdateUser(UserData user);
        /// <summary>
        /// удаление  информации об игроке
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        Task DeleteUser(string Email);
        /// <summary>
        ///  /// Создание нового пользователя в Базе данных
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task CreateUser(UserData user);
    }
}
