using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class UserDateForm : Form
    {
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        public UserDateForm()
        {
            InitializeComponent();
            new History(35, null, null, null, null, null); // Запись действия в историю.
            if (DataBank.UserType != "Директор") buttonChangeData.Enabled = false;
            LoadData(); // Выполнение метода LoadData().
        }

        private void LoadData() // Метод вывода данных пользователя в поля интерфейса.
        {
            textBoxFullName.Text = DataBank.UserFullName;
            textBoxLogin.Text = DataBank.UserLogin;
            comboBoxType.Text = DataBank.UserType;
        }
        // Действия при нажании кнопки 'Изменить данные'.
        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            comboBoxType.Text = DataBank.UserType;
            textBoxFullName.Enabled = true;
            textBoxLogin.Enabled = true;
            comboBoxType.Enabled = true;
            buttonSaveData.Enabled = true;
            buttonChangeData.Enabled = false;
        }
        // Действия при нажании кнопки 'Сохранить данные'.
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для изменения данных о пользователе.
                new MySqlCommand(
                    "UPDATE users " +
                    "SET login = '" + textBoxLogin.Text + "'," +
                    "fullName = '" + textBoxFullName.Text + "'," +
                    "type = '" + comboBoxType.Text + "' " +
                    "WHERE login = '" + DataBank.UserLogin + "'", newConnection).ExecuteNonQuery();
                new History(28, null, null, null, null, null); // Запись действия в историю.
                newConnection.Close(); // Закрытие соединения с базой данных.
                // Перезапись новых данных клиента в классе DataBank.
                DataBank.UserFullName = textBoxFullName.Text;
                DataBank.UserLogin = textBoxLogin.Text;
                DataBank.UserType = comboBoxType.Text;
                // Изменение внешнего вида и доступа объектов интерфейса.
                textBoxFullName.Enabled = false;
                textBoxLogin.Enabled = false;
                comboBoxType.Enabled = false;
                buttonSaveData.Enabled = false;
                buttonChangeData.Enabled = true;
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод buttonSaveData_Click()"); newConnection.Close(); }
        }
        // Действия при нажании кнопки 'Изменить пароль'.
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxPassword.Visible = true;
            buttonChangePassword.Enabled = false;
        }
        // Действия при нажании кнопки 'Сохранить'.
        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            // Проверка ввода нового паролья. 
            if (textBoxPassword.Text != "" && textBoxNewPasswodrAgain.Text != "" && textBoxNewPasswodrAgain.Text != "")
            {
                if (textBoxPassword.Text != textBoxNewPassword.Text)
                {
                    if (textBoxNewPassword.Text == textBoxNewPasswodrAgain.Text)
                    {
                        try // Проверка ошибок.
                        {
                            newConnection.Open(); // Открытие соединения с базой данных.
                            // Создание новой команды SQL для изменения данных о клиенте.
                            DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                            new MySqlDataAdapter( "SELECT count(*) FROM users WHERE login = " +
                                DataBank.UserLogin + " AND password = " +
                                textBoxPassword.Text, newConnection).Fill(newDataTable);
                            // Проверка правильности ввода пароля - если newDataAdapter вернул строку, 
                            // которая совпала с логином и паролем - выполнить следующие действия.
                            if (newDataTable.Rows[0][0].ToString() == "1")
                            {
                                // Создание новой команды SQL для обновление пароля.
                                new MySqlCommand( "UPDATE users SET password = " + textBoxNewPassword.Text + " " +
                                    "WHERE login = '" + DataBank.UserLogin + "'", newConnection).ExecuteNonQuery();
                                new History(29, null, null, null, null, null); // Запись действия в историю.
                                newConnection.Close(); // Закрытие соединения с базой данных.
                                MessageBox.Show("Пароль изменен!"); // Вывод сообщения о проведенной операции.
                                // Изменение внешнего вида и доступа объектов интерфейса.
                                groupBoxPassword.Visible = false;
                                buttonChangePassword.Enabled = true;
                                textBoxLogin.Text = "";
                                textBoxNewPassword.Text = "";
                                textBoxNewPasswodrAgain.Text = "";
                            }
                            else // Иначе - вывод сообщения о неверном пароле.
                            {
                                newConnection.Close();
                                MessageBox.Show("Неверный пароль!");
                            }
                        }
                        catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
                        { MessageBox.Show(ex.Message, "Ошибка! Метод buttonSavePassword_Click()");
                            newConnection.Close(); }
                    }
                    else MessageBox.Show("Новый пароль не совпадает с повторным вводом!");
                }
                else  MessageBox.Show("Старый и новый пароли совпадают!");
            }
            else MessageBox.Show("Введите данные.");
        }

        private void ButtonViewHistory_Click(object sender, EventArgs e)
        {
            HistoryForm newMDIChild = new HistoryForm(DataBank.UserLogin);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
    }
}
