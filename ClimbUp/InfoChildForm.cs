using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class InfoChildForm : Form
    {
        // Переменные для временного хранения информации о ребенке.
        private string idChild, fullNameChild, sexChild, ageChild, sportCategoryChild, commentsChild;
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());

        public InfoChildForm(string idChild)
        {
            InitializeComponent();
            new History(15, null, idChild, null, null, null); // Запись действия в историю.
            this.idChild = idChild; // Получение ID ребенка, при открытии окна.
            LoadData(); // Выполнение метода LoadData().
            LoadClients(); // Выполнение метода LoadClients().
            LoadTrainings(); // Выполнение метода LoadTrainings().
        }

        private void LoadData() // Метод загрузки данных из базы данных в форму.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных о ребенке.
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = new MySqlCommand(
                            "SELECT * FROM Children WHERE idChild = " + idChild, newConnection).ExecuteReader();
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
            textBoxIdChild.Text = idChild;
            textBoxFullNameChild.Text = fullNameChild;
            textBoxSexChild.Text = sexChild;
            textBoxAgeChild.Text = ageChild;
            textBoxCommentsChild.Text = commentsChild;
            textBoxChildSportCatigory.Text = sportCategoryChild;
        }

        private void LoadClients() // Метод загрузки данных, о клиентах привязанных к ребенку, в визуальную таблицу.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных о клиентах, привязанных к ребенку
                newDataTable.Load(new MySqlCommand(
                    "SELECT clients.idClient, clients.fullNameClient, clients.sexClient, " +
                    "clients.phoneNumberClient, clients.eMailClient, " +
                    "clients.sportCategoryClient, clients.commentsClient " +
                    "FROM clients_has_children LEFT JOIN clients USING (idClient) " +
                    "WHERE clients_has_children.idChild = " + idChild +
                    " ORDER BY clients.fullNameClient", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridViewClients.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadClients()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            for (int i = 0; i < dataGridViewClients.Columns.Count; i++)
                dataGridViewClients.Columns[i].HeaderText = TranslateHeading.Translate(dataGridViewClients.Columns[i].HeaderText);
            // Установка ширины колонок талицы.
            dataGridViewClients.Columns[0].Width = 22;
            dataGridViewClients.Columns[1].Width = 200;
            dataGridViewClients.Columns[2].Width = 60;
            dataGridViewClients.Columns[3].Width = 120;
            dataGridViewClients.Columns[5].Width = 140;
            dataGridViewClients.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClients.Columns[6].MinimumWidth = 100;
        }

        private void LoadTrainings() // Метод загрузки данных о тренировках ребенка.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных о тренировках ребенка.
                newDataTable.Load(new MySqlCommand("SELECT schedule.idSchedule, " +
                    "deysweek.deyWeek, timetraining.time, typetraining.type, coaches.fullNameCoach " +
                    "FROM (((schedule LEFT JOIN coaches USING (idCoach)) " +
                    "LEFT JOIN timetraining USING (idTimeTraining)) " +
                    "LEFT JOIN deysweek USING (idDeyWeek)) " +
                    "LEFT JOIN typetraining USING (idTypeTraining) " +
                    "WHERE idChild = " + idChild + " " +
                    "ORDER BY deysweek.idDeyWeek, timetraining.time", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridViewTraining.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadTrainings()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            for (int i = 0; i < dataGridViewTraining.Columns.Count; i++)
                dataGridViewTraining.Columns[i].HeaderText = TranslateHeading.Translate(dataGridViewTraining.Columns[i].HeaderText);
            // Установка ширины колонок талицы.
            dataGridViewTraining.Columns[0].Width = 22;
            dataGridViewTraining.Columns[1].Width = 100;
            dataGridViewTraining.Columns[2].Width = 140;
            dataGridViewTraining.Columns[3].Width = 150;
            dataGridViewTraining.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTraining.Columns[4].MinimumWidth = 100;
        }
        // Действия при нажатии кнопки 'Запись на тренировку'.
        private void buttonRecordOnTrainingChild_Click(object sender, EventArgs e)
        {
            //открывает дочернее окно RecordChildOnTrainingForm и передает idChild.
            RecordChildOnTrainingForm newMDIChild = new RecordChildOnTrainingForm(idChild);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Изменить данные ребенка'.
        private void buttonChangeChildInfo_Click(object sender, EventArgs e)
        {
            //открывает дочернее окно ChangeInfoChildForm и передает idChild.
            ChangeInfoChildForm newMDIChild = new ChangeInfoChildForm(idChild);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Обновить'.
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData(); // Выполнение метода LoadData().
            LoadClients(); // Выполнение метода LoadClients().
            LoadTrainings(); // Выполнение метода LoadTrainings().
        }
        // Действия при двойном клике в визуальной таблице с клиентами.
        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idClient = "";
            // Возврощает ID клиента, выбранной записи и сохраняет в idClient.
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
                idClient = row.Cells[0].Value.ToString();
            // Если переменная idClient не пустая - открывает дочернее окно InfoClientForm,
            // и передает idClient.
            if (idClient != "")
            {
                InfoClientForm newMDIChild = new InfoClientForm(idClient);
                newMDIChild.MdiParent = this.MdiParent;
                newMDIChild.Show();
            }
        }
    }
}
