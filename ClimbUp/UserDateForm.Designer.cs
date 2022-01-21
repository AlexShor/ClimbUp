namespace ClimbUp
{
    partial class UserDateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.buttonSavePassword = new System.Windows.Forms.Button();
            this.textBoxNewPasswodrAgain = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFullName);
            this.groupBox1.Controls.Add(this.labelFullName);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователь";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Enabled = false;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Менеджер",
            "Бухгалтер",
            "Администратор",
            "Директор"});
            this.comboBoxType.Location = new System.Drawing.Point(145, 45);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(233, 21);
            this.comboBoxType.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Должность пользоваеля:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(145, 71);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(233, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин пользоваеля:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Enabled = false;
            this.textBoxFullName.Location = new System.Drawing.Point(145, 19);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(233, 20);
            this.textBoxFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(6, 22);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(106, 13);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ФИО пользоваеля:";
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.buttonSavePassword);
            this.groupBoxPassword.Controls.Add(this.textBoxNewPasswodrAgain);
            this.groupBoxPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxPassword.Controls.Add(this.label5);
            this.groupBoxPassword.Controls.Add(this.label3);
            this.groupBoxPassword.Controls.Add(this.textBoxNewPassword);
            this.groupBoxPassword.Controls.Add(this.label4);
            this.groupBoxPassword.Location = new System.Drawing.Point(4, 129);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(557, 101);
            this.groupBoxPassword.TabIndex = 1;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Смена пароля";
            this.groupBoxPassword.Visible = false;
            // 
            // buttonSavePassword
            // 
            this.buttonSavePassword.Location = new System.Drawing.Point(400, 19);
            this.buttonSavePassword.Name = "buttonSavePassword";
            this.buttonSavePassword.Size = new System.Drawing.Size(149, 20);
            this.buttonSavePassword.TabIndex = 4;
            this.buttonSavePassword.Text = "Сохранить";
            this.buttonSavePassword.UseVisualStyleBackColor = true;
            this.buttonSavePassword.Click += new System.EventHandler(this.buttonSavePassword_Click);
            // 
            // textBoxNewPasswodrAgain
            // 
            this.textBoxNewPasswodrAgain.Location = new System.Drawing.Point(145, 71);
            this.textBoxNewPasswodrAgain.Name = "textBoxNewPasswodrAgain";
            this.textBoxNewPasswodrAgain.PasswordChar = '*';
            this.textBoxNewPasswodrAgain.Size = new System.Drawing.Size(233, 20);
            this.textBoxNewPasswodrAgain.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(145, 19);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(233, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Повторите пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль пользоваеля:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(145, 45);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(233, 20);
            this.textBoxNewPassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Новый пароль:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonViewHistory);
            this.groupBox3.Controls.Add(this.buttonSaveData);
            this.groupBox3.Controls.Add(this.buttonChangePassword);
            this.groupBox3.Controls.Add(this.buttonChangeData);
            this.groupBox3.Location = new System.Drawing.Point(398, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление данными";
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.Location = new System.Drawing.Point(6, 70);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(149, 20);
            this.buttonViewHistory.TabIndex = 5;
            this.buttonViewHistory.Text = "Показать историю";
            this.buttonViewHistory.UseVisualStyleBackColor = true;
            this.buttonViewHistory.Click += new System.EventHandler(this.ButtonViewHistory_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Enabled = false;
            this.buttonSaveData.Location = new System.Drawing.Point(6, 45);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(149, 20);
            this.buttonSaveData.TabIndex = 4;
            this.buttonSaveData.Text = "Сохранить данные";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(6, 95);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(149, 20);
            this.buttonChangePassword.TabIndex = 3;
            this.buttonChangePassword.Text = "Изменить пароль";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Location = new System.Drawing.Point(6, 19);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(149, 20);
            this.buttonChangeData.TabIndex = 0;
            this.buttonChangeData.Text = "Изменить данные";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeData_Click);
            // 
            // UserDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 274);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxPassword);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserDateForm";
            this.Text = "Данные пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPasswodrAgain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonSavePassword;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonViewHistory;
    }
}