namespace ClimbUp
{
    partial class CoachesForm
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
            this.groupBoxDGV = new System.Windows.Forms.GroupBox();
            this.dataGridViewCoaches = new System.Windows.Forms.DataGridView();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddCoach = new System.Windows.Forms.Button();
            this.buttonDeleteCoach = new System.Windows.Forms.Button();
            this.groupBoxCoachData = new System.Windows.Forms.GroupBox();
            this.comboBoxCoachSportCatigory = new System.Windows.Forms.ComboBox();
            this.comboBoxCoachSex = new System.Windows.Forms.ComboBox();
            this.labelClientSex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelClientFullName = new System.Windows.Forms.Label();
            this.textBoxCoachInfo = new System.Windows.Forms.TextBox();
            this.textBoxCoachFullName = new System.Windows.Forms.TextBox();
            this.textBoxCoachPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelClientPhoneNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxChangeData = new System.Windows.Forms.GroupBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.groupBoxDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).BeginInit();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxCoachData.SuspendLayout();
            this.groupBoxChangeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDGV
            // 
            this.groupBoxDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDGV.AutoSize = true;
            this.groupBoxDGV.Controls.Add(this.dataGridViewCoaches);
            this.groupBoxDGV.Location = new System.Drawing.Point(5, 4);
            this.groupBoxDGV.Name = "groupBoxDGV";
            this.groupBoxDGV.Size = new System.Drawing.Size(809, 183);
            this.groupBoxDGV.TabIndex = 0;
            this.groupBoxDGV.TabStop = false;
            this.groupBoxDGV.Text = "Тренера";
            // 
            // dataGridViewCoaches
            // 
            this.dataGridViewCoaches.AllowUserToAddRows = false;
            this.dataGridViewCoaches.AllowUserToDeleteRows = false;
            this.dataGridViewCoaches.AllowUserToOrderColumns = true;
            this.dataGridViewCoaches.AllowUserToResizeRows = false;
            this.dataGridViewCoaches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoaches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCoaches.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCoaches.MultiSelect = false;
            this.dataGridViewCoaches.Name = "dataGridViewCoaches";
            this.dataGridViewCoaches.ReadOnly = true;
            this.dataGridViewCoaches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCoaches.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCoaches.RowHeadersWidth = 10;
            this.dataGridViewCoaches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCoaches.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewCoaches.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCoaches.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCoaches.RowTemplate.Height = 18;
            this.dataGridViewCoaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCoaches.Size = new System.Drawing.Size(803, 164);
            this.dataGridViewCoaches.TabIndex = 3;
            this.dataGridViewCoaches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoaches_CellClick);
            this.dataGridViewCoaches.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCoaches_DataBindingComplete);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.buttonAdd);
            this.groupBoxMain.Controls.Add(this.buttonCancel);
            this.groupBoxMain.Controls.Add(this.buttonAddCoach);
            this.groupBoxMain.Controls.Add(this.buttonDeleteCoach);
            this.groupBoxMain.Location = new System.Drawing.Point(820, 4);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(175, 183);
            this.groupBoxMain.TabIndex = 4;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Управление данными";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(6, 125);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 22);
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
            this.buttonCancel.Size = new System.Drawing.Size(127, 24);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddCoach
            // 
            this.buttonAddCoach.Location = new System.Drawing.Point(6, 95);
            this.buttonAddCoach.Name = "buttonAddCoach";
            this.buttonAddCoach.Size = new System.Drawing.Size(127, 24);
            this.buttonAddCoach.TabIndex = 1;
            this.buttonAddCoach.Text = "Добавить тренера";
            this.buttonAddCoach.UseVisualStyleBackColor = true;
            this.buttonAddCoach.Click += new System.EventHandler(this.buttonAddCoach_Click);
            // 
            // buttonDeleteCoach
            // 
            this.buttonDeleteCoach.Enabled = false;
            this.buttonDeleteCoach.Location = new System.Drawing.Point(6, 16);
            this.buttonDeleteCoach.Name = "buttonDeleteCoach";
            this.buttonDeleteCoach.Size = new System.Drawing.Size(127, 24);
            this.buttonDeleteCoach.TabIndex = 0;
            this.buttonDeleteCoach.Text = "Удалить из базы";
            this.buttonDeleteCoach.UseVisualStyleBackColor = true;
            this.buttonDeleteCoach.Click += new System.EventHandler(this.buttonDeleteCoach_Click);
            // 
            // groupBoxCoachData
            // 
            this.groupBoxCoachData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCoachData.Controls.Add(this.comboBoxCoachSportCatigory);
            this.groupBoxCoachData.Controls.Add(this.comboBoxCoachSex);
            this.groupBoxCoachData.Controls.Add(this.labelClientSex);
            this.groupBoxCoachData.Controls.Add(this.label7);
            this.groupBoxCoachData.Controls.Add(this.labelClientFullName);
            this.groupBoxCoachData.Controls.Add(this.textBoxCoachInfo);
            this.groupBoxCoachData.Controls.Add(this.textBoxCoachFullName);
            this.groupBoxCoachData.Controls.Add(this.textBoxCoachPhoneNumber);
            this.groupBoxCoachData.Controls.Add(this.labelClientPhoneNumber);
            this.groupBoxCoachData.Controls.Add(this.label3);
            this.groupBoxCoachData.Enabled = false;
            this.groupBoxCoachData.Location = new System.Drawing.Point(5, 193);
            this.groupBoxCoachData.Name = "groupBoxCoachData";
            this.groupBoxCoachData.Size = new System.Drawing.Size(809, 172);
            this.groupBoxCoachData.TabIndex = 5;
            this.groupBoxCoachData.TabStop = false;
            this.groupBoxCoachData.Text = "Данные тренера";
            // 
            // comboBoxCoachSportCatigory
            // 
            this.comboBoxCoachSportCatigory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoachSportCatigory.FormattingEnabled = true;
            this.comboBoxCoachSportCatigory.Items.AddRange(new object[] {
            "",
            "Третий",
            "Второй",
            "Первый",
            "КМС",
            "МС",
            "МСМК"});
            this.comboBoxCoachSportCatigory.Location = new System.Drawing.Point(120, 100);
            this.comboBoxCoachSportCatigory.Name = "comboBoxCoachSportCatigory";
            this.comboBoxCoachSportCatigory.Size = new System.Drawing.Size(196, 21);
            this.comboBoxCoachSportCatigory.TabIndex = 22;
            // 
            // comboBoxCoachSex
            // 
            this.comboBoxCoachSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoachSex.FormattingEnabled = true;
            this.comboBoxCoachSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxCoachSex.Location = new System.Drawing.Point(120, 73);
            this.comboBoxCoachSex.Name = "comboBoxCoachSex";
            this.comboBoxCoachSex.Size = new System.Drawing.Size(95, 21);
            this.comboBoxCoachSex.TabIndex = 16;
            // 
            // labelClientSex
            // 
            this.labelClientSex.AutoSize = true;
            this.labelClientSex.Location = new System.Drawing.Point(7, 76);
            this.labelClientSex.Name = "labelClientSex";
            this.labelClientSex.Size = new System.Drawing.Size(30, 13);
            this.labelClientSex.TabIndex = 21;
            this.labelClientSex.Text = "Пол:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Спортивный разряд:";
            // 
            // labelClientFullName
            // 
            this.labelClientFullName.AutoSize = true;
            this.labelClientFullName.Location = new System.Drawing.Point(7, 24);
            this.labelClientFullName.Name = "labelClientFullName";
            this.labelClientFullName.Size = new System.Drawing.Size(81, 13);
            this.labelClientFullName.TabIndex = 13;
            this.labelClientFullName.Text = "ФИО тренера:";
            // 
            // textBoxCoachInfo
            // 
            this.textBoxCoachInfo.Location = new System.Drawing.Point(396, 19);
            this.textBoxCoachInfo.Multiline = true;
            this.textBoxCoachInfo.Name = "textBoxCoachInfo";
            this.textBoxCoachInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCoachInfo.Size = new System.Drawing.Size(407, 147);
            this.textBoxCoachInfo.TabIndex = 18;
            // 
            // textBoxCoachFullName
            // 
            this.textBoxCoachFullName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCoachFullName.Location = new System.Drawing.Point(120, 21);
            this.textBoxCoachFullName.Name = "textBoxCoachFullName";
            this.textBoxCoachFullName.Size = new System.Drawing.Size(196, 20);
            this.textBoxCoachFullName.TabIndex = 12;
            // 
            // textBoxCoachPhoneNumber
            // 
            this.textBoxCoachPhoneNumber.Location = new System.Drawing.Point(120, 47);
            this.textBoxCoachPhoneNumber.Name = "textBoxCoachPhoneNumber";
            this.textBoxCoachPhoneNumber.Size = new System.Drawing.Size(196, 20);
            this.textBoxCoachPhoneNumber.TabIndex = 17;
            // 
            // labelClientPhoneNumber
            // 
            this.labelClientPhoneNumber.AutoSize = true;
            this.labelClientPhoneNumber.Location = new System.Drawing.Point(7, 50);
            this.labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            this.labelClientPhoneNumber.Size = new System.Drawing.Size(96, 13);
            this.labelClientPhoneNumber.TabIndex = 14;
            this.labelClientPhoneNumber.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Информация:";
            // 
            // groupBoxChangeData
            // 
            this.groupBoxChangeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxChangeData.Controls.Add(this.buttonSaveData);
            this.groupBoxChangeData.Controls.Add(this.buttonChangeData);
            this.groupBoxChangeData.Location = new System.Drawing.Point(820, 193);
            this.groupBoxChangeData.Name = "groupBoxChangeData";
            this.groupBoxChangeData.Size = new System.Drawing.Size(175, 172);
            this.groupBoxChangeData.TabIndex = 7;
            this.groupBoxChangeData.TabStop = false;
            this.groupBoxChangeData.Text = "Изменить данные";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Enabled = false;
            this.buttonSaveData.Location = new System.Drawing.Point(6, 47);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(127, 22);
            this.buttonSaveData.TabIndex = 2;
            this.buttonSaveData.Text = "Сохранить";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveDate_Click);
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Enabled = false;
            this.buttonChangeData.Location = new System.Drawing.Point(6, 19);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(127, 22);
            this.buttonChangeData.TabIndex = 1;
            this.buttonChangeData.Text = "Изменить данные";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeDate_Click);
            // 
            // CoachesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 368);
            this.Controls.Add(this.groupBoxChangeData);
            this.Controls.Add(this.groupBoxCoachData);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.groupBoxDGV);
            this.MinimumSize = new System.Drawing.Size(1018, 407);
            this.Name = "CoachesForm";
            this.Text = "Тренера";
            this.groupBoxDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).EndInit();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxCoachData.ResumeLayout(false);
            this.groupBoxCoachData.PerformLayout();
            this.groupBoxChangeData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDGV;
        private System.Windows.Forms.DataGridView dataGridViewCoaches;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonDeleteCoach;
        private System.Windows.Forms.GroupBox groupBoxCoachData;
        private System.Windows.Forms.GroupBox groupBoxChangeData;
        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.ComboBox comboBoxCoachSportCatigory;
        private System.Windows.Forms.ComboBox comboBoxCoachSex;
        private System.Windows.Forms.Label labelClientSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelClientFullName;
        private System.Windows.Forms.TextBox textBoxCoachInfo;
        private System.Windows.Forms.TextBox textBoxCoachFullName;
        private System.Windows.Forms.TextBox textBoxCoachPhoneNumber;
        private System.Windows.Forms.Label labelClientPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonAddCoach;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}