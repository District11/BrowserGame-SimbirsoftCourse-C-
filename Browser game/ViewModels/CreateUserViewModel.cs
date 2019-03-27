namespace Browser_game.ViewModels
{/// <summary>
/// Класс позволяющий создать нового пользователя
/// </summary>
    public class CreateUserViewModel
    {/// <summary>
     /// Почта пользователя
     /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Возраст игрока
        /// </summary>
        public int Year { get; set; }
    }
}