using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class RecordChildOnTrainingForm : Form
    {
        // Переменные для временного хранения информации о ребенке.
        private string idChild, fullNameChild, sexChild, ageChild, sportCategoryChild, commentsChild;
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        // Массив для хранения заголовков столбцов.
        private List<string> headersSchedule = new List<string>()
        { "schedule.idSchedule", "deysweek.deyWeek", "timetraining.time",
          "typetraining.type", "coaches.fullNameCoach" };

        public RecordChildOnTrainingForm(string idChild)
        {
            InitializeComponent();
            new History(11, null, idChild, null, null, null); // Запись действия в историю.
            this.idChild = idChild; // Получение ID ребенка, при открытии окна.
            LoadData(); // Выполнение метода LoadData().
            UpdateDGVTrainings(); // Выполнение метода UpdateDGVTrainings().
        }

        private void LoadData() // Метод загрузки данных из базы данных в форму.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения данных о ребенке.
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = new MySqlCommand(
                    "SELECT * FROM children WHERE idChild = " + idChild, newConnection).ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и сохранение их во временных переменных.
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
            // Занесение данных клиента из переменных в поля интерфейса окна.
            textBoxFullNameChild.Text = fullNameChild;
            textBoxSexChild.Text = sexChild;
            textBoxAgeChild.Text = ageChild;
            textBoxCommentsChild.Text = commentsChild;
            textBoxChildSportCatigory.Text = sportCategoryChild;
        }
        // Действия при нажании кнопки 'Запись на тренировку'.
        private void buttonNewTraining_Click(object sender, EventArgs e)
        {
            groupBoxNewTraining.Enabled = true; // Изменение внешнего вида и доступа объекта интерфейса.
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения списка дней недели.
                MySqlCommand newCommand = new MySqlCommand(
                            "SELECT deyWeek FROM deysWeek", newConnection);
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в comboBoxDeyWeek.
                while (newDataReader.Read()) comboBoxDeyWeek.Items.Add(newDataReader[0].ToString());
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                // Создание новой команды SQL для получения списка времени тренировок.
                newCommand.CommandText = "SELECT time FROM timetraining";
                newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в comboBoxTimeTraining.
                while (newDataReader.Read()) comboBoxTimeTraining.Items.Add(newDataReader[0].ToString());
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                // Создание новой команды SQL для получения списка типов тренировок.
                newCommand.CommandText = "SELECT type FROM typetraining";
                newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в comboBoxTypeTraining.
                while (newDataReader.Read()) comboBoxTypeTraining.Items.Add(newDataReader[0].ToString());
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                // Создание новой команды SQL для получения списка имен трениров.
                newCommand.CommandText = "SELECT fullNameCoach FROM coaches";
                newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в comboBoxCoach.
                while (newDataReader.Read()) comboBoxCoach.Items.Add(newDataReader[0].ToString());
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод buttonNewTraining_Click()"); newConnection.Close(); }
            buttonNewTraining.Enabled = false; // Изменение внешнего вида и доступа объекта интерфейса.
        }
        // Действия при нажании кнопки 'Записать на тренировку'.
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            bool checkFilled = true;
            if (comboBoxDeyWeek.Text == "")
            {
                checkFilled = false;
                labelDeyWeek.ForeColor = Color.Tomato;
            }
            if (comboBoxTimeTraining.Text == "")
            {
                checkFilled = false;
                labelTimeTraining.ForeColor = Color.Tomato;
            }
            if (comboBoxTypeTraining.Text == "")
            {
                checkFilled = false;
                labelTypeTraining.ForeColor = Color.Tomato;
            }
            if (comboBoxCoach.Text == "")
            {
                checkFilled = false;
                labelCoach.ForeColor = Color.Tomato;
            }
            // Если необходимые поля были заполнены выполнить метод RecordOnTraining().
            if (checkFilled) RecordOnTraining();
        }
        
        private void RecordOnTraining() // Метод записи новой тренировки в базу.
        {
            string deyWeek = comboBoxDeyWeek.Text;
            string timeTraining = comboBoxTimeTraining.Text;
            string typeTraining = comboBoxTypeTraining.Text;
            string coach = comboBoxCoach.Text;

            string idDeyWeek = "";
            string idTimeTraining = "";
            string idTypeTraining = "";
            string idCoach = "";

            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для получения ID дня недели.
                MySqlCommand newCommand = new MySqlCommand(
                            "SELECT idDeyWeek FROM deysweek WHERE deyWeek = '" + deyWeek + "'", newConnection);
                MySqlDataReader newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в idDeyWeek.
                while (newDataReader.Read()) idDeyWeek = newDataReader[0].ToString();
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                // Создание новой команды SQL для получения ID времени тренировки.
                newCommand.CommandText = "SELECT idTimeTraining FROM timetraining WHERE time = '" + timeTraining + "'";
                newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в idTimeTraining.
                while (newDataReader.Read()) idTimeTraining = newDataReader[0].ToString();
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                // Создание новой команды SQL для получения ID типа тренировки.
                newCommand.CommandText = "SELECT idTypeTraining FROM typetraining WHERE type = '" + typeTraining + "'";
                newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в idTypeTraining.
                while (newDataReader.Read()) idTypeTraining = newDataReader[0].ToString();
                newDataReader.Close(); // Закрытие читателя данных newDataReader.
                // Создание новой команды SQL для получения ID тренера.
                newCommand.CommandText = "SELECT idCoach FROM coaches WHERE fullNameCoach = '" + coach + "'";
                newDataReader = newCommand.ExecuteReader();
                // Чтение полученых данных с помощью newCommand, и занесение их в idCoach.
                while (newDataReader.Read()) idCoach = newDataReader[0].ToString();
                newDataReader.Close(); // Закрытие читателя данных newDataReader.

                // Создание новой команды SQL для записи новой тренировки.
                newCommand.CommandText = 
                            "INSERT INTO schedule (" +
                                "idTimeTraining, idDeyWeek, " +
                                "idTypeTraining, idChild, idCoach) " +
                            "VALUES ('" +
                                idTimeTraining + "'," +
                                idDeyWeek + ",'" +
                                idTypeTraining + "','" +
                                idChild + "','" +
                                idCoach + "')";
                // Выполняет оператор MySQL применительно к объекту Connection. 'Выполнение MySQL команды'.
                newCommand.ExecuteNonQuery();
                // Чтение ID последней добавленной записи и присвоение в переменную id.
                newCommand.CommandText = "SELECT @@identity";
                string id = newCommand.ExecuteScalar().ToString();
                new History(25, null, idChild, id, null, null); // Запись действия в историю.
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод RecordOnTraining()"); newConnection.Close();
            }
            // Обнуление данных в элементах формы.
            comboBoxDeyWeek.SelectedIndex = -1;
            comboBoxTimeTraining.SelectedIndex = -1;
            comboBoxTypeTraining.SelectedIndex = -1;
            comboBoxCoach.SelectedIndex = -1;
            groupBoxNewTraining.Enabled = false;
            buttonNewTraining.Enabled = true;
            // Вывод сообщения о проведенной операции.
            MessageBox.Show($"Ребенок {fullNameChild} записан на треннировку к тренеру {coach}");
            UpdateDGVTrainings(); // Выполнение метеда UpdateDGVTrainings().
        }

        private void UpdateDGVTrainings() // Метод обновления и загрузки данных в визуальную таблицу с тренировками.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL вывода данных о тренировках ребенка.
                newDataTable.Load(new MySqlCommand(
                    "SELECT " + string.Join(",", headersSchedule.ToArray()) + " " +
                    "FROM (((schedule LEFT JOIN coaches USING (idCoach)) " +
                    "LEFT JOIN timetraining USING (idTimeTraining)) " +
                    "LEFT JOIN deysweek USING (idDeyWeek)) " +
                    "LEFT JOIN typetraining USING (idTypeTraining) " +
                    "WHERE idChild = " + idChild + " " +
                    "ORDER BY deysweek.idDeyWeek, timetraining.time", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridView.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод UpdateDGVTrainings()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            List<string> headersScheduleWords = new List<string>() { "", "", "", "", "" };
            for (int i = 0; i < headersSchedule.Count; i++)
            {
                headersScheduleWords[i] = headersSchedule[i].Substring(headersSchedule[i].IndexOf('.') + 1);
                dataGridView.Columns[i].HeaderText = TranslateHeading.Translate(headersScheduleWords[i]);
            }
            // Установка ширины колонок талицы.
            dataGridView.Columns[0].Width = 22;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 160;
            dataGridView.Columns[3].Width = 200;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Изменение внешнего вида и доступа объектов интерфейса.
            groupBoxTrainings.Enabled = dataGridView.Rows.Count > 0;
        }
        // Действия при нажатии кнопки 'Удалить тренировку'.
        private void buttonDeleteTraining_Click(object sender, EventArgs e)
        {
            // Вызавает сообщение с подтверждением об удалении тренировки.
            if (MessageBox.Show( "Вы действительно хотите удалить данную тренировку?", "Удаление записи", 
                MessageBoxButtons.YesNo) == DialogResult.Yes) // Если в сообщении нажата кнопка - Да...
            {
                string idSchedule = "", deyWeek = "", time = "", type = "";
                // Возврощает ID тренировки, выбранной записи и сохраняет в idSchedule.
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    idSchedule = row.Cells[0].Value.ToString();
                    deyWeek = row.Cells[1].Value.ToString();
                    time = row.Cells[2].Value.ToString();
                    type = row.Cells[3].Value.ToString();
                }
                    
                try // Проверка ошибок.
                {
                    newConnection.Open(); // Открытие соединения с базой данных.
                    // Создание новой команды SQL для удаления тренировки из базы данных.
                    new MySqlCommand("DELETE FROM schedule WHERE idSchedule = " + 
                        idSchedule, newConnection).ExecuteNonQuery();
                    new History(26, null, idChild, null, null, 
                        deyWeek + " " + time + " " + type); // Запись действия в историю.
                    newConnection.Close(); // Закрытие соединения с базой данных.
                }
                catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
                { MessageBox.Show(ex.Message, "Ошибка! Метод buttonDeleteTraining_Click()"); newConnection.Close(); }
                UpdateDGVTrainings(); // Выполнение метода UpdateDGVTrainings().
            }
        }
        // Изменение цвета текста, перед полями которые обязательно должы быть заполнены, на исходный.
        private void comboBoxDeyWeek_Click(object sender, EventArgs e) => labelDeyWeek.ForeColor = Color.Black;
        private void comboBoxTimeTraining_Click(object sender, EventArgs e) => labelTimeTraining.ForeColor = Color.Black;
        private void comboBoxCoach_Click(object sender, EventArgs e) => labelCoach.ForeColor = Color.Black;
        private void comboBoxTypeTraining_Click(object sender, EventArgs e) => labelTypeTraining.ForeColor = Color.Black;
    }
}
