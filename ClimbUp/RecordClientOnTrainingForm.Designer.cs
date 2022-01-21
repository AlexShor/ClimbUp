namespace ClimbUp
{
    partial class RecordClientOnTrainingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDeyWeek = new System.Windows.Forms.Label();
            this.comboBoxDeyWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeTraining = new System.Windows.Forms.ComboBox();
            this.labelTimeTraining = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCommentsClient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxClientSportCatigory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEMailClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumberClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSexClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFullNameClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTrainings = new System.Windows.Forms.GroupBox();
            this.buttonDeleteTraining = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonNewTraining = new System.Windows.Forms.Button();
            this.groupBoxNewTraining = new System.Windows.Forms.GroupBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelCoach = new System.Windows.Forms.Label();
            this.comboBoxTypeTraining = new System.Windows.Forms.ComboBox();
            this.comboBoxCoach = new System.Windows.Forms.ComboBox();
            this.labelTypeTraining = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTrainings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBoxNewTraining.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDeyWeek
            // 
            this.labelDeyWeek.AutoSize = true;
            this.labelDeyWeek.Location = new System.Drawing.Point(6, 29);
            this.labelDeyWeek.Name = "labelDeyWeek";
            this.labelDeyWeek.Size = new System.Drawing.Size(76, 13);
            this.labelDeyWeek.TabIndex = 0;
            this.labelDeyWeek.Text = "День недели:";
            // 
            // comboBoxDeyWeek
            // 
            this.comboBoxDeyWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeyWeek.FormattingEnabled = true;
            this.comboBoxDeyWeek.Location = new System.Drawing.Point(111, 26);
            this.comboBoxDeyWeek.Name = "comboBoxDeyWeek";
            this.comboBoxDeyWeek.Size = new System.Drawing.Size(138, 21);
            this.comboBoxDeyWeek.TabIndex = 1;
            this.comboBoxDeyWeek.Click += new System.EventHandler(this.comboBoxDeyWeek_Click);
            // 
            // comboBoxTimeTraining
            // 
            this.comboBoxTimeTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeTraining.FormattingEnabled = true;
            this.comboBoxTimeTraining.Location = new System.Drawing.Point(111, 53);
            this.comboBoxTimeTraining.Name = "comboBoxTimeTraining";
            this.comboBoxTimeTraining.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTimeTraining.TabIndex = 3;
            this.comboBoxTimeTraining.Click += new System.EventHandler(this.comboBoxTimeTraining_Click);
            // 
            // labelTimeTraining
            // 
            this.labelTimeTraining.AutoSize = true;
            this.labelTimeTraining.Location = new System.Drawing.Point(6, 56);
            this.labelTimeTraining.Name = "labelTimeTraining";
            this.labelTimeTraining.Size = new System.Drawing.Size(105, 13);
            this.labelTimeTraining.TabIndex = 2;
            this.labelTimeTraining.Text = "Время тренировки:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDeyWeek);
            this.groupBox1.Controls.Add(this.comboBoxTimeTraining);
            this.groupBox1.Controls.Add(this.comboBoxDeyWeek);
            this.groupBox1.Controls.Add(this.labelTimeTraining);
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "День недели и время тренировки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCommentsClient);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxClientSportCatigory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxEMailClient);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxPhoneNumberClient);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxSexClient);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFullNameClient);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 225);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиент";
            // 
            // textBoxCommentsClient
            // 
            this.textBoxCommentsClient.Enabled = false;
            this.textBoxCommentsClient.Location = new System.Drawing.Point(161, 146);
            this.textBoxCommentsClient.Multiline = true;
            this.textBoxCommentsClient.Name = "textBoxCommentsClient";
            this.textBoxCommentsClient.Size = new System.Drawing.Size(256, 73);
            this.textBoxCommentsClient.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Коменнтарии:";
            // 
            // textBoxClientSportCatigory
            // 
            this.textBoxClientSportCatigory.Enabled = false;
            this.textBoxClientSportCatigory.Location = new System.Drawing.Point(161, 120);
            this.textBoxClientSportCatigory.Name = "textBoxClientSportCatigory";
            this.textBoxClientSportCatigory.Size = new System.Drawing.Size(256, 20);
            this.textBoxClientSportCatigory.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Спортивный разряд клиента:";
            // 
            // textBoxEMailClient
            // 
            this.textBoxEMailClient.Enabled = false;
            this.textBoxEMailClient.Location = new System.Drawing.Point(161, 94);
            this.textBoxEMailClient.Name = "textBoxEMailClient";
            this.textBoxEMailClient.Size = new System.Drawing.Size(256, 20);
            this.textBoxEMailClient.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "E-Mail клиента:";
            // 
            // textBoxPhoneNumberClient
            // 
            this.textBoxPhoneNumberClient.Enabled = false;
            this.textBoxPhoneNumberClient.Location = new System.Drawing.Point(161, 68);
            this.textBoxPhoneNumberClient.Name = "textBoxPhoneNumberClient";
            this.textBoxPhoneNumberClient.Size = new System.Drawing.Size(256, 20);
            this.textBoxPhoneNumberClient.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер телефона клиента:";
            // 
            // textBoxSexClient
            // 
            this.textBoxSexClient.Enabled = false;
            this.textBoxSexClient.Location = new System.Drawing.Point(161, 42);
            this.textBoxSexClient.Name = "textBoxSexClient";
            this.textBoxSexClient.Size = new System.Drawing.Size(256, 20);
            this.textBoxSexClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол клиента:";
            // 
            // textBoxFullNameClient
            // 
            this.textBoxFullNameClient.Enabled = false;
            this.textBoxFullNameClient.Location = new System.Drawing.Point(161, 16);
            this.textBoxFullNameClient.Name = "textBoxFullNameClient";
            this.textBoxFullNameClient.Size = new System.Drawing.Size(256, 20);
            this.textBoxFullNameClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО клиента:";
            // 
            // groupBoxTrainings
            // 
            this.groupBoxTrainings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTrainings.Controls.Add(this.buttonDeleteTraining);
            this.groupBoxTrainings.Controls.Add(this.dataGridView);
            this.groupBoxTrainings.Enabled = false;
            this.groupBoxTrainings.Location = new System.Drawing.Point(7, 230);
            this.groupBoxTrainings.Name = "groupBoxTrainings";
            this.groupBoxTrainings.Size = new System.Drawing.Size(962, 185);
            this.groupBoxTrainings.TabIndex = 6;
            this.groupBoxTrainings.TabStop = false;
            this.groupBoxTrainings.Text = "Текущие тенировки";
            // 
            // buttonDeleteTraining
            // 
            this.buttonDeleteTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteTraining.Location = new System.Drawing.Point(3, 156);
            this.buttonDeleteTraining.Name = "buttonDeleteTraining";
            this.buttonDeleteTraining.Size = new System.Drawing.Size(151, 23);
            this.buttonDeleteTraining.TabIndex = 1;
            this.buttonDeleteTraining.Text = "Удалить тренировку";
            this.buttonDeleteTraining.UseVisualStyleBackColor = true;
            this.buttonDeleteTraining.Click += new System.EventHandler(this.buttonDeleteTraining_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersWidth = 10;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.Height = 18;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(955, 134);
            this.dataGridView.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonNewTraining);
            this.groupBox5.Location = new System.Drawing.Point(435, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(534, 46);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // buttonNewTraining
            // 
            this.buttonNewTraining.Location = new System.Drawing.Point(5, 14);
            this.buttonNewTraining.Name = "buttonNewTraining";
            this.buttonNewTraining.Size = new System.Drawing.Size(151, 23);
            this.buttonNewTraining.TabIndex = 0;
            this.buttonNewTraining.Text = "Запись на тренировку";
            this.buttonNewTraining.UseVisualStyleBackColor = true;
            this.buttonNewTraining.Click += new System.EventHandler(this.buttonNewTraining_Click);
            // 
            // groupBoxNewTraining
            // 
            this.groupBoxNewTraining.Controls.Add(this.buttonRecord);
            this.groupBoxNewTraining.Controls.Add(this.groupBox7);
            this.groupBoxNewTraining.Controls.Add(this.groupBox1);
            this.groupBoxNewTraining.Enabled = false;
            this.groupBoxNewTraining.Location = new System.Drawing.Point(435, 51);
            this.groupBoxNewTraining.Name = "groupBoxNewTraining";
            this.groupBoxNewTraining.Size = new System.Drawing.Size(534, 179);
            this.groupBoxNewTraining.TabIndex = 8;
            this.groupBoxNewTraining.TabStop = false;
            this.groupBoxNewTraining.Text = "Запись на тренировку";
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(376, 124);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(151, 23);
            this.buttonRecord.TabIndex = 1;
            this.buttonRecord.Text = "Записать на тренировку";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelCoach);
            this.groupBox7.Controls.Add(this.comboBoxTypeTraining);
            this.groupBox7.Controls.Add(this.comboBoxCoach);
            this.groupBox7.Controls.Add(this.labelTypeTraining);
            this.groupBox7.Location = new System.Drawing.Point(271, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(256, 81);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Тренер и тип тренировка";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(6, 29);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(47, 13);
            this.labelCoach.TabIndex = 0;
            this.labelCoach.Text = "Тренер:";
            // 
            // comboBoxTypeTraining
            // 
            this.comboBoxTypeTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeTraining.FormattingEnabled = true;
            this.comboBoxTypeTraining.Location = new System.Drawing.Point(111, 53);
            this.comboBoxTypeTraining.Name = "comboBoxTypeTraining";
            this.comboBoxTypeTraining.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTypeTraining.TabIndex = 3;
            this.comboBoxTypeTraining.Click += new System.EventHandler(this.comboBoxTypeTraining_Click);
            // 
            // comboBoxCoach
            // 
            this.comboBoxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoach.FormattingEnabled = true;
            this.comboBoxCoach.Location = new System.Drawing.Point(111, 26);
            this.comboBoxCoach.Name = "comboBoxCoach";
            this.comboBoxCoach.Size = new System.Drawing.Size(138, 21);
            this.comboBoxCoach.TabIndex = 1;
            this.comboBoxCoach.Click += new System.EventHandler(this.comboBoxCoach_Click);
            // 
            // labelTypeTraining
            // 
            this.labelTypeTraining.AutoSize = true;
            this.labelTypeTraining.Location = new System.Drawing.Point(6, 56);
            this.labelTypeTraining.Name = "labelTypeTraining";
            this.labelTypeTraining.Size = new System.Drawing.Size(91, 13);
            this.labelTypeTraining.TabIndex = 2;
            this.labelTypeTraining.Text = "Тип тренировки:";
            // 
            // RecordClientOnTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 420);
            this.Controls.Add(this.groupBoxNewTraining);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBoxTrainings);
            this.Controls.Add(this.groupBox2);
            this.Name = "RecordClientOnTrainingForm";
            this.Text = "Запись клиента на тренировку";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTrainings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBoxNewTraining.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDeyWeek;
        private System.Windows.Forms.ComboBox comboBoxDeyWeek;
        private System.Windows.Forms.ComboBox comboBoxTimeTraining;
        private System.Windows.Forms.Label labelTimeTraining;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxTrainings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonNewTraining;
        private System.Windows.Forms.TextBox textBoxCommentsClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxClientSportCatigory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEMailClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhoneNumberClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSexClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFullNameClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxNewTraining;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.ComboBox comboBoxTypeTraining;
        private System.Windows.Forms.ComboBox comboBoxCoach;
        private System.Windows.Forms.Label labelTypeTraining;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDeleteTraining;
    }
}