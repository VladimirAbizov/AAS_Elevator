namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Учетная запись пользователя
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public int Password { get; set; }

        /// <summary>
        /// Категория пользователей
        /// </summary>
        public string Category { get; set; }
    }
}