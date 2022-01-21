using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class InfoClientForm : Form
    {
        // Переменные для временного хранения информации о клиенте.
        private string idClient, fullNameClient, sexClient, phoneNumberClient, 
            eMailClient, sportCategoryClient, commentsClient;
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());

        public InfoClientForm(string idClient)
        {
            InitializeComponent();
            new History(14, idClient, null, null, null, null); // Запись действия в историю.
            this.idClient = idClient; // Получение ID клиента, при открытии окна.
            LoadData(); // Выполнение метода LoadData().
            LoadChildren(); // Выполнение метода LoadChildren().
            LoadTrainings(); // Выполнение метода LoadTrainings().
        }

        private void LoadData() // Метод загрузки данных из базы данных в форму.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных о клиенте.
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = new MySqlCommand(
                    "SELECT * FROM clients WHERE idClient = '" + 
                    idClient + "'", newConnection).ExecuteReader();
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
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close();
            }
            // Занесение данных клиента из переменных в поля интерфейса окна.
            textBoxIdClient.Text = idClient;
            textBoxFullNameClient.Text = fullNameClient;
            textBoxSexClient.Text = sexClient;
            textBoxPhoneNumberClient.Text = phoneNumberClient;
            textBoxEMailClient.Text = eMailClient;
            textBoxCommentsClient.Text = commentsClient;
            textBoxClientSportCatigory.Text = sportCategoryClient;
        }

        private void LoadChildren() // Метод загрузки данных, о детях привязанных к клиенты, в визуальную таблицу.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных о детях, привязанных к клиенту
                newDataTable.Load(new MySqlCommand(
                    "SELECT Children.idChild, Children.fullNameChild, Children.ageChild, " +
                    "Children.sexChild, Children.sportCategoryChild, Children.commentsChild " +
                    "FROM clients_has_children LEFT JOIN children USING (idChild) " +
                    "WHERE clients_has_children.idClient = " + idClient +
                    " ORDER BY children.fullNameChild", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridViewChildren.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadClients()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            foreach (DataGridViewColumn text in dataGridViewChildren.Columns)
                text.HeaderText = TranslateHeading.Translate(text.HeaderText);
            // Установка ширины колонок талицы.
            dataGridViewChildren.Columns[0].Width = 22;
            dataGridViewChildren.Columns[1].Width = 200;
            dataGridViewChildren.Columns[2].Width = 60;
            dataGridViewChildren.Columns[3].Width = 60;
            dataGridViewChildren.Columns[4].Width = 140;
            dataGridViewChildren.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewChildren.Columns[5].MinimumWidth = 100;
        }

        private void LoadTrainings() // Метод загрузки данных о тренировках клиента.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable();// Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных о тренировках клиента.
                newDataTable.Load(new MySqlCommand( "SELECT schedule.idSchedule, deysweek.deyWeek, " +
                    "timetraining.time, typetraining.type, coaches.fullNameCoach " +
                    "FROM (((schedule LEFT JOIN coaches USING (idCoach)) " +
                    "LEFT JOIN timetraining USING (idTimeTraining)) " +
                    "LEFT JOIN deysweek USING (idDeyWeek)) " +
                    "LEFT JOIN typetraining USING (idTypeTraining) " +
                    "WHERE idClient = " + idClient + " " +
                    "ORDER BY deysweek.idDeyWeek, timetraining.time", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridViewTraining.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadTrainings()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            foreach (DataGridViewColumn text in dataGridViewTraining.Columns)
                text.HeaderText = TranslateHeading.Translate(text.HeaderText);
            // Установка ширины колонок талицы.
            dataGridViewTraining.Columns[0].Width = 22;
            dataGridViewTraining.Columns[1].Width = 100;
            dataGridViewTraining.Columns[2].Width = 140;
            dataGridViewTraining.Columns[3].Width = 150;
            dataGridViewTraining.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTraining.Columns[4].MinimumWidth = 100;
        }
        // Действия при нажатии кнопки 'Запись на тренировку'.
        private void buttonRecordOnTrainingClient_Click(object sender, EventArgs e)
        {
            //открывает дочернее окно RecordClientOnTrainingForm и передает idClient.
            RecordClientOnTrainingForm newMDIChild = new RecordClientOnTrainingForm(idClient);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Изменить данные клиента'.
        private void buttonChangeClientInfo_Click(object sender, EventArgs e)
        {
            //открывает дочернее окно ChangeInfoClientForm и передает idClient.
            ChangeInfoClientForm newMDIChild = new ChangeInfoClientForm(idClient);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Обновить'.
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData(); // Выполнение метода LoadData().
            LoadChildren(); // Выполнение метода LoadChildren().
            LoadTrainings(); // Выполнение метода LoadTrainings().
        }
        // Действия при двойном клике в визуальной таблице с детьми.
        private void dataGridViewChildren_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idChild = "";
            // Возврощает ID ребенка, выбранной записи и сохраняет в idChild.
            foreach (DataGridViewRow row in dataGridViewChildren.SelectedRows)
                idChild = row.Cells[0].Value.ToString();
            // Если переменная idChild не пустая - открывает дочернее окно InfoChildForm,
            // и передает idChild.
            if (idChild != "")
            {
                InfoChildForm newMDIChild = new InfoChildForm(idChild);
                newMDIChild.MdiParent = this.MdiParent;
                newMDIChild.Show();
            }
        }
    }
}
