using System;
using System.Windows.Forms;

namespace ClimbUp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Действия при загрузке формы.
        private void MainForm_Load(object sender, EventArgs e)
        {
            new History(24, null, null, null, null, null); // Запись действия в историю.
            Authorization(); // Выполнение матода Authorization().
        }

        private void Authorization() // Метод открытия окна авторизации.
        {
            // Создание экземпляка окна авторизации и открытие его.
            new AuthorizationForm().ShowDialog();
            // Проверка прохождения авторизации.
            if (AuthorizationForm.AuthorizationCheck == true)
            {
                // Если авторизация успешна - отображение элементов меню.
                toolStripMenuAuthorization.Text = "Переавторизоваться";
                toolStripMenuLogout.Visible = true;
                toolStripMenuClients.Visible = true;
                toolStripMenuSchedule.Visible = true;
                toolStripMenuStaff.Visible = true;
                toolStripMenuWindows.Visible = true;
                if (DataBank.UserType != "Директор") toolStripMenuItemUsers.Enabled = false;
                else toolStripMenuItemUsers.Enabled = true;
                // Указание в названии формы имени зарегестрированого пользователя.
                Text = "ClimbUp   | Авторизован: " + DataBank.UserLogin + " | " + DataBank.UserType +
                    " - " + DataBank.UserFullName + " | " + DateTime.Now.ToString();
                AuthorizationForm.AuthorizationCheck = false;
            }
        }
        // Действия при нажатии кнопки 'База клиентов' в меню 'Клиенты'.
        private void ToolStripMenuBaseClients_Click(object sender, EventArgs e)
        {
            // Открывает дочернее окно ClientsForm.
            ClientsForm newMDIChild = new ClientsForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Авторизация (Переавторизоваться)' в меню 'Приложение'.
        private void ToolStripMenuAuthorization_Click(object sender, EventArgs e)
        {
            new History(21, null, null, null, null, null); // Запись действия в историю.
            Authorization(); // Выполнение матода Authorization().
        }
        // Действия при нажатии кнопки 'Выйти' в меню 'Приложение'.
        private void ToolStripMenuLogout_Click(object sender, EventArgs e)
        {
            // Изменение внешнего вида и доступа объектов интерфейса.
            toolStripMenuAuthorization.Text = "Авторизация";
            toolStripMenuLogout.Visible = false;
            toolStripMenuClients.Visible = false;
            toolStripMenuSchedule.Visible = false;
            toolStripMenuStaff.Visible = false;
            toolStripMenuWindows.Visible = false;
            Text = "ClimbUp";
            new History(22, null, null, null, null, null); // Запись действия в историю.
            Authorization(); // Выполнение матода Authorization().
        }
        // Действия при нажатии кнопки 'Выход из приложения' в меню 'Приложение'.
        private void ToolStripMenuExit_Click(
            object sender, EventArgs e) => this.Close(); // Выход из приложения.
        // Действия при нажатии кнопки 'Данные пользователя' в меню 'Персонал'.
        private void ToolStripMenuUserDate_Click(object sender, EventArgs e)
        {
            // Открывает дочернее окно UserDateForm.
            UserDateForm newMDIChild = new UserDateForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Добавить клиента' в меню 'Клиенты'.
        private void ToolStripMenuAddClient_Click(object sender, EventArgs e)
        {
            // Открывает окно AddClientForm.
            AddClientForm newMDIChild = new AddClientForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Расписание тренировок' в меню 'Расписание'.
        private void ToolStripMenuTrainingSchedule_Click(object sender, EventArgs e)
        {
            // Открывает дочернее окно TrainingScheduleForm.
            TrainingScheduleForm newMDIChild = new TrainingScheduleForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Тренера' в меню 'Персонал'.
        private void ToolStripMenuItemCoaches_Click(object sender, EventArgs e)
        {
            // Открывает дочернее окно CoachesForm.
            CoachesForm newMDIChild = new CoachesForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // Действия при нажатии кнопки 'Пользователи' в меню 'Персонал'.
        private void ToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            // Открывает дочернее окно UsersForm.
            UsersForm newMDIChild = new UsersForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // Происходит при закрытии окна приложения.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Вызавает сообщение с подтверждением об выходе из приложения.
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход из приложения.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new History(22, null, null, null, null, null); // Запись действия в историю.
                new History(23, null, null, null, null, null); // Запись действия в историю.
                return;
            }
            e.Cancel = true;
            return;
        }

        private void ToolStripMenuItemFullHistory_Click(object sender, EventArgs e)
        {
            HistoryForm newMDIChild = new HistoryForm(null);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // Расположение окон.
        private void ToolStripMenuItemCascade_Click(object sender, EventArgs e) => 
            LayoutMdi(MdiLayout.Cascade);
        private void ToolStripMenuItemTileHorizontal_Click(object sender, EventArgs e) => 
            LayoutMdi(MdiLayout.TileHorizontal);
        private void ToolStripMenuItemTileVertical_Click(object sender, EventArgs e) => 
            LayoutMdi(MdiLayout.TileVertical);

        
    }
}
