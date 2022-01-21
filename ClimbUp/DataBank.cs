namespace ClimbUp
{
    class DataBank // Класс, для хранения и использования в других классах, информации.
    {
        // Поля для временного хранения данных о пользователе.
        public static string UserLogin { get; set; }
        public static string UserFullName { get; set; }
        public static string UserType { get; set; }
        public static string idClient { get; set; }
        // Поле для хранения строки подключения к базе данных.
        private static string ConnectionString = "server=localhost;user=root;database=climbingwall;password=123456";
        // метод получения строки подключения к базе данных.
        public static string GetConnectionString() => ConnectionString;
    }
}
