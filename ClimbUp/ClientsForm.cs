using System;
using System.Collections.Generic;
// SD - Псевдоним для пространства имён System.Data. Класс DataTable, присутствует 
// как в пространстве имён Microsoft.Office.Interop.Excel так и в пространстве 
// имён System.Data, в результате чего возникает конфликт имён.
using SD = System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.
using Excel = Microsoft.Office.Interop.Excel; // Пространство имен для работы с Excel.

namespace ClimbUp
{
    public partial class ClientsForm : Form
    {
        // Переменные для временного хранения ID клиента и ребенка.
        private string idClient = "", idChild = "";
        // Переменная для хранения дополнительной части SQL запроса.
        //private static string sqlQueryForWhere = "";
        // Массивы для хранения заголовков столбцов.
        private List<string> headersClient = new List<string>()
        { "idClient","fullNameClient","sexClient","phoneNumberClient",
          "eMailClient","sportCategoryClient","commentsClient" };
        private List<string> headersChild = new List<string>()
        { "idChild","fullNameChild","ageChild","sexChild", "sportCategoryChild","commentsChild" };
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString());

        public ClientsForm()
        {
            InitializeComponent();
            new History(38, null, null, null, null, null); // Запись действия в историю.
            // присвоение изночального текста в comboBox'ы для поиска.
            comboBoxClientSearchBy.Text = "ФИО";
            comboBoxClientSearchBySC.Text = "Всё";
            comboBoxClientSearchBySex.Text = "Всё";
            comboBoxChildSearchBySC.Text = "Всё";
            comboBoxChildSearchBySex.Text = "Всё";
        }
        // Действия при загрузке формы.
        private void ClientsForm_Load(object sender, EventArgs e) => 
            LoadDataMeinDGV(""); // Выполнение матода LoadDataMeinDGV('Доп. часть SQL запроса').
        // Метод загрузки данных о клиентах, из базы данных, в визуальную таблицу в форме.
        // Принимает строку с дополнительной частью SQL запроса.
        private void LoadDataMeinDGV(string ExtraSqlQuery)
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                SD.DataTable newDataTable = new SD.DataTable(); // Создание объекта таблицы.
                // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                // Создание новой команды SQL для получения данных клиентов.
                newDataTable.Load(new MySqlCommand(
                    "SELECT " + string.Join(",", headersClient.ToArray()) + " FROM clients " + 
                    ExtraSqlQuery + " ORDER BY clients.fullNameClient", newConnection).ExecuteReader());
                newConnection.Close(); // Закрытие соединения с базой данных.
                dataGridViewMain.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadDataMeinDGV()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            for (int i = 0; i < headersClient.Count; i++)
                dataGridViewMain.Columns[i].HeaderText = TranslateHeading.Translate(headersClient[i]);
            // Установка ширины колонок талицы.
            dataGridViewMain.Columns[0].Width = 22;
            dataGridViewMain.Columns[1].Width = 300;
            dataGridViewMain.Columns[2].Width = 60;
            dataGridViewMain.Columns[3].Width = 120;
            dataGridViewMain.Columns[4].Width = 200;
            dataGridViewMain.Columns[5].Width = 140;
            dataGridViewMain.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMain.Columns[6].MinimumWidth = 200;
        }
        // Действия при нажатии кнопки 'Поиск/Обновить' в области 'Критерии поиска клиента'.
        private void buttonClientSearch_Click(object sender, EventArgs e)
        {
            string sqlQueryForWhere = "";
            // Формирование дополнительной части SQL запроса,
            // исходя из выбранных(введенных) кртериев поиска по клиентам.
            if (comboBoxClientSearchBy.Text == "ФИО")
                sqlQueryForWhere = " WHERE fullNameClient LIKE '%" + textBoxClientSearchText.Text + "%' ";
            if (comboBoxClientSearchBy.Text == "Номер телефона")
                sqlQueryForWhere = " WHERE phoneNumberClient LIKE '%" + textBoxClientSearchText.Text + "%' ";
            if (comboBoxClientSearchBy.Text == "E-Mail")
                sqlQueryForWhere = " WHERE eMailClient LIKE '%" + textBoxClientSearchText.Text + "%' ";

            if (comboBoxClientSearchBySC.Text == "Нет")
                sqlQueryForWhere += "AND sportCategoryClient = '' ";
            if (comboBoxClientSearchBySC.Text == "Есть")
                sqlQueryForWhere += "AND sportCategoryClient != '' ";
            if (comboBoxClientSearchBySC.Text != "Всё" && 
                comboBoxClientSearchBySC.Text != "Нет" && 
                comboBoxClientSearchBySC.Text != "Есть")
                sqlQueryForWhere += "AND sportCategoryClient = '" + comboBoxClientSearchBySC.Text + "' ";

            if (comboBoxClientSearchBySex.Text == "Мужской")
                sqlQueryForWhere += "AND sexClient = '" + comboBoxClientSearchBySex.Text + "' ";
            if (comboBoxClientSearchBySex.Text == "Женский")
                sqlQueryForWhere += "AND sexClient = '" + comboBoxClientSearchBySex.Text + "' ";
            LoadDataMeinDGV(sqlQueryForWhere); // Выполнение матода LoadDataMeinDGV('Доп. часть SQL запроса').
            new History(8, null, null, null, null, null); // Запись действия в историю.
        }
        // Действия при нажатии кнопки 'Поиск/Обновить' в области 'Критерии поиска ребенка'.
        private void ButtonChildSearch_Click(object sender, EventArgs e)
        {
            string sqlQueryForWhere = "";
            // Формирование дополнительной части SQL запроса,
            // исходя из выбранных(введенных) кртериев поиска по детям.
            if (textBoxChildSearchText.Text != "")
                sqlQueryForWhere = "WHERE fullNameChild LIKE '%" + textBoxChildSearchText.Text + "%' ";
            else sqlQueryForWhere += "WHERE fullNameChild != '' ";

            if (textBoxChildAgeSearch.Text != "")
            {
                if (textBoxChildAgeSearch.Text.Contains("-"))
                {
                    string[] ageRange = textBoxChildAgeSearch.Text.Split(new char[] { '-' });
                    sqlQueryForWhere += "AND (ageChild BETWEEN " + ageRange[0] + " AND " + ageRange[1] + ") ";
                }
                else sqlQueryForWhere += "AND ageChild = " + textBoxChildAgeSearch.Text + " ";
            }

            if (comboBoxChildSearchBySC.Text == "Нет")
                sqlQueryForWhere += "AND sportCategoryChild = '' ";
            if (comboBoxChildSearchBySC.Text == "Есть")
                sqlQueryForWhere += "AND sportCategoryChild != '' ";
            if (comboBoxChildSearchBySC.Text != "Всё" &&
                comboBoxChildSearchBySC.Text != "Нет" &&
                comboBoxChildSearchBySC.Text != "Есть")
                sqlQueryForWhere += "AND sportCategoryChild = '" + comboBoxChildSearchBySC.Text + "' ";

            if (comboBoxChildSearchBySex.Text == "Мужской")
                sqlQueryForWhere += "AND sexChild = '" + comboBoxChildSearchBySex.Text + "' ";
            if (comboBoxChildSearchBySex.Text == "Женский")
                sqlQueryForWhere += "AND sexChild = '" + comboBoxChildSearchBySex.Text + "' ";
            LoadDataSecondaryDGV("", sqlQueryForWhere); // Выполнение матода LoadDataSecondaryDGV('Доп. часть SQL запроса').
            new History(9, null, null, null, null, null); // Запись действия в историю.
        }
        // Метод загрузки данных о детях, из базы данных, в визуальную таблицу в форме.
        // Принимает строку с ID клиента или доп. часть SQL запроса для поиска ребенка.
        private void LoadDataSecondaryDGV(string idClient, string ExtraSqlQuery)
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                if (idClient != "")
                {
                    SD.DataTable newDataTable = new SD.DataTable(); // Создание объекта таблицы.
                    // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                    // Создание новой команды SQL для получения данных детей привязанных к клиенту по ID.
                    newDataTable.Load(new MySqlCommand(
                        "SELECT " + string.Join(", ", headersChild.ToArray()) + " " +
                        "FROM clients_has_children LEFT JOIN children USING (idChild) " +
                        "WHERE clients_has_children.idClient = " + idClient + " " +
                        "ORDER BY children.fullNameChild", newConnection).ExecuteReader());
                    dataGridViewSecondary.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
                }
                else
                {
                    SD.DataTable newDataTable = new SD.DataTable(); // Создание объекта таблицы.
                    // Загрузка в объект таблицы, полученых данных из MySqlCommand.
                    // Создание новой команды SQL для получения данных детей.
                    newDataTable.Load(new MySqlCommand(
                        "SELECT " + string.Join(",", headersChild.ToArray()) + " FROM children " +
                        ExtraSqlQuery + " ORDER BY children.fullNameChild", newConnection).ExecuteReader());
                    dataGridViewSecondary.DataSource = newDataTable; // Заполнение визуальной таблицы в форме
                }
                newConnection.Close(); // Закрытие соединения с базой данных.
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод LoadDataSecondaryDGV()"); newConnection.Close(); }
            // Осуществляет перевод названий колонок из базы данных на русский, через созданный класс TranslateHeading.
            for (int i = 0; i < headersChild.Count; i++)
                dataGridViewSecondary.Columns[i].HeaderText = TranslateHeading.Translate(headersChild[i]);
            // Установка ширины колонок талицы.
            dataGridViewSecondary.Columns[0].Width = 22;
            dataGridViewSecondary.Columns[1].Width = 300;
            dataGridViewSecondary.Columns[2].Width = 60;
            dataGridViewSecondary.Columns[3].Width = 60;
            dataGridViewSecondary.Columns[4].Width = 140;
            dataGridViewSecondary.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSecondary.Columns[5].MinimumWidth = 200;
        }
        // Происходит после завершения операции привязки данных к визуальной таблицы в форме
        private void dataGridViewMain_DataBindingComplete( 
            object sender, DataGridViewBindingCompleteEventArgs e) => 
            dataGridViewMain.Rows[0].Selected = false; // Снимает выделение с автоматически выделеной строки.
        // Действия при выборе данных в визуальной таблице с клиентами.
        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Возврощает ID клиента, выбранной записи и вызавает метод LoadDataSecondaryDGV,
            // с передачей этого ID.
            foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
                LoadDataSecondaryDGV(row.Cells[0].Value.ToString(),"");
        }
        // Действия при нажатии кнопки 'Запись на тренировку' таблицы с клиентами.
        private void buttonRecordOnTrainingClient_Click(object sender, EventArgs e)
        {
            // Возврощает ID, выбранной записи и сохраняет в переменную idClient.
            foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
                idClient = row.Cells[0].Value.ToString();
            // Если переменная idClient не пустая - открывает дочернее окно RecordClientOnTrainingForm,
            // и передает idClient.
            if (idClient != "") 
            {
                RecordClientOnTrainingForm newMDIChild = new RecordClientOnTrainingForm(idClient);
                newMDIChild.MdiParent = this.MdiParent;
                newMDIChild.Show();
            }
        }
        // Действия при нажатии кнопки 'Запись на тренировку' таблицы с детьми.
        private void buttonRecordOnTrainingChild_Click(object sender, EventArgs e)
        {
            // Возврощает ID, выбранной записи и сохраняет в переменную idChild.
            foreach (DataGridViewRow row in dataGridViewSecondary.SelectedRows)
                idChild = row.Cells[0].Value.ToString();
            // Если переменная idChild не пустая - открывает дочернее окно RecordChildOnTrainingForm,
            // и передает idChild.
            if (idChild != "")
            {
                RecordChildOnTrainingForm newMDIChild = new RecordChildOnTrainingForm(idChild);
                newMDIChild.MdiParent = this.MdiParent;
                newMDIChild.Show();
            }
        }
        // Действия при нажатии кнопки 'Изменить данные клиента'.
        private void buttonChangeClientInfo_Click(object sender, EventArgs e)
        {
            // Возврощает ID, выбранной записи и сохраняет в переменную idClient.
            foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
                idClient = row.Cells[0].Value.ToString();
            // Если переменная idClient не пустая - открывает дочернее окно ChangeInfoClientForm,
            // и передает idClient.
            if (idClient != "")
            {
                ChangeInfoClientForm newMDIChild = new ChangeInfoClientForm(idClient);
                newMDIChild.MdiParent = this.MdiParent;
                newMDIChild.Show();
            }
        }
        // Действия при нажатии кнопки 'Изменить данные ребенка'.
        private void buttonChangeChildInfo_Click(object sender, EventArgs e)
        {
            // Возврощает ID, выбранной записи и сохраняет в переменную idChild.
            foreach (DataGridViewRow row in dataGridViewSecondary.SelectedRows)
                idChild = row.Cells[0].Value.ToString();
            // Если переменная idChild не пустая - открывает дочернее окно ChangeInfoChildForm,
            // и передает idChild.
            if (idChild != "")
            {
                ChangeInfoChildForm newMDIChild = new ChangeInfoChildForm(idChild);
                newMDIChild.MdiParent = this.MdiParent;
                newMDIChild.Show();
            }
        }
        // Действия при двойном клике по записи в таблице с клиентами.
        private void dataGridViewMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Возврощает ID, выбранной записи и сохраняет в переменную idClient.
            foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
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
        // Действия при двойном клике по записи в таблице с детьми.
        private void dataGridViewSecondary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Возврощает ID, выбранной записи и сохраняет в переменную idChild.
            foreach (DataGridViewRow row in dataGridViewSecondary.SelectedRows)
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
        // Действия при нажатии кнопки 'Экспорт в Excel' в области 'Клиенты'.
        private void buttonExportToExcelClients_Click(object sender, EventArgs e)
        {
            ExportToExcel(1); // Выполнение матода ExportToExcel(1). (1 - считывать таблицу клиентов).
            new History(16, null, null, null, null, null); // Запись действия в историю.
        }
        // Действия при нажатии кнопки 'Экспорт в Excel' в области 'Дети'.
        private void ButtonExportToExcelChildren_Click(object sender, EventArgs e)
        {
            ExportToExcel(2); // Выполнение матода ExportToExcel(2). (2 - считывать таблицу детей).
            new History(17, null, null, null, null, null); // Запись действия в историю.
        }

        private void ExportToExcel(int identifier) // Метод экспорта данных в Excel.
        {
            var exApp = new Excel.Application(); // Создание нового объекта.
            var workSheet = (Excel.Worksheet)exApp.ActiveSheet; // Получить активный лист Excel.
            int rowExcel = 2; // Начать со второй строки.
            switch (identifier) // Из какой таблицы считывать данные: 1 - клиенты, 2 - дети.
            {
                case 1:

                    for (int i = 0; i < headersClient.Count; i++) // В первой строке листа поместить названия колонок.
                        workSheet.Cells[1, i + 1] = TranslateHeading.Translate(headersClient[i]);
                    // Экспорт данных из DataGridView в Excel файл.
                    for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
                    {
                        for (int j = 0; j < headersClient.Count; j++)
                            workSheet.Cells[rowExcel, j + 1] = 
                                dataGridViewMain.Rows[i].Cells[headersClient[j]].Value;
                        ++rowExcel;
                    }
                    break;
                case 2:
                    for (int i = 0; i < headersChild.Count; i++) // В первой строке листа поместить названия колонок.
                        workSheet.Cells[1, i + 1] = TranslateHeading.Translate(headersChild[i]);
                    // Экспорт данных из DataGridView в Excel файл.
                    for (int i = 0; i < dataGridViewSecondary.Rows.Count; i++)
                    {
                        for (int j = 0; j < headersChild.Count; j++)
                            workSheet.Cells[rowExcel, j + 1] = 
                                dataGridViewSecondary.Rows[i].Cells[headersChild[j]].Value;
                        ++rowExcel;
                    }
                    break;
            }
            exApp.Visible = true; // Отобразить таблицу Excel.
            exApp.Quit(); // Завершить работу с Excel.
        }
    }
}
