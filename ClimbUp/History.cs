using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    class History
    {
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        private string userLogin, idCoach, idSchedule, idChild, idClient, additionalInfo;
        private int historyEventNumber;
        private List<string> historyEvent = new List<string>()
        {
            "Авторизация", // 1
            "Добавление клиента в базу данных", // 2
            "Добавление ребенка в базу данных", // 3
            "Изменение данных ребенка", // 4
            #region...
            "Отмена изменений данных ребенк", // 5
            "Изменение данных клиента", // 6
            
            "Отмена изменений данных клиента", // 7
            "Поиск по клиентам", // 8
            "Поиск по детям", // 9
            "Открытие окна Запись клиента на тренировку", // 10
            "Открытие окна Запись ребенка на тренировку", // 11
            "Открытие окна Изменить данные клиента", // 12
            "Открытие окна Изменить данные ребенка", // 13
            "Открытие окна Информация о клиенте", // 14
            "Открытие окна Информация о ребенке", // 15
            "Экспорт в Excel из таблицы Клиенты", // 16
            "Экспорт в Excel из таблицы Дети", // 17
            "Удаление сотрудника (тренера) из базы", // 18
            "Изменение данных трененра", // 19
            "Добавление нового тренера", // 20
            "Переавторизация", // 21
            "Выход из аккаунта", // 22
            "Выход из приложения", // 23
            "Вход в приложение", // 24
            "Запись ребенка на тренировку", // 25
            "Удаление тренировки ребенка", // 26
            "Удаление тренировки клиента", // 27
            "Изменение личных данных", // 28
            "Изменение пароля", // 29
            "Удаление пользователя из базы", // 30
            "Обновление данных пользователя", // 31
            "Сброс паролья пользователя", // 32
            "Добавление пользователя в базу", // 33
            "Открытие окна Пользователи", // 34
            "Открытие окна Данные пользователя", // 35
            "Открытие окна Рисписание тренировок", // 36
            #endregion
            "Открытие окна Тренера", // 37
            "Открытие окна Клиенты", // 38
            "Открытие окна Авторизация", // 39
            "Открытие окна Добавить клиента", // 40
            "Запись клиента на тренировку" // 41
        };
        public History(int historyEventNumber, string idClient, string idChild, 
            string idSchedule, string idCoach, string additionalInfo)
        {
            this.historyEventNumber = historyEventNumber - 1;
            userLogin = DataBank.UserLogin ?? "DEFAULT";
            this.idClient = idClient ?? "DEFAULT";
            this.idChild = idChild ?? "DEFAULT";
            this.idSchedule = idSchedule ?? "DEFAULT";
            this.idCoach = idCoach ?? "DEFAULT";
            this.additionalInfo = additionalInfo != null ? "'" + additionalInfo + "'" : "DEFAULT";
            historyRecord(); 
        }

        private void historyRecord()
        {
            try
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для записи данных.
                new MySqlCommand(
                    "INSERT INTO history (" +
                        "login, idCoach, idSchedule, idChild, idClient, " +
                        "historyEvent, historyDateTime, additionalInfo) " +
                    "VALUES (" +
                        userLogin + "," +
                        idCoach + "," +
                        idSchedule + "," +
                        idChild + "," +
                        idClient + ",'" +
                        historyEvent[historyEventNumber] + "'," +
                        "NOW()" + "," +
                        additionalInfo + ");", newConnection).ExecuteNonQuery();
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод historyRecord()"); newConnection.Close(); }
        }
    }
}
