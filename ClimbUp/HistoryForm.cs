using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class HistoryForm : Form
    {
        private string requestString; // Строка дополнительного SQL запроса для критериев поиска.
        private List<string> historyEvent = new List<string>() // Массив для заполнения comboBoxTypeEvent.
        {
            "", "Авторизация", "Добавление клиента в базу данных", "Добавление ребенка в базу данных",
            "Изменение данных ребенка", "Изменение данных клиента", "Экспорт в Excel из таблицы Клиенты",
            "Экспорт в Excel из таблицы Дети", "Удаление сотрудника (тренера) из базы", "Изменение данных трененра",
            "Добавление нового тренера", "Выход из аккаунта", "Запись ребенка на тренировку",
            "Запись клиента на тренировку", "Удаление тренировки ребенка", "Удаление тренировки клиента",
            "Изменение личных данных", "Изменение пароля", "Удаление пользователя из базы",
            "Обновление данных пользователя", "Сброс паролья пользователя", "Добавление пользователя в базу"
        };
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        public HistoryForm(string request)
        {
            InitializeComponent();
            requestString = request != null ? "= " + request + ")" : "IS NOT NULL OR login IS NULL)";
            dateTimePicker.Value = DateTime.Today;
            comboBoxTypeEvent.DataSource = historyEvent; // Заполнение comboBoxTypeEvent.
            UpdateSearch(); // Выполнить метод UpdateSearch().
        }

        private void LoadData(string ExtraSqlQuery)
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL.
                MySqlDataReader newDataReader = new MySqlCommand(
                    "SELECT history.historyDateTime, users.login, history.historyEvent, history.additionalInfo, " +
                    "coaches.fullNameCoach, clients.fullNameClient, children.fullNameChild, " +
                    "deysweek.deyWeek, timetraining.time, typetraining.type " +
                    "FROM (((((((history LEFT JOIN users USING (login)) " +
                    "LEFT JOIN coaches USING (idCoach)) " +
                    "LEFT JOIN clients USING (idClient)) " +
                    "LEFT JOIN children USING (idChild)) " +
                    "LEFT JOIN schedule USING (idSchedule)) " +
                    "LEFT JOIN typetraining USING (idTypeTraining)) " +
                    "LEFT JOIN deysweek USING (idDeyWeek)) " +
                    "LEFT JOIN timetraining USING (idTimeTraining) " +
                    "WHERE (login " + requestString + " " +
                    ExtraSqlQuery, newConnection).ExecuteReader();
                while (newDataReader.Read())
                {
                    textBoxHistory.Text += "| " + newDataReader[0].ToString() + " | "; // history.historyDateTime
                    textBoxHistory.Text += newDataReader[1].ToString() != "" ?
                        "Пользователь: " + newDataReader[1].ToString() + " | " : ""; // users.login
                    textBoxHistory.Text += newDataReader[2].ToString() + " | "; // history.historyEvent

                    textBoxHistory.Text += newDataReader[3].ToString() != "" ? 
                        " | " + newDataReader[3].ToString() + " | " : ""; // history.additionalInfo
                    textBoxHistory.Text += newDataReader[4].ToString() != "" ?
                        " | " + newDataReader[4].ToString() + " | " : ""; // coaches.fullNameCoach
                    textBoxHistory.Text += newDataReader[5].ToString() != "" ?
                        " | " + newDataReader[5].ToString() + " | " : ""; // clients.fullNameClient
                    textBoxHistory.Text += newDataReader[6].ToString() != "" ?
                        " | " + newDataReader[6].ToString() + " | " : ""; // children.fullNameChild

                    textBoxHistory.Text += newDataReader[7].ToString() != "" ?
                        " | День недели: " + newDataReader[7].ToString() + " " : ""; // deysweek.deyWeek
                    textBoxHistory.Text += newDataReader[8].ToString() != "" ?
                        "Время: " + newDataReader[8].ToString() + " " : ""; // timetraining.time
                    textBoxHistory.Text += newDataReader[9].ToString() != "" ?
                        "Тип: " + newDataReader[9].ToString() + " | " : ""; // typetraining.type

                    textBoxHistory.Text += Environment.NewLine;
                }
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close(); }
        }
        // Действия при нажатии кнопки 'Обновить'.
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateSearch(); // Выполнение метода UpdateSearch().
        }

        private void UpdateSearch() // Метод формирования дополнительного SQL запроса для критериев поиска.
        {
            string ExtraSqlQuery = "";
            ExtraSqlQuery += dateTimePicker.Checked ? "AND DATE(history.historyDateTime) = '" +
                            dateTimePicker.Value.ToString() + "%' " : "";
            ExtraSqlQuery += comboBoxTypeEvent.Text != "" ?
                "AND history.historyEvent = '" + comboBoxTypeEvent.Text + "' " : "";
            textBoxHistory.Clear();
            LoadData(ExtraSqlQuery);
        }
    }
}
