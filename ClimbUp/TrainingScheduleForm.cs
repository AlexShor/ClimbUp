using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class TrainingScheduleForm : Form
    {
        // Создание массива визуальных таблиц.
        private DataGridView[,] dataGridView = new DataGridView[7, 7];
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());
        public TrainingScheduleForm()
        {
            InitializeComponent();
            new History(36, null, null, null, null, null); // Запись действия в историю.
            FillingTable(); // Выполнение метода FillingTable().
            LoadData(); // Выполнение метода LoadData().
        }
        
        private void FillingTable() // Метод заполнения формы визуальными таблицами.
        {
            // Названия дней недели в левый хедер стола.
            label1.Text = "П\nо\nн\nе\nд\nе\nл\nь\nн\nи\nк";
            label2.Text = "В\nт\nо\nр\nн\nи\nк";
            label3.Text = "С\nр\nе\nд\nа";
            label4.Text = "Ч\nе\nт\nв\nе\nр\nг";
            label5.Text = "П\nя\nт\nн\nи\nц\nа";
            label6.Text = "С\nу\nб\nб\nо\nт\nа";
            label7.Text = "В\nо\nс\nк\nр\nе\nс\nе\nн\nи\nе";
            // Времена тренировок в верхний хедер.
            labelT1.Text = "09:00 - 10:30";
            labelT2.Text = "10:30 - 12:00";
            labelT3.Text = "12:00 - 13:30";
            labelT4.Text = "13:30 - 15:00";
            labelT5.Text = "15:00 - 17:30";
            labelT6.Text = "17:30 - 19:00";
            labelT7.Text = "19:00 - 20:30";
            
            for (int i = 0; i < 7; i++) // Создание двумерного массива для визуальных таблиц.
            {
                for (int j = 0; j < 7; j++)
                {
                    // Создание визуальной таблицы и назначение ей необходимых свойств.
                    dataGridView[i, j] = new DataGridView();
                    ((ISupportInitialize)(dataGridView[i, j])).BeginInit();
                    tableLayoutPanel.Controls.Add(dataGridView[i, j], i + 1, j + 1);
                    dataGridView[i, j].ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dataGridView[i, j].Dock = DockStyle.Fill;
                    dataGridView[i, j].AllowUserToAddRows = false;
                    dataGridView[i, j].AllowUserToDeleteRows = false;
                    dataGridView[i, j].AllowUserToOrderColumns = false;
                    dataGridView[i, j].AllowUserToResizeRows = false;
                    dataGridView[i, j].AllowUserToResizeColumns = false;
                    dataGridView[i, j].MultiSelect = false;
                    dataGridView[i, j].ReadOnly = true;
                    dataGridView[i, j].RowHeadersWidth = 5;
                    dataGridView[i, j].RowTemplate.Height = 18;
                    dataGridView[i, j].SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView[i, j].RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dataGridView[i, j].RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
                    dataGridView[i, j].RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView[i, j].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8F);
                    dataGridView[i, j].CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
                    dataGridView[i, j].CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormatting);
                }
            }
        }

        private void LoadData() // Метод загрузки данных из базы данных в массив визуальных таблиц.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        DataTable newDataTable = new DataTable(); // Создание объекта таблицы.
                        // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                        // Создание новой команды SQL для получения данных тренировок для клиента или ребенка.
                        newDataTable.Load(new MySqlCommand(
                            "SELECT NULL, IFNULL(clients.idClient, children.idChild), " +
                            "IFNULL(clients.fullNameClient, children.fullNameChild), coaches.fullNameCoach " +
                            "FROM (((((schedule LEFT JOIN coaches USING (idCoach)) " +
                            "LEFT JOIN timetraining USING (idTimeTraining)) " +
                            "LEFT JOIN deysweek USING (idDeyWeek)) " +
                            "LEFT JOIN typetraining USING (idTypeTraining)) " +
                            "LEFT JOIN clients USING (idClient)) " +
                            "LEFT JOIN children USING (idChild)" +
                            "WHERE timetraining.idTimeTraining = " + Convert.ToString(i + 1) + " " +
                            "AND deysweek.idDeyWeek = " + Convert.ToString(j + 1) + " " +
                            "ORDER BY clients.fullNameClient, children.fullNameChild", newConnection).ExecuteReader());
                        // Заполнение масива визуальных таблиц в форме.
                        dataGridView[i, j].DataSource = newDataTable;
                        dataGridView[i, j].Columns[0].HeaderText = "№";
                        dataGridView[i, j].Columns[1].HeaderText = "ID";
                        dataGridView[i, j].Columns[2].HeaderText = "ФИО";
                        dataGridView[i, j].Columns[3].HeaderText = "Тренер";
                        // Сокращение имени тренера.
                        for (int t = 0; t < dataGridView[i, j].RowCount; t++)
                            dataGridView[i, j][3, t].Value = 
                                Convert.ToString(dataGridView[i, j][3, t].Value).Remove(
                                    Convert.ToString(dataGridView[i, j][3, t].Value).IndexOf(" "));
                    }
                }
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadData()"); newConnection.Close(); }
        }

        private void GridSetting() // Метед настойки массива визуальных таблиц.
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    // Указание ширины столбцов.
                    dataGridView[i, j].Columns[0].Width = 22;
                    dataGridView[i, j].Columns[1].Width = 22;
                    dataGridView[i, j].Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView[i, j].Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    // Указание ширины таблицы.
                    dataGridView[i, j].Width =
                        dataGridView[i, j].Columns[0].Width +
                        dataGridView[i, j].Columns[1].Width +
                        dataGridView[i, j].Columns[2].Width +
                        dataGridView[i, j].Columns[3].Width + 8;
                    // Указание высоты таблицы
                    if (dataGridView[i, j].RowCount > 0)
                        dataGridView[i, j].Height = dataGridView[i, j].Rows.Count * dataGridView[i, j].Rows[0].Height + 25;
                    else dataGridView[i, j].ColumnHeadersVisible = false;

                    dataGridView[i, j].Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    // Отключение возможности сортировки данных в таблице.
                    for (int t = 0; t < dataGridView[i, j].ColumnCount; t++)
                        dataGridView[i, j].Columns[t].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }
        // Происходит при загрузке формы.
        private void TrainingScheduleForm_Load(object sender, EventArgs e) => 
            GridSetting(); // Вызывает метод GridSetting().
        // Происходит при двойном клике по данным в таблице. Открывает данные о клиенте или ребенке.
        private void dataGridView_CellDoubleClick(object sender, EventArgs e)
        {
            string id = "";
            string name = "";
            var current = sender as DataGridView; // Определяет в какой таблице произошло событие.
            // Возврощает ID и имя клиента (ребенка) выбранной записи.
            foreach (DataGridViewRow row in current.SelectedRows)
            { id = row.Cells[1].Value.ToString(); name = row.Cells[2].Value.ToString(); }

            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для определения записи в таблице. Клиент или ребенок.
                // Создание нового читателя данных newDataReader.
                MySqlDataReader newDataReader = new MySqlCommand(
                            "SELECT IF(idClient = " + id + " AND fullNameClient = '" + name + 
                            "','Client','Child') FROM clients ", newConnection).ExecuteReader();
                string table = "";
                // Чтение полученых данных с помощью newCommand,
                // и сохранение их во временных переменных.
                while (newDataReader.Read()) table = newDataReader[0].ToString();
                newDataReader.Close(); // Закрытие читателя данных newDataReader.

                if (table == "Client") // Если выбранные данные - Клиент, открыть окно InfoClientForm.
                {
                    InfoClientForm newMDIChild = new InfoClientForm(id);
                    newMDIChild.MdiParent = this.MdiParent;
                    newMDIChild.Show();
                }
                else if (table == "Child") // Если выбранные данные - Ребенок, открыть окно InfoChildForm.
                {
                    InfoChildForm newMDIChild = new InfoChildForm(id);
                    newMDIChild.MdiParent = this.MdiParent;
                    newMDIChild.Show();
                }
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод dataGridView_CellDoubleClick()"); newConnection.Close(); }
        }
        // Метод добавления в таблизу колонки с нумерацией клиентов (детей).
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { if (e.ColumnIndex == 0) e.Value = e.RowIndex + 1;}
        // Действия при нажании кнопки 'Обновить'.
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData(); // Выполнение метода LoadData().
            GridSetting(); // Выполнение метода GridSetting().
        }
    }
}
