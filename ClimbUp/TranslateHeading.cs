namespace ClimbUp
{
    class TranslateHeading // Класс перевода заголовков таблиц на русский.
    {
        private static string _idClient = "ID";
        private static string _fullNameClient = "ФИО клиента";
        private static string _sexClient = "Пол";
        private static string _phoneNumberClient = "Номер телефона";
        private static string _eMailClient = "E-Mail";
        private static string _sportCategoryClient = "Спортивный разряд";
        private static string _commentsClient = "Комментарии";

        private static string _idChild = "ID";
        private static string _fullNameChild = "ФИО ребенка";
        private static string _ageChild = "Возраст";
        private static string _sexChild = "Пол";
        private static string _sportCategoryChild = "Спортивный разряд";
        private static string _commentsChild = "Комментарии";

        private static string _idCoach = "ID";
        private static string _fullNameCoach = "ФИО тренера";
        private static string _sexCoach = "Пол";
        private static string _phoneNumberCoach = "Номер телефона";
        private static string _sportCategoryCoach = "Спортивный разряд";
        private static string _infoCoach = "Информация";

        private static string _idSchedule = "ID";
        private static string _deyWeek = "День недели";
        private static string _time = "Время тренировки";
        private static string _type = "Тип тренировки";
        // Метод принемает строку, если она имеется то возврощает перевод.
        public static string Translate(string text)
        {
            if (text == "idClient") text = _idClient;
            if (text == "fullNameClient") text = _fullNameClient;
            if (text == "sexClient") text = _sexClient;
            if (text == "phoneNumberClient") text = _phoneNumberClient;
            if (text == "eMailClient") text = _eMailClient;
            if (text == "sportCategoryClient") text = _sportCategoryClient;
            if (text == "commentsClient") text = _commentsClient;

            if (text == "idChild") text = _idChild;
            if (text == "fullNameChild") text = _fullNameChild;
            if (text == "ageChild") text = _ageChild;
            if (text == "sexChild") text = _sexChild;
            if (text == "sportCategoryChild") text = _sportCategoryChild;
            if (text == "commentsChild") text = _commentsChild;

            if (text == "idCoach") text = _idCoach;
            if (text == "fullNameCoach") text = _fullNameCoach;
            if (text == "sexCoach") text = _sexCoach;
            if (text == "phoneNumberCoach") text = _phoneNumberCoach;
            if (text == "sportCategoryCoach") text = _sportCategoryCoach;
            if (text == "infoCoach") text = _infoCoach;

            if (text == "idSchedule") text = _idSchedule;
            if (text == "deyWeek") text = _deyWeek;
            if (text == "time") text = _time;
            if (text == "type") text = _type;

            return text;
        }
    }
}
