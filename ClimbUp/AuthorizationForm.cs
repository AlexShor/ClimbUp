using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class AuthorizationForm : Form
    {
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        // Поле для передачи фиксации авторизации в класс MainForm.
        public static bool AuthorizationCheck { get; set; } = false;

        public AuthorizationForm()
        {
            InitializeComponent();
            new History(39, null, null, null, null, null); // Запись действия в историю.
        }
        // Действия при нажании кнопки 'Отмена'.
        private void CancelButton_Click(object sender, EventArgs e)
        { Close(); newConnection.Close(); }
        // Действия при нажании кнопки 'Войти'.
        private void AuthorizationButton_Click(object sender, EventArgs e) => 
            Authorization(); // Выполнение метода Authorization().

        private void Authorization() // Метод выполнения авторизации.
        {
            // Проверка на заполняемость полей ввода логина и пароля.
            if (textBoxLog.Text != "" && textBoxPass.Text != "")
            {
                try // Проверка ошибок.
                {
                    newConnection.Open(); // Открытие соединения с базой данных.
                    // Создание новой команды SQL для получения количества найденых строк,
                    // совподающих с логином и паролем.
                    MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(
                        "SELECT count(*) FROM users WHERE login = " + textBoxLog.Text + 
                        " AND password = " + textBoxPass.Text, newConnection);
                    DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                    // Занесение в объект таблицы данных из newDataAdapter.
                    newDataAdapter.Fill(newDataTable);
                    // Проверка правильности ввода пароля - если newDataAdapter вернул строку, 
                    // которая совпала с логином и паролем - выполнить следующие действия.
                    if (newDataTable.Rows[0][0].ToString() == "1")
                    {
                        // Создание новой команды SQL для получения данных авторизованного пользователя.
                        MySqlCommand newCommand = new MySqlCommand(
                            "SELECT login, fullName, type FROM Users WHERE login = " +
                            textBoxLog.Text, newConnection);
                        // Создание нового читателя данных newDataReader.
                        MySqlDataReader newDataReader = newCommand.ExecuteReader();
                        // Чтение полученых данных с помощью newCommand,
                        // и сохраниение их в классе DataBank.
                        while (newDataReader.Read())
                        {
                            DataBank.UserLogin = newDataReader[0].ToString();
                            DataBank.UserFullName = newDataReader[1].ToString();
                            DataBank.UserType = newDataReader[2].ToString();
                        }
                        AuthorizationCheck = true; // подтверждение о том что авторизация успешна.
                        newDataReader.Close(); // Закрытие читателя данных newDataReader.
                        newConnection.Close(); // Закрытие соединения с базой данных.
                        new History(1, null, null, null, null, null); // Запись действия в историю.
                        this.Close(); // Закрытие окна авторизации.
                    }
                    else // Если логин или пароль не верный...
                    {
                        AuthorizationCheck = false; // Подтверждение о том что авторизация не успешна.
                        newConnection.Close(); // Закрытие соединения с базой данных.
                        MessageBox.Show("Неверный логин или пароль!"); // Вывод сообщения.
                    }
                }
                catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
                { MessageBox.Show(ex.Message, "Ошибка! Метод Authorization()"); newConnection.Close(); }
            }
            else // Если не был введен логин или пароль...
            {
                AuthorizationCheck = false; // Подтверждение о том что авторизация не успешна.
                MessageBox.Show("Введите логин и пароль."); // Вывод сообщения.
            }
        }
    }
}
