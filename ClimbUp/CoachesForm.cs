using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class CoachesForm : Form
    {
        // Переменные для временного хранения информации о клиенте.
        private string idCoach, fullNameCoach, sexCoach, phoneNumberCoach,
            sportCategoryCoach, infoCoach, messegStatus;
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        // Массив временного хранения информации о клиенте для отмены изменений.
        private List<string> listDate = new List<string>();
        private List<string> headersCoaches = new List<string>() // Массив для хранения заголовков столбцов.
        { "idCoach", "fullNameCoach", "sexCoach", "phoneNumberCoach", "sportCategoryCoach", "infoCoach" };

        public CoachesForm()
        {
            InitializeComponent();
            new History(37, null, null, null, null, null); // Запись действия в историю.
            LoadData(); // Выполнение метода LoadData().
        }

        private void LoadData() // Метод загрузки данных из базы данных в визуальную таблицу.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных о тренерах.
                newDataTable.Load(new MySqlCommand( "SELECT * FROM coaches " +
                    "ORDER BY fullNameCoach", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridViewCoaches.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            for (int i = 0; i < dataGridViewCoaches.ColumnCount; i++)
                dataGridViewCoaches.Columns[i].HeaderText = TranslateHeading.Translate(headersCoaches[i]);
            // Установка ширины колонок талицы.
            dataGridViewCoaches.Columns[0].Width = 22;
            dataGridViewCoaches.Columns[1].Width = 220;
            dataGridViewCoaches.Columns[2].Width = 60;
            dataGridViewCoaches.Columns[3].Width = 120;
            dataGridViewCoaches.Columns[4].Width = 150;
            dataGridViewCoaches.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCoaches.Columns[5].MinimumWidth = 100;
        }

        private void loadDataCoach() // Метод загрузки данных из базы данных поля на форме.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных тренера.
                // Создание нового читателя данных MySqlCommand.
                MySqlDataReader newDataReader = new MySqlCommand(
                    "SELECT * FROM coaches WHERE idCoach = '" + idCoach + "'", newConnection).ExecuteReader();
                // Чтение полученых данных с помощью newCommand,
                // и сохранение их во временных переменных.
                while (newDataReader.Read())
                {
                    fullNameCoach = newDataReader[1].ToString();
                    sexCoach = newDataReader[2].ToString();
                    phoneNumberCoach = newDataReader[3].ToString();
                    sportCategoryCoach = newDataReader[4].ToString();
                    infoCoach = newDataReader[5].ToString();
                }
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод loadDataCoach()"); newConnection.Close(); }
            // Занесение данных тренера из переменных в поля интерфейса окна.
            textBoxCoachFullName.Text = fullNameCoach;
            comboBoxCoachSex.Text = sexCoach;
            textBoxCoachPhoneNumber.Text = phoneNumberCoach;
            textBoxCoachInfo.Text = infoCoach;
            comboBoxCoachSportCatigory.Text = sportCategoryCoach;
        }
        // Действия при выборе данных в визуальной таблице с тренерами.
        private void dataGridViewCoaches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            buttonDeleteCoach.Enabled = true;
            buttonChangeData.Enabled = true;
            groupBoxChangeData.Enabled = true;
            // Возврощает ID клиента, выбранной записи и сохраняет в idCoach.
            foreach (DataGridViewRow row in dataGridViewCoaches.SelectedRows)
                idCoach = row.Cells[0].Value.ToString();
            loadDataCoach();  // Выполнение метода loadDataCoach().
        }
        // Действия при нажатии кнопки 'Удалить из базы'.
        private void buttonDeleteCoach_Click(object sender, EventArgs e)
        {
            // Вызавает сообщение с подтверждением об удалении сотрудника.
            if (MessageBox.Show( "Вы действительно хотите удалить данного сотрудника?", "Удаление записи", 
                MessageBoxButtons.YesNo) == DialogResult.Yes) // Если в сообщении нажата кнопка - Да...
            {
                string id = "", name = "";
                // Возврощает ID и ФИО клиента, выбранной записи и сохраняет в id и name.
                foreach (DataGridViewRow row in dataGridViewCoaches.SelectedRows)
                    { id = row.Cells[0].Value.ToString(); name = row.Cells[1].Value.ToString(); }
                    
                try // Проверка ошибок.
                {
                    newConnection.Open(); // Открытие соединения с базой данных.
                    // Создание новой команды SQL для удаления тренера из базы данных.
                    new MySqlCommand("DELETE FROM coaches WHERE idCoach = " + id, newConnection).ExecuteNonQuery();
                    new History(18, null, null, null, null, name); // Запись действия в историю.
                    newConnection.Close(); // Закрытие соединения с базой данных.
                }
                catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
                { MessageBox.Show(ex.Message, "Ошибка! Метод buttonDeleteCoach_Click()"); newConnection.Close(); }
                buttonDeleteCoach.Enabled = false;
                buttonChangeData.Enabled = false;
                LoadData(); // Выполнение метода LoadData().
            }
        }
        // Действия при нажатии кнопки 'Изменить данные'.
        private void buttonChangeDate_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxCoachData.Enabled = true;
            groupBoxDGV.Enabled = false;
            groupBoxMain.Enabled = false;
            buttonSaveData.Enabled = true;
            buttonChangeData.Enabled = false;
            buttonAddCoach.Enabled = false;
        }
        // Действия при нажатии кнопки 'Сохранить' в groupBox'е 'Изменить данные'.
        private void buttonSaveDate_Click(object sender, EventArgs e)
        {
            // Внесение в массив введенных данных о тренере.
            listDate.Add(textBoxCoachFullName.Text);
            listDate.Add(comboBoxCoachSex.Text);
            listDate.Add(textBoxCoachPhoneNumber.Text);
            listDate.Add(textBoxCoachInfo.Text);
            listDate.Add(comboBoxCoachSportCatigory.Text);

            messegStatus = "Данные сохранены!"; // Изменение статуса сообщения.
            SaveData(); // Выполнение метода SaveData().
            new History(19, null, null, null, idCoach, null); // Запись действия в историю.
            LoadData(); // Выполнение метода LoadData().
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxCoachData.Enabled = false;
            groupBoxChangeData.Enabled = false;
            buttonDeleteCoach.Enabled = false;
            buttonSaveData.Enabled = false;
            buttonChangeData.Enabled = true;
            buttonAddCoach.Enabled = true;
            groupBoxMain.Enabled = true;
            groupBoxDGV.Enabled = true;
        }

        private void SaveData() // Метод изменения данных о тренере.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для обновления данных тренера.
                new MySqlCommand("UPDATE coaches SET fullNameCoach = '" + listDate[0] + "'," +
                    "sexCoach = '" + listDate[1] + "', phoneNumberCoach = '" + listDate[2] + "'," +
                    "infoCoach = '" + listDate[3] + "', sportCategoryCoach = '" + listDate[4] + "' " +
                    "WHERE idCoach= '" + idCoach + "'", newConnection).ExecuteNonQuery();
                MessageBox.Show(messegStatus); // Вывод сообщения о проведенной операции.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод SaveData()"); newConnection.Close(); }
        }
        // Действия при нажатии кнопки 'Добавить тренера'.
        private void buttonAddCoach_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxCoachData.Enabled = true;
            groupBoxDGV.Enabled = false;
            groupBoxChangeData.Enabled = false;
            buttonDeleteCoach.Enabled = false;
            buttonAdd.Enabled = true;
            buttonCancel.Enabled = true;
            buttonAddCoach.Enabled = false;
            textBoxCoachFullName.Text = "";
            textBoxCoachPhoneNumber.Text = "";
            comboBoxCoachSex.Text = "";
            comboBoxCoachSportCatigory.Text = "";
            textBoxCoachInfo.Text = "";
        }
        // Действия при нажатии кнопки 'Сохранить'.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для добавления нового тренера.
                MySqlCommand newCommand = new MySqlCommand(
                            "INSERT INTO coaches (fullNameCoach, phoneNumberCoach, " +
                            "sportCategoryCoach, sexCoach, infoCoach) " +
                            "VALUES ('" +
                            textBoxCoachFullName.Text + "'," +
                            textBoxCoachPhoneNumber.Text + ",'" +
                            comboBoxCoachSportCatigory.Text + "','" +
                            comboBoxCoachSex.Text + "','" +
                            textBoxCoachInfo.Text + "')", newConnection);
                // Выполняет оператор MySQL применительно к объекту Connection. 'Выполнение MySQL команды'.
                newCommand.ExecuteNonQuery();
                // Чтение ID последней добавленной записи и присвоение в переменную id.
                newCommand.CommandText = "SELECT @@identity";
                string id = newCommand.ExecuteScalar().ToString();
                new History(20, null, null, null, id, null); // Запись действия в историю.
                newConnection.Close(); // Закрытие соединения с базой данных.
                // Вывод сообщения о добавленом тренере.
                MessageBox.Show($"Тренер {textBoxCoachFullName.Text} добавлен!");
                // Изменение внешнего вида и доступа объектов интерфейса.
                buttonAddCoach.Enabled = true;
                groupBoxCoachData.Enabled = false;
                groupBoxDGV.Enabled = true;
                groupBoxChangeData.Enabled = false;
                buttonDeleteCoach.Enabled = false;
                buttonAdd.Enabled = false;
                buttonCancel.Enabled = false;
                textBoxCoachFullName.Text = "";
                textBoxCoachPhoneNumber.Text = "";
                comboBoxCoachSex.Text = "";
                comboBoxCoachSportCatigory.Text = "";
                textBoxCoachInfo.Text = "";
                LoadData();
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод buttonAdd_Click()"); newConnection.Close(); }
        }
        // Происходит после завершения операции привязки данных к визуальной таблицы в форме
        private void dataGridViewCoaches_DataBindingComplete(
            object sender, DataGridViewBindingCompleteEventArgs e) => 
            dataGridViewCoaches.Rows[0].Selected = false; // Снимает выделение с автоматически выделеной строки.
        // Действия при нажатии кнопки 'Отменить'.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxCoachData.Enabled = false;
            groupBoxDGV.Enabled = true;
            groupBoxChangeData.Enabled = false;
            buttonAdd.Enabled = false;
            buttonCancel.Enabled = false;
            buttonAddCoach.Enabled = true;
            textBoxCoachFullName.Text = "";
            textBoxCoachPhoneNumber.Text = "";
            comboBoxCoachSex.Text = "";
            comboBoxCoachSportCatigory.Text = "";
            textBoxCoachInfo.Text = "";
        }
    }
}
