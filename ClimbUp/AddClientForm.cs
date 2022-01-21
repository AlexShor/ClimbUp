using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Пространстно имен для работы с MySQL.

namespace ClimbUp
{
    public partial class AddClientForm : Form
    {
        private int lastIdClient; // ID последнего добавленного клиента.
        private int lastIdChild; // ID последнего добавленного ребенка.
        private int amountChildren; // Счетчик количества добовляемых детей.
        // Создание подключения к базе данных MySQL.
        private MySqlConnection newConnection = new MySqlConnection(DataBank.GetConnectionString()); 
        public AddClientForm()
        {
            InitializeComponent();
            new History(40, null, null, null, null, null); // Запись действия в историю.
        }

        private void addClients() // Метод записи нового клиента в базу данных.
        {
            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для записи данных нового клиента.
                MySqlCommand newCommand = new MySqlCommand(
                            "INSERT INTO clients (" +
                                "fullNameClient, phoneNumberClient, eMailClient, " +
                                "sportCategoryClient, sexClient, commentsClient) " +
                            "VALUES ('" +
                                textBoxClientFullName.Text + "'," +
                                textBoxClientPhoneNumber.Text + ",'" +
                                textBoxClientEMail.Text + "','" +
                                comboBoxClientSportCatigory.Text + "','" +
                                comboBoxClientSex.Text + "','" +
                                textBoxClientComment.Text + "')", newConnection);
                // Выполняет оператор MySQL применительно к объекту Connection. 'Выполнение MySQL команды'.
                newCommand.ExecuteNonQuery(); 
                // Чтение ID последней добавленной записи и присвоение в переменную lastIdClient.
                newCommand.CommandText = "SELECT @@identity";
                lastIdClient = int.Parse(newCommand.ExecuteScalar().ToString());
                new History(2, lastIdClient.ToString(), null, null, null, null); // Запись действия в историю.
                newConnection.Close(); // Закрытие соединения с базой данных.
                // Вывод сообщения с ФИО добавленного клиента.
                MessageBox.Show($"Клиент {textBoxClientFullName.Text} добавлен!"); 
                // изменение внешнего вида и доступа объектов интерфейса.
                textBoxClientFullName.Enabled = false;
                textBoxClientPhoneNumber.Enabled = false;
                textBoxClientEMail.Enabled = false;
                textBoxClientComment.Enabled = false;
                comboBoxClientSex.Enabled = false;
                comboBoxClientSportCatigory.Enabled = false;
                comboBoxClientSportCatigory.Enabled = false;
                buttonAddClient.Enabled = false;
                groupBoxQuestionChildren.Visible = true;
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод addClients()"); newConnection.Close(); }
        }

        private void addChild() // Метод записи нового ребенка в базу данных.
        {
            // Изменение текста в groupBoxChild в зависимости от очередности добовляемого ребенка.
            int ChildNumber = 1;
            if (amountChildren > 1)
                ChildNumber = Convert.ToInt32(groupBoxChild.Text.Substring(groupBoxChild.Text.Length - 1));

            try // Проверка ошибок.
            {
                newConnection.Open(); // Открытие соединения с базой данных.
                // Создание новой команды SQL для записи данных нового ребенка.
                MySqlCommand newCommand = new MySqlCommand(
                            "INSERT INTO children (" +
                                "fullNameChild, ageChild, sexChild, " +
                                "sportCategoryChild, commentsChild) " +
                            "VALUES ('" +
                                textBoxChildFullName.Text + "'," +
                                Convert.ToInt32(textBoxChildAge.Text) + ",'" +
                                comboBoxChildSex.Text + "','" +
                                comboBoxChildSportCatigory.Text + "','" +
                                textBoxChildComment.Text + "')", newConnection);
                // Выполняет оператор MySQL применительно к объекту Connection 'Выполнение MySQL команды'.
                newCommand.ExecuteNonQuery();
                // Чтение ID последней добавленной записи и присвоение в переменную lastIdChild.
                newCommand.CommandText = "SELECT @@identity";
                lastIdChild = int.Parse(newCommand.ExecuteScalar().ToString());
                new History(3, null, lastIdChild.ToString(), null, null, null); // Запись действия в историю.
                // Создание новой команды SQL для записи ID клиента и ребенка в таблицу clients_has_children 
                // для поддержания связи - многие ко многим.
                newCommand.CommandText = 
                            "INSERT INTO clients_has_children (idClient, idChild) " +
                            "VALUES ('" + Convert.ToString(lastIdClient) + "','" +
                            Convert.ToString(lastIdChild) + "')";
                // Выполняет оператор MySQL применительно к объекту Connection 'Выполнение MySQL команды'
                newCommand.ExecuteNonQuery();

                newConnection.Close(); // Закрытие соединения с базой данных.
                // Вывод сообщения с ФИО добавленного ребенка.
                MessageBox.Show($"Ребенок {textBoxChildFullName.Text} добавлен!");
                // Если был добавлен последний в очереди ребенок - изменение внешнего вида и доступа объектов интерфейса,
                // иначе - очистка объектов интерфейса для занесения новых записей.
                if (ChildNumber == amountChildren) 
                {
                    textBoxChildFullName.Enabled = false;
                    textBoxChildAge.Enabled = false;
                    textBoxChildComment.Enabled = false;
                    comboBoxChildSex.Enabled = false;
                    comboBoxChildSportCatigory.Enabled = false;
                    comboBoxChildSportCatigory.Enabled = false;
                    buttonAddChild.Enabled = false;
                }
                else if (amountChildren > 1)
                {
                    groupBoxChild.Text = groupBoxChild.Text.Remove(
                        groupBoxChild.Text.Length - 1, 1) + Convert.ToString(ChildNumber + 1);
                    textBoxChildFullName.Text = "";
                    textBoxChildAge.Text = "";
                    comboBoxChildSportCatigory.Text = "";
                    comboBoxChildSex.Text = "";
                    textBoxChildComment.Text = "";
                }
            }
            catch (Exception ex) // При возникновении ошибок выводит сообщение и закрывает соединение с базой данных.
            { MessageBox.Show(ex.Message, "Ошибка! Метод addChild()"); newConnection.Close(); }
        }
        // Действия при нажании кнопки 'Добавить'
        private void buttonAddChild_Click(object sender, EventArgs e)
        {
            bool checkFilled = true;
            if (textBoxChildFullName.Text == "")
            { checkFilled = false; labelChildFullName.ForeColor = Color.Tomato; }
            if (textBoxChildAge.Text == "")
            { checkFilled = false; labelChildAge.ForeColor = Color.Tomato; }
            if (comboBoxChildSex.Text == "")
            { checkFilled = false; labelChildSex.ForeColor = Color.Tomato; }

            if (checkFilled) addChild(); // Если необходимые поля были заполнены выполнить метод addChild().
        }
        // Действия при установки фложка 'Добавить ребенка?'.
        private void checkBoxAddChild_CheckedChanged(object sender, EventArgs e) => 
            groupBoxAmountChildren.Visible = checkBoxAddChild.Checked == true;
        // Действия при нажании кнопки 'Добавить клиента', 
        // изменение цвета текста перед полями, которые обязательно, должы быть заполнены.
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            bool checkFilled = true;
            if (textBoxClientFullName.Text == "")
            { checkFilled = false; labelClientFullName.ForeColor = Color.Tomato; }
            if (textBoxClientPhoneNumber.Text == "")
            { checkFilled = false; labelClientPhoneNumber.ForeColor = Color.Tomato; }
            if (comboBoxClientSex.Text == "")
            { checkFilled = false; labelClientSex.ForeColor = Color.Tomato; }

            if (checkFilled) addClients(); // Если необходимые поля были заполнены выполнить метод addClients().
        }
        // Действия при нажании кнопки 'Добавить'.
        private void buttonAddChildren_Click(object sender, EventArgs e)
        {
            amountChildren = Convert.ToInt32(comboBoxAmountChildren.Text);
            groupBoxChild.Visible = true;
            if (amountChildren > 1) groupBoxChild.Text += " 1";
            checkBoxAddChild.Enabled = false;
            comboBoxAmountChildren.Enabled = false;
            buttonAddChildren.Enabled = false;
        }
        // Действия при нажании кнопки 'Новый клиент'.
        private void buttonNewClient_Click(object sender, EventArgs e) => 
            ClearAll(); // Выполнение метода ClearAll().
        // Метод преводящий все объекты интерфейса в исходное состояние, для добовления нового клиента.
        private void ClearAll()
        {
            textBoxClientFullName.Text = "";
            textBoxClientPhoneNumber.Text = "";
            textBoxClientEMail.Text = "";
            comboBoxClientSportCatigory.Text = "";
            comboBoxClientSex.Text = "";
            textBoxClientComment.Text = "";
            checkBoxAddChild.Checked = false;
            comboBoxAmountChildren.Text = "1";
            textBoxChildFullName.Text = "";
            textBoxChildAge.Text = "";
            comboBoxChildSportCatigory.Text = "";
            comboBoxChildSex.Text = "";
            textBoxChildComment.Text = "";

            textBoxClientFullName.Enabled = true;
            textBoxClientPhoneNumber.Enabled = true;
            textBoxClientEMail.Enabled = true;
            comboBoxClientSportCatigory.Enabled = true;
            comboBoxClientSex.Enabled = true;
            textBoxClientComment.Enabled = true;
            checkBoxAddChild.Enabled = true;
            comboBoxAmountChildren.Enabled = true;
            textBoxChildFullName.Enabled = true;
            textBoxChildAge.Enabled = true;
            comboBoxChildSportCatigory.Enabled = true;
            comboBoxChildSex.Enabled = true;
            textBoxChildComment.Enabled = true;
            buttonAddChild.Enabled = true;
            buttonAddChildren.Enabled = true;
            buttonAddClient.Enabled = true;

            labelClientFullName.ForeColor = Color.Black;
            labelClientPhoneNumber.ForeColor = Color.Black;
            labelChildFullName.ForeColor = Color.Black;
            labelChildAge.ForeColor = Color.Black;
            labelClientSex.ForeColor = Color.Black;
            labelChildSex.ForeColor = Color.Black;

            groupBoxChild.Visible = false;
            groupBoxAmountChildren.Visible = false;
            groupBoxQuestionChildren.Visible = false;
        }
        // Изменение цвета текста, перед полями которые обязательно должы быть заполнены, на исходный.
        private void textBoxClientFullName_Click(object sender, EventArgs e) => 
            labelClientFullName.ForeColor = Color.Black;
        private void textBoxClientPhoneNumber_Click(object sender, EventArgs e) => 
            labelClientPhoneNumber.ForeColor = Color.Black;
        private void textBoxChildFullName_Click(object sender, EventArgs e) => 
            labelChildFullName.ForeColor = Color.Black;
        private void textBoxChildAge_Click(object sender, EventArgs e) => 
            labelChildAge.ForeColor = Color.Black;
        private void comboBoxClientSex_Click(object sender, EventArgs e) => 
            labelClientSex.ForeColor = Color.Black;
        private void comboBoxChildSex_Click(object sender, EventArgs e) => 
            labelChildSex.ForeColor = Color.Black;
    }
}
