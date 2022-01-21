using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class UsersForm : Form
    {
        // Переменные для временного хранения информации о пользователе.
        private string login, fullName, type, messegStatus;
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        // Массив временного хранения информации о пользователе для отмены изменений.
        private List<string> listDate = new List<string>();
        private List<string> headersUsers = new List<string>() // Массив для хранения заголовков столбцов.
        { "login", "fullName", "type" };

        public UsersForm()
        {
            InitializeComponent();
            new History(34, null, null, null, null, null); // Запись действия в историю.
            LoadData(); // Выполнение метода LoadData().
        }

        private void LoadData() // Метод загрузки данных из базы данных в визуальную таблицу.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных о пользователях.
                newDataTable.Load(new MySqlCommand(
                    "SELECT " + string.Join(", ", headersUsers.ToArray()) + " " +
                    "FROM users WHERE login != " + DataBank.UserLogin + " " +
                    "ORDER BY login", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridView.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close(); }
            // Перевод названий колонок из базы данных на русский.
            dataGridView.Columns[0].HeaderText = "Логин";
            dataGridView.Columns[1].HeaderText = "ФИО пользователя";
            dataGridView.Columns[2].HeaderText = "Должность";
            // Установка ширины колонок талицы.
            dataGridView.Columns[0].Width = 40;
            dataGridView.Columns[1].Width = 220;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].MinimumWidth = 100;
        }

        private void loadDataCoach() // Метод загрузки данных из базы данных поля на форме.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных тренера.
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = new MySqlCommand(
                    "SELECT * FROM users WHERE login = '" + login + "'", newConnection).ExecuteReader();
                // Чтение полученых данных с помощью newCommand,
                // и сохранение их во временных переменных.
                while (newDataReader.Read())
                {
                    fullName = newDataReader[2].ToString();
                    type = newDataReader[3].ToString();
                }
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод loadDataCoach()"); newConnection.Close(); }
            // Занесение данных тренера из переменных в поля интерфейса окна.
            textBoxFullName.Text = fullName;
            textBoxLogin.Text = login;
            comboBoxType.Text = type;
        }
        // Действия при выборе данных в визуальной таблице с тренерами.
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            buttonDelete.Enabled = true;
            buttonViewHistory.Enabled = true;
            buttonChangeData.Enabled = true;
            groupBoxChangeData.Enabled = true;
            // Возврощает ID клиента, выбранной записи и сохраняет в login.
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                login = row.Cells[0].Value.ToString();
            loadDataCoach();  // Выполнение метода loadDataCoach().
        }
        // Действия при нажатии кнопки 'Удалить из базы'.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Вызавает сообщение с подтверждением об удалении сотрудника.
            if (MessageBox.Show( "Вы действительно хотите удалить данного сотрудника?", "Удаление записи", 
                MessageBoxButtons.YesNo) == DialogResult.Yes) // Если в сообщении нажата кнопка - Да...
            {
                string log = "", fullName = "", type = "";
                // Возврощает логин, ФИО, тип пользователя, выбранной записи и сохраняет в log, fullName, type.
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    log = row.Cells[0].Value.ToString();
                    fullName = row.Cells[1].Value.ToString();
                    type = row.Cells[2].Value.ToString();
                }
                    
                try // Проверка ошибок.
                {
                    newConnection.Open(); // Открытие соединения с базой данных.
                    // Создание новой команды SQL для удаления пользователя из базы данных.
                    new MySqlCommand("DELETE FROM users WHERE login = " + log, newConnection).ExecuteNonQuery();
                    new History(30, null, null, null, null,
                        log + " " + fullName + " " + type); // Запись действия в историю.
                    newConnection.Close(); // Закрытие соединения с базой данных.
                }
                catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
                { MessageBox.Show(ex.Message, "Ошибка! Метод buttonDeleteCoach_Click()"); newConnection.Close(); }
                // Изменение внешнего вида и доступа объектов интерфейса.
                buttonDelete.Enabled = false;
                buttonViewHistory.Enabled = false;
                buttonChangeData.Enabled = false;
                textBoxFullName.Text = "";
                comboBoxType.Text = "Администратор";
                textBoxLogin.Text = "";
                LoadData(); // Выполнение метода LoadData().
            }
        }
        // Действия при нажатии кнопки 'Изменить данные'.
        private void buttonChangeDate_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxUsersData.Enabled = true;
            groupBoxDGV.Enabled = false;
            groupBoxMain.Enabled = false;
            buttonSaveData.Enabled = true;
            buttonChangeData.Enabled = false;
            buttonAddUser.Enabled = false;
        }
        // Действия при нажатии кнопки 'Сохранить' в groupBox'е 'Изменить данные'.
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // Внесение в массив введенных данных о тренере.
            listDate.Add(textBoxLogin.Text);
            listDate.Add(textBoxFullName.Text);
            listDate.Add(comboBoxType.Text);

            messegStatus = "Данные сохранены!"; // Изменение статуса сообщения.
            SaveData(checkBoxResetPassword.Checked); // Выполнение метода SaveData().
            LoadData(); // Выполнение метода LoadData().
            // Изменение внешнего вида и доступа объектов интерфейса.
            checkBoxResetPassword.Checked = false;
            groupBoxUsersData.Enabled = false;
            groupBoxChangeData.Enabled = false;
            buttonDelete.Enabled = false;
            buttonViewHistory.Enabled = false;
            buttonSaveData.Enabled = false;
            buttonChangeData.Enabled = true;
            buttonAddUser.Enabled = true;
            groupBoxMain.Enabled = true;
            groupBoxDGV.Enabled = true;
        }

        private void SaveData(bool password) // Метод обновления данных о тренере.
        {
            string resetPasswordString = "";
            if (password) resetPasswordString = "password = '123',";
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для обновления данных пользователя.
                new MySqlCommand( "UPDATE users " +
                    "SET login = '" + listDate[0] + "'," + resetPasswordString +
                    "fullName = '" + listDate[1] + "'," + "type = '" + listDate[2] + "' " +
                    "WHERE login= '" + login + "'", newConnection).ExecuteNonQuery();
                new History(31, null, null, null, null,
                    listDate[0] + " " + listDate[1] + " " + listDate[2]); // Запись действия в историю.
                if (password) new History(32, null, null, null, null,
                    listDate[0] + " " + listDate[1] + " " + listDate[2]); // Запись действия в историю.
                MessageBox.Show(messegStatus); // Вывод сообщения о проведенной операции.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод SaveData()"); newConnection.Close(); }
        }
        // Действия при нажатии кнопки 'Добавить пользователя'.
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            checkBoxResetPassword.Enabled = false;
            groupBoxUsersData.Enabled = true;
            groupBoxDGV.Enabled = false;
            groupBoxChangeData.Enabled = false;
            buttonDelete.Enabled = false;
            buttonViewHistory.Enabled = false;
            buttonAdd.Enabled = true;
            buttonCancel.Enabled = true;
            buttonAddUser.Enabled = false;
            textBoxFullName.Text = "";
            comboBoxType.Text = "Администратор";
            textBoxLogin.Text = "";
        }
        // Действия при нажатии кнопки 'Сохранить'.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для добавления нового пользоватея.
                new MySqlCommand( "INSERT INTO users (login, password, fullName, type) " +
                    "VALUES ('" + textBoxLogin.Text + "'," +
                    "123" + ",'" + textBoxFullName.Text + "','" +
                    comboBoxType.Text + "')", newConnection).ExecuteNonQuery();
                new History(33, null, null, null, null,
                    textBoxLogin.Text + " " + textBoxFullName.Text + " " + comboBoxType.Text); // Запись действия в историю.
                newConnection.Close(); // Закрытие соединения с базой данных.
                // Вывод сообщения о добавленом тренере.
                MessageBox.Show($"{comboBoxType.Text}: {textBoxFullName.Text} добавлен!");
                // Изменение внешнего вида и доступа объектов интерфейса.
                checkBoxResetPassword.Enabled = true;
                buttonAddUser.Enabled = true;
                groupBoxUsersData.Enabled = false;
                groupBoxDGV.Enabled = true;
                groupBoxChangeData.Enabled = false;
                buttonViewHistory.Enabled = false;
                buttonDelete.Enabled = false;
                buttonAdd.Enabled = false;
                buttonCancel.Enabled = false;
                textBoxFullName.Text = "";
                comboBoxType.Text = "Администратор";
                textBoxLogin.Text = "";
                LoadData();
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод buttonAdd_Click()"); newConnection.Close(); }
        }
        // Происходит после завершения операции привязки данных к визуальной таблицы в форме
        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) => 
            dataGridView.Rows[0].Selected = false; // Снимает выделение с автоматически выделеной строки.
        // Действия при нажатии кнопки 'Отменить'.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            checkBoxResetPassword.Enabled = true;
            groupBoxUsersData.Enabled = false;
            groupBoxDGV.Enabled = true;
            groupBoxChangeData.Enabled = false;
            buttonAdd.Enabled = false;
            buttonCancel.Enabled = false;
            buttonAddUser.Enabled = true;
            textBoxFullName.Text = "";
            comboBoxType.Text = "Администратор";
            textBoxLogin.Text = "";
        }

        private void buttonViewHistory_Click(object sender, EventArgs e)
        {
            // Возврощает ID клиента, выбранной записи и сохраняет в login.
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                login = row.Cells[0].Value.ToString();
            HistoryForm newMDIChild = new HistoryForm(login);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
    }
}
