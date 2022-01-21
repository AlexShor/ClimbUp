using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class ChangeInfoClientForm : Form
    {
        // Переменные для временного хранения информации о клиенте.
        private string idClient, fullNameClient, sexClient, phoneNumberClient, 
            eMailClient, sportCategoryClient, commentsClient;
        // Массив временного хранения информации о клиенте для отмены изменений.
        private List<string> listDate = new List<string>();
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        private string messegStatus; // Переменная для хранения текста сообщения.

        public ChangeInfoClientForm(string idClient)
        {
            InitializeComponent();
            new History(12, idClient, null, null, null, null); // Запись действия в историю.
            this.idClient = idClient; // Получение ID ребенка, при открытии окна.
            LoadData(); // Выполнение метода LoadData().
        }

        private void LoadData() // Метод загрузки данных из базы данных в форму.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных о клиенте.
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = new MySqlCommand(
                            "SELECT * FROM clients WHERE idClient = " + idClient, newConnection).ExecuteReader();
                // Чтение полученых данных с помощью newCommand,
                // и сохранение их во временных переменных.
                while (newDataReader.Read())
                {
                    fullNameClient = newDataReader[1].ToString();
                    sexClient = newDataReader[2].ToString();
                    phoneNumberClient = newDataReader[3].ToString();
                    eMailClient = newDataReader[4].ToString();
                    sportCategoryClient = newDataReader[5].ToString();
                    commentsClient = newDataReader[6].ToString();
                }
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close(); }
            // Занесение данных клиента из переменных в поля интерфейса окна.
            textBoxFullNameClient.Text = fullNameClient;
            comboBoxSexClient.Text = sexClient;
            textBoxPhoneNumberClient.Text = phoneNumberClient;
            textBoxEMailClient.Text = eMailClient;
            textBoxCommentsClient.Text = commentsClient;
            comboBoxClientSportCatigory.Text = sportCategoryClient;
        }
        // Действия при нажании кнопки 'Изменить данные'.
        private void buttonEditData_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            textBoxFullNameClient.Enabled = true;
            comboBoxSexClient.Enabled = true;
            textBoxPhoneNumberClient.Enabled = true;
            textBoxEMailClient.Enabled = true;
            textBoxCommentsClient.Enabled = true;
            comboBoxClientSportCatigory.Enabled = true;
            buttonSaveData.Enabled = true;
            buttonEditData.Enabled = false;
        }
        // Действия при нажании кнопки 'Сохранить изменения'.
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // Занесение введенных данных в массив listDate.
            listDate.Add(textBoxFullNameClient.Text);
            listDate.Add(comboBoxSexClient.Text);
            listDate.Add(textBoxPhoneNumberClient.Text);
            listDate.Add(textBoxEMailClient.Text);
            listDate.Add(textBoxCommentsClient.Text);
            listDate.Add(comboBoxClientSportCatigory.Text);

            messegStatus = "Данные сохранены!"; // Изменение статуса сообщения.
            SaveData(); // Выполнение метода SaveData().
            new History(6, idClient.ToString(), null, null, null, null); // Запись действия в историю.
            // Изменение внешнего вида и доступа объектов интерфейса.
            textBoxFullNameClient.Enabled = false;
            comboBoxSexClient.Enabled = false;
            textBoxPhoneNumberClient.Enabled = false;
            textBoxEMailClient.Enabled = false;
            textBoxCommentsClient.Enabled = false;
            comboBoxClientSportCatigory.Enabled = false;
            buttonEditData.Enabled = true;
            buttonCancelChange.Enabled = true;
            buttonSaveData.Enabled = false;
        }

        private void SaveData() // Метод для изменения данных о клиенте.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для изменения данных о клиенте.
                new MySqlCommand("UPDATE clients " +
                    "SET fullNameClient = '" + listDate[0] + "'," +
                    "sexClient = '" + listDate[1] + "'," +
                    "phoneNumberClient = '" + listDate[2] + "'," +
                    "eMailClient = '" + listDate[3] + "'," +
                    "commentsClient = '" + listDate[4] + "'," +
                    "sportCategoryClient = '" + listDate[5] + "' " +
                    "WHERE idClient = '" + idClient + "'", newConnection).ExecuteNonQuery();
                MessageBox.Show(messegStatus); // Вывод сообщения о проведенной операции.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод SaveData()"); newConnection.Close(); }
        }
        // Действия при нажатии кнопки 'Отменить изменения'.
        private void buttonCancelChange_Click(object sender, EventArgs e)
        {
            // Внесение в массив ранее сохраненных данных о клиенте.
            listDate[0] = fullNameClient;
            listDate[1] = sexClient;
            listDate[2] = phoneNumberClient;
            listDate[3] = eMailClient;
            listDate[4] = commentsClient;
            listDate[5] = sportCategoryClient;

            messegStatus = "Все изменения отменены!"; // Изменение статуса сообщения.
            SaveData(); // Выполнение метода SaveData().
            new History(7, idClient.ToString(), null, null, null, null); // Запись действия в историю.
            // Занесение ранее сохраненных данных клиента из переменных в поля интерфейса окна.
            textBoxFullNameClient.Text = fullNameClient;
            comboBoxSexClient.Text = sexClient;
            textBoxPhoneNumberClient.Text = phoneNumberClient;
            textBoxEMailClient.Text = eMailClient;
            textBoxCommentsClient.Text = commentsClient;
            comboBoxClientSportCatigory.Text = sportCategoryClient;
            // Изменение внешнего вида и доступа объектов интерфейса.
            textBoxFullNameClient.Enabled = false;
            comboBoxSexClient.Enabled = false;
            textBoxPhoneNumberClient.Enabled = false;
            textBoxEMailClient.Enabled = false;
            textBoxCommentsClient.Enabled = false;
            comboBoxClientSportCatigory.Enabled = false;
            buttonEditData.Enabled = true;
            buttonCancelChange.Enabled = false;
        }
    }
}
