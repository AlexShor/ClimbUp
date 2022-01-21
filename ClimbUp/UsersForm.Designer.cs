namespace ClimbUp
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.groupBoxChangeData = new System.Windows.Forms.GroupBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.groupBoxUsersData = new System.Windows.Forms.GroupBox();
            this.checkBoxResetPassword = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClientFullName = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxDGV = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeData.SuspendLayout();
            this.groupBoxUsersData.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Enabled = false;
            this.buttonChangeData.Location = new System.Drawing.Point(6, 19);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(140, 22);
            this.buttonChangeData.TabIndex = 1;
            this.buttonChangeData.Text = "Изменить данные";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeDate_Click);
            // 
            // groupBoxChangeData
            // 
            this.groupBoxChangeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChangeData.Controls.Add(this.buttonSaveData);
            this.groupBoxChangeData.Controls.Add(this.buttonChangeData);
            this.groupBoxChangeData.Location = new System.Drawing.Point(598, 190);
            this.groupBoxChangeData.Name = "groupBoxChangeData";
            this.groupBoxChangeData.Size = new System.Drawing.Size(175, 99);
            this.groupBoxChangeData.TabIndex = 11;
            this.groupBoxChangeData.TabStop = false;
            this.groupBoxChangeData.Text = "Изменить данные";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Enabled = false;
            this.buttonSaveData.Location = new System.Drawing.Point(6, 47);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(140, 22);
            this.buttonSaveData.TabIndex = 2;
            this.buttonSaveData.Text = "Сохранить";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // groupBoxUsersData
            // 
            this.groupBoxUsersData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUsersData.Controls.Add(this.checkBoxResetPassword);
            this.groupBoxUsersData.Controls.Add(this.comboBoxType);
            this.groupBoxUsersData.Controls.Add(this.textBoxFullName);
            this.groupBoxUsersData.Controls.Add(this.label2);
            this.groupBoxUsersData.Controls.Add(this.label1);
            this.groupBoxUsersData.Controls.Add(this.labelClientFullName);
            this.groupBoxUsersData.Controls.Add(this.textBoxLogin);
            this.groupBoxUsersData.Enabled = false;
            this.groupBoxUsersData.Location = new System.Drawing.Point(4, 190);
            this.groupBoxUsersData.Name = "groupBoxUsersData";
            this.groupBoxUsersData.Size = new System.Drawing.Size(588, 99);
            this.groupBoxUsersData.TabIndex = 10;
            this.groupBoxUsersData.TabStop = false;
            this.groupBoxUsersData.Text = "Данные пользователя";
            // 
            // checkBoxResetPassword
            // 
            this.checkBoxResetPassword.AutoSize = true;
            this.checkBoxResetPassword.Location = new System.Drawing.Point(443, 18);
            this.checkBoxResetPassword.Name = "checkBoxResetPassword";
            this.checkBoxResetPassword.Size = new System.Drawing.Size(113, 17);
            this.checkBoxResetPassword.TabIndex = 19;
            this.checkBoxResetPassword.Text = "Сбросить пароль";
            this.checkBoxResetPassword.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Менеджер",
            "Бухгалтер",
            "Администратор",
            "Директор"});
            this.comboBoxType.Location = new System.Drawing.Point(152, 70);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(233, 21);
            this.comboBoxType.TabIndex = 18;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(152, 44);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(233, 20);
            this.textBoxFullName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Должность пользоваеля:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин пользоваеля:";
            // 
            // labelClientFullName
            // 
            this.labelClientFullName.AutoSize = true;
            this.labelClientFullName.Location = new System.Drawing.Point(6, 47);
            this.labelClientFullName.Name = "labelClientFullName";
            this.labelClientFullName.Size = new System.Drawing.Size(111, 13);
            this.labelClientFullName.TabIndex = 13;
            this.labelClientFullName.Text = "ФИО пользователя:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLogin.Location = new System.Drawing.Point(152, 16);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(233, 20);
            this.textBoxLogin.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(6, 125);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 22);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(6, 153);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 24);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(6, 95);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(140, 24);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.buttonViewHistory);
            this.groupBoxMain.Controls.Add(this.buttonAdd);
            this.groupBoxMain.Controls.Add(this.buttonCancel);
            this.groupBoxMain.Controls.Add(this.buttonAddUser);
            this.groupBoxMain.Controls.Add(this.buttonDelete);
            this.groupBoxMain.Location = new System.Drawing.Point(598, 1);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(175, 183);
            this.groupBoxMain.TabIndex = 9;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Управление данными";
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.Enabled = false;
            this.buttonViewHistory.Location = new System.Drawing.Point(6, 46);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(140, 24);
            this.buttonViewHistory.TabIndex = 6;
            this.buttonViewHistory.Text = "Показать историю";
            this.buttonViewHistory.UseVisualStyleBackColor = true;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(6, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 24);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Удалить из базы";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.RowHeadersWidth = 10;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.Height = 18;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(582, 164);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // groupBoxDGV
            // 
            this.groupBoxDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDGV.AutoSize = true;
            this.groupBoxDGV.Controls.Add(this.dataGridView);
            this.groupBoxDGV.Location = new System.Drawing.Point(4, 1);
            this.groupBoxDGV.Name = "groupBoxDGV";
            this.groupBoxDGV.Size = new System.Drawing.Size(588, 183);
            this.groupBoxDGV.TabIndex = 8;
            this.groupBoxDGV.TabStop = false;
            this.groupBoxDGV.Text = "Пользователи";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 302);
            this.Controls.Add(this.groupBoxChangeData);
            this.Controls.Add(this.groupBoxUsersData);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.groupBoxDGV);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            this.groupBoxChangeData.ResumeLayout(false);
            this.groupBoxUsersData.ResumeLayout(false);
            this.groupBoxUsersData.PerformLayout();
            this.groupBoxMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.GroupBox groupBoxChangeData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.GroupBox groupBoxUsersData;
        private System.Windows.Forms.Label labelClientFullName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxDGV;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxResetPassword;
        private System.Windows.Forms.Button buttonViewHistory;
    }
}