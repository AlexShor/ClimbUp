using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class ChangeInfoChildForm : Form
    {
        // Переменные для временного хранения информации о ребенке.
        private string idChild, fullNameChild, sexChild, ageChild, sportCategoryChild, commentsChild;
        // Массив временного хранения информации о ребенке для отмены изменений.
        private List<string> listDate = new List<string>();
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        private string messegStatus; // Переменная для хранения текста сообщения.

        public ChangeInfoChildForm(string idChild)
        {
            InitializeComponent();
            new History(13, null, idChild, null, null, null); // Запись действия в историю.
            this.idChild = idChild; // Получение ID ребенка, при открытии окна.
            LoadData(); // Выполнение метода LoadData().
        }

        private void LoadData() // Метод загрузки данных из базы данных в форму.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных о ребенке.
                MySqlCommand newCommand = new MySqlCommand(
                            "SELECT * FROM children WHERE idChild = " + idChild, newConnection);
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand,
                // и сохранение их во временных переменных.
                while (newDataReader.Read())
                {
                    fullNameChild = newDataReader[1].ToString();
                    ageChild = newDataReader[2].ToString();
                    sexChild = newDataReader[3].ToString();
                    sportCategoryChild = newDataReader[4].ToString();
                    commentsChild = newDataReader[5].ToString();
                }
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close(); }
            // Занесение данных ребенка из переменных в поля интерфейса окна.
            textBoxFullNameChild.Text = fullNameChild;
            comboBoxSexChild.Text = sexChild;
            textBoxAgeChild.Text = ageChild;
            textBoxCommentsChild.Text = commentsChild;
            comboBoxChildSportCatigory.Text = sportCategoryChild;
        }
        // Действия при нажании кнопки 'Изменить данные'.
        private void buttonEditData_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            textBoxFullNameChild.Enabled = true;
            comboBoxSexChild.Enabled = true;
            textBoxAgeChild.Enabled = true;
            textBoxCommentsChild.Enabled = true;
            comboBoxChildSportCatigory.Enabled = true;
            buttonSaveData.Enabled = true;
            buttonEditData.Enabled = false;
        }
        // Действия при нажании кнопки 'Сохранить изменения'.
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // Занесение введенных данных в массив listDate.
            listDate.Add(textBoxFullNameChild.Text);
            listDate.Add(textBoxAgeChild.Text);
            listDate.Add(comboBoxSexChild.Text);
            listDate.Add(comboBoxChildSportCatigory.Text);
            listDate.Add(textBoxCommentsChild.Text);

            messegStatus = "Данные сохранены!"; // Изменение статуса сообщения.
            SaveData(); // Выполнение метода SaveData().
            new History(4, null, idChild.ToString(), null, null, null); // Запись действия в историю.
            // Изменение внешнего вида и доступа объектов интерфейса.
            textBoxFullNameChild.Enabled = false;
            comboBoxSexChild.Enabled = false;
            textBoxAgeChild.Enabled = false;
            textBoxCommentsChild.Enabled = false;
            comboBoxChildSportCatigory.Enabled = false;
            buttonEditData.Enabled = true;
            buttonCancelChange.Enabled = true;
            buttonSaveData.Enabled = false;
        }
        
        private void SaveData() // Метод для изменения данных о ребенке.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для изменения данных о ребенке.
                new MySqlCommand("UPDATE Children " +
                    "SET fullNameChild = '" + listDate[0] + "'," +
                    "ageChild = '" + listDate[1] + "'," +
                    "sexChild = '" + listDate[2] + "'," +
                    "sportCategoryChild = '" + listDate[3] + "'," +
                    "commentsChild = '" + listDate[4] + "' " +
                    "WHERE idChild = '" + idChild + "'", newConnection).ExecuteNonQuery();
                MessageBox.Show(messegStatus); // Вывод сообщения о проведенной операции.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод SaveData()"); newConnection.Close(); }
        }
        // Действия при нажатии кнопки 'Отменить изменения'.
        private void buttonCancelChange_Click(object sender, EventArgs e)
        {
            // Внесение в массив ранее сохраненных данных о ребенке.
            listDate[0] = fullNameChild;
            listDate[1] = ageChild;
            listDate[2] = sexChild;
            listDate[3] = sportCategoryChild;
            listDate[4] = commentsChild;

            messegStatus = "Все изменения отменены!"; // Изменение статуса сообщения.
            SaveData(); // Выполнение метода SaveData().
            new History(5, null, idChild.ToString(), null, null, null); // Запись действия в историю.
            // Занесение ранее сохраненных данных ребенка из переменных в поля интерфейса окна.
            textBoxFullNameChild.Text = fullNameChild;
            comboBoxSexChild.Text = sexChild;
            textBoxAgeChild.Text = ageChild;
            textBoxCommentsChild.Text = commentsChild;
            comboBoxChildSportCatigory.Text = sportCategoryChild;
            // Изменение внешнего вида и доступа объектов интерфейса.
            textBoxFullNameChild.Enabled = false;
            comboBoxSexChild.Enabled = false;
            textBoxAgeChild.Enabled = false;
            textBoxCommentsChild.Enabled = false;
            comboBoxChildSportCatigory.Enabled = false;
            buttonEditData.Enabled = true;
            buttonCancelChange.Enabled = false;
        }
    }
}
