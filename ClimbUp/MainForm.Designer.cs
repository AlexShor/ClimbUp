namespace ClimbUp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAuthorization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuBaseClients = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTrainingSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUserDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCoaches = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFullHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ContextMenuStrip = this.contextMenuStrip;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuApplication,
            this.toolStripMenuClients,
            this.toolStripMenuSchedule,
            this.toolStripMenuStaff,
            this.toolStripMenuWindows});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.toolStripMenuWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(811, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "file";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCascade,
            this.toolStripMenuItemTileHorizontal,
            this.toolStripMenuItemTileVertical});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(227, 70);
            this.contextMenuStrip.Text = "Упорядочить окна";
            // 
            // toolStripMenuItemCascade
            // 
            this.toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            this.toolStripMenuItemCascade.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItemCascade.Text = "Окна каскадом";
            this.toolStripMenuItemCascade.Click += new System.EventHandler(this.ToolStripMenuItemCascade_Click);
            // 
            // toolStripMenuItemTileHorizontal
            // 
            this.toolStripMenuItemTileHorizontal.Name = "toolStripMenuItemTileHorizontal";
            this.toolStripMenuItemTileHorizontal.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItemTileHorizontal.Text = "Объеденить горизонтально";
            this.toolStripMenuItemTileHorizontal.Click += new System.EventHandler(this.ToolStripMenuItemTileHorizontal_Click);
            // 
            // toolStripMenuItemTileVertical
            // 
            this.toolStripMenuItemTileVertical.Name = "toolStripMenuItemTileVertical";
            this.toolStripMenuItemTileVertical.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItemTileVertical.Text = "Объеденить вертикально";
            this.toolStripMenuItemTileVertical.Click += new System.EventHandler(this.ToolStripMenuItemTileVertical_Click);
            // 
            // toolStripMenuApplication
            // 
            this.toolStripMenuApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAuthorization,
            this.toolStripMenuLogout,
            this.toolStripSeparator1,
            this.toolStripMenuExit});
            this.toolStripMenuApplication.Name = "toolStripMenuApplication";
            this.toolStripMenuApplication.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuApplication.Text = "Приложение";
            // 
            // toolStripMenuAuthorization
            // 
            this.toolStripMenuAuthorization.Name = "toolStripMenuAuthorization";
            this.toolStripMenuAuthorization.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuAuthorization.Text = "Авторизация";
            this.toolStripMenuAuthorization.Click += new System.EventHandler(this.ToolStripMenuAuthorization_Click);
            // 
            // toolStripMenuLogout
            // 
            this.toolStripMenuLogout.Name = "toolStripMenuLogout";
            this.toolStripMenuLogout.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuLogout.Text = "Выйти";
            this.toolStripMenuLogout.Visible = false;
            this.toolStripMenuLogout.Click += new System.EventHandler(this.ToolStripMenuLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuExit.Text = "Выход из приложения";
            this.toolStripMenuExit.Click += new System.EventHandler(this.ToolStripMenuExit_Click);
            // 
            // toolStripMenuClients
            // 
            this.toolStripMenuClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuBaseClients,
            this.toolStripMenuAddClient});
            this.toolStripMenuClients.Name = "toolStripMenuClients";
            this.toolStripMenuClients.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuClients.Text = "Клиенты";
            this.toolStripMenuClients.Visible = false;
            // 
            // toolStripMenuBaseClients
            // 
            this.toolStripMenuBaseClients.Name = "toolStripMenuBaseClients";
            this.toolStripMenuBaseClients.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuBaseClients.Text = "База клиентов";
            this.toolStripMenuBaseClients.Click += new System.EventHandler(this.ToolStripMenuBaseClients_Click);
            // 
            // toolStripMenuAddClient
            // 
            this.toolStripMenuAddClient.Name = "toolStripMenuAddClient";
            this.toolStripMenuAddClient.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuAddClient.Text = "Добавить клиента";
            this.toolStripMenuAddClient.Click += new System.EventHandler(this.ToolStripMenuAddClient_Click);
            // 
            // toolStripMenuSchedule
            // 
            this.toolStripMenuSchedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuTrainingSchedule});
            this.toolStripMenuSchedule.Name = "toolStripMenuSchedule";
            this.toolStripMenuSchedule.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuSchedule.Text = "Расписание";
            this.toolStripMenuSchedule.Visible = false;
            // 
            // toolStripMenuTrainingSchedule
            // 
            this.toolStripMenuTrainingSchedule.Name = "toolStripMenuTrainingSchedule";
            this.toolStripMenuTrainingSchedule.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuTrainingSchedule.Text = "Расписание тренировок";
            this.toolStripMenuTrainingSchedule.Click += new System.EventHandler(this.ToolStripMenuTrainingSchedule_Click);
            // 
            // toolStripMenuStaff
            // 
            this.toolStripMenuStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuUserDate,
            this.toolStripMenuItemCoaches,
            this.toolStripMenuItemUsers,
            this.toolStripMenuItemFullHistory});
            this.toolStripMenuStaff.Name = "toolStripMenuStaff";
            this.toolStripMenuStaff.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuStaff.Text = "Персонал";
            this.toolStripMenuStaff.Visible = false;
            // 
            // toolStripMenuUserDate
            // 
            this.toolStripMenuUserDate.Name = "toolStripMenuUserDate";
            this.toolStripMenuUserDate.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuUserDate.Text = "Данные пользователя";
            this.toolStripMenuUserDate.Click += new System.EventHandler(this.ToolStripMenuUserDate_Click);
            // 
            // toolStripMenuItemCoaches
            // 
            this.toolStripMenuItemCoaches.Name = "toolStripMenuItemCoaches";
            this.toolStripMenuItemCoaches.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemCoaches.Text = "Тренера";
            this.toolStripMenuItemCoaches.Click += new System.EventHandler(this.ToolStripMenuItemCoaches_Click);
            // 
            // toolStripMenuItemUsers
            // 
            this.toolStripMenuItemUsers.Name = "toolStripMenuItemUsers";
            this.toolStripMenuItemUsers.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemUsers.Text = "Пользователи";
            this.toolStripMenuItemUsers.Click += new System.EventHandler(this.ToolStripMenuItemUsers_Click);
            // 
            // toolStripMenuWindows
            // 
            this.toolStripMenuWindows.Name = "toolStripMenuWindows";
            this.toolStripMenuWindows.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuWindows.Text = "Окна";
            this.toolStripMenuWindows.Visible = false;
            // 
            // toolStripMenuItemFullHistory
            // 
            this.toolStripMenuItemFullHistory.Name = "toolStripMenuItemFullHistory";
            this.toolStripMenuItemFullHistory.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemFullHistory.Text = "Полная история";
            this.toolStripMenuItemFullHistory.Click += new System.EventHandler(this.ToolStripMenuItemFullHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 439);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "ClimbUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClients;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuBaseClients;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSchedule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTrainingSchedule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuApplication;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAuthorization;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuStaff;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUserDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuWindows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddClient;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCoaches;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTileVertical;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFullHistory;
    }
}

