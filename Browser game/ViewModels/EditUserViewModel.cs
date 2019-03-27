namespace Browser_game.ViewModels
{
    /// <summary>
    /// Класс редактирование информации пользователя
    /// </summary>
    public class EditUserViewModel
    { /// <summary>
      /// ID Пользоывтеля
      /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Почта пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        ///Возраст пользователя
        /// </summary>
        public int Year { get; set; }
    }
}