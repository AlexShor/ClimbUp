namespace ClimbUp
{
    partial class RecordChildOnTrainingForm
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
            this.buttonDeleteTraining = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonNewTraining = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxCommentsChild = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxChildSportCatigory = new System.Windows.Forms.TextBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelCoach = new System.Windows.Forms.Label();
            this.comboBoxTypeTraining = new System.Windows.Forms.ComboBox();
            this.comboBoxCoach = new System.Windows.Forms.ComboBox();
            this.labelTypeTraining = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAgeChild = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxNewTraining = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDeyWeek = new System.Windows.Forms.Label();
            this.comboBoxTimeTraining = new System.Windows.Forms.ComboBox();
            this.comboBoxDeyWeek = new System.Windows.Forms.ComboBox();
            this.labelTimeTraining = new System.Windows.Forms.Label();
            this.textBoxSexChild = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFullNameChild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTrainings = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBoxNewTraining.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTrainings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeleteTraining
            // 
            this.buttonDeleteTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteTraining.Location = new System.Drawing.Point(3, 182);
            this.buttonDeleteTraining.Name = "buttonDeleteTraining";
            this.buttonDeleteTraining.Size = new System.Drawing.Size(151, 23);
            this.buttonDeleteTraining.TabIndex = 1;
            this.buttonDeleteTraining.Text = "Удалить тренировку";
            this.buttonDeleteTraining.UseVisualStyleBackColor = true;
            this.buttonDeleteTraining.Click += new System.EventHandler(this.buttonDeleteTraining_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonNewTraining);
            this.groupBox5.Location = new System.Drawing.Point(434, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(536, 48);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // buttonNewTraining
            // 
            this.buttonNewTraining.Location = new System.Drawing.Point(6, 15);
            this.buttonNewTraining.Name = "buttonNewTraining";
            this.buttonNewTraining.Size = new System.Drawing.Size(151, 23);
            this.buttonNewTraining.TabIndex = 0;
            this.buttonNewTraining.Text = "Запись на тренировку";
            this.buttonNewTraining.UseVisualStyleBackColor = true;
            this.buttonNewTraining.Click += new System.EventHandler(this.buttonNewTraining_Click);
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
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView.Size = new System.Drawing.Size(958, 160);
            this.dataGridView.TabIndex = 3;
            // 
            // textBoxCommentsChild
            // 
            this.textBoxCommentsChild.Enabled = false;
            this.textBoxCommentsChild.Location = new System.Drawing.Point(162, 122);
            this.textBoxCommentsChild.Multiline = true;
            this.textBoxCommentsChild.Name = "textBoxCommentsChild";
            this.textBoxCommentsChild.Size = new System.Drawing.Size(256, 73);
            this.textBoxCommentsChild.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Коменнтарии:";
            // 
            // textBoxChildSportCatigory
            // 
            this.textBoxChildSportCatigory.Enabled = false;
            this.textBoxChildSportCatigory.Location = new System.Drawing.Point(162, 96);
            this.textBoxChildSportCatigory.Name = "textBoxChildSportCatigory";
            this.textBoxChildSportCatigory.Size = new System.Drawing.Size(256, 20);
            this.textBoxChildSportCatigory.TabIndex = 10;
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(377, 108);
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
            this.groupBox7.Location = new System.Drawing.Point(272, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(256, 81);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Тренер и тип тренировка";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(7, 31);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(47, 13);
            this.labelCoach.TabIndex = 0;
            this.labelCoach.Text = "Тренер:";
            // 
            // comboBoxTypeTraining
            // 
            this.comboBoxTypeTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeTraining.FormattingEnabled = true;
            this.comboBoxTypeTraining.Location = new System.Drawing.Point(112, 55);
            this.comboBoxTypeTraining.Name = "comboBoxTypeTraining";
            this.comboBoxTypeTraining.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTypeTraining.TabIndex = 3;
            // 
            // comboBoxCoach
            // 
            this.comboBoxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoach.FormattingEnabled = true;
            this.comboBoxCoach.Location = new System.Drawing.Point(112, 28);
            this.comboBoxCoach.Name = "comboBoxCoach";
            this.comboBoxCoach.Size = new System.Drawing.Size(138, 21);
            this.comboBoxCoach.TabIndex = 1;
            // 
            // labelTypeTraining
            // 
            this.labelTypeTraining.AutoSize = true;
            this.labelTypeTraining.Location = new System.Drawing.Point(7, 58);
            this.labelTypeTraining.Name = "labelTypeTraining";
            this.labelTypeTraining.Size = new System.Drawing.Size(91, 13);
            this.labelTypeTraining.TabIndex = 2;
            this.labelTypeTraining.Text = "Тип тренировки:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Спортивный разряд ребенка:";
            // 
            // textBoxAgeChild
            // 
            this.textBoxAgeChild.Enabled = false;
            this.textBoxAgeChild.Location = new System.Drawing.Point(162, 70);
            this.textBoxAgeChild.Name = "textBoxAgeChild";
            this.textBoxAgeChild.Size = new System.Drawing.Size(256, 20);
            this.textBoxAgeChild.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Возраст ребенка:";
            // 
            // groupBoxNewTraining
            // 
            this.groupBoxNewTraining.Controls.Add(this.buttonRecord);
            this.groupBoxNewTraining.Controls.Add(this.groupBox7);
            this.groupBoxNewTraining.Controls.Add(this.groupBox1);
            this.groupBoxNewTraining.Enabled = false;
            this.groupBoxNewTraining.Location = new System.Drawing.Point(434, 52);
            this.groupBoxNewTraining.Name = "groupBoxNewTraining";
            this.groupBoxNewTraining.Size = new System.Drawing.Size(536, 154);
            this.groupBoxNewTraining.TabIndex = 12;
            this.groupBoxNewTraining.TabStop = false;
            this.groupBoxNewTraining.Text = "Запись на тренировку";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDeyWeek);
            this.groupBox1.Controls.Add(this.comboBoxTimeTraining);
            this.groupBox1.Controls.Add(this.comboBoxDeyWeek);
            this.groupBox1.Controls.Add(this.labelTimeTraining);
            this.groupBox1.Location = new System.Drawing.Point(10, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "День недели и время тренировки";
            // 
            // labelDeyWeek
            // 
            this.labelDeyWeek.AutoSize = true;
            this.labelDeyWeek.Location = new System.Drawing.Point(7, 31);
            this.labelDeyWeek.Name = "labelDeyWeek";
            this.labelDeyWeek.Size = new System.Drawing.Size(76, 13);
            this.labelDeyWeek.TabIndex = 0;
            this.labelDeyWeek.Text = "День недели:";
            // 
            // comboBoxTimeTraining
            // 
            this.comboBoxTimeTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeTraining.FormattingEnabled = true;
            this.comboBoxTimeTraining.Location = new System.Drawing.Point(112, 55);
            this.comboBoxTimeTraining.Name = "comboBoxTimeTraining";
            this.comboBoxTimeTraining.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTimeTraining.TabIndex = 3;
            // 
            // comboBoxDeyWeek
            // 
            this.comboBoxDeyWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeyWeek.FormattingEnabled = true;
            this.comboBoxDeyWeek.Location = new System.Drawing.Point(112, 28);
            this.comboBoxDeyWeek.Name = "comboBoxDeyWeek";
            this.comboBoxDeyWeek.Size = new System.Drawing.Size(138, 21);
            this.comboBoxDeyWeek.TabIndex = 1;
            // 
            // labelTimeTraining
            // 
            this.labelTimeTraining.AutoSize = true;
            this.labelTimeTraining.Location = new System.Drawing.Point(7, 58);
            this.labelTimeTraining.Name = "labelTimeTraining";
            this.labelTimeTraining.Size = new System.Drawing.Size(105, 13);
            this.labelTimeTraining.TabIndex = 2;
            this.labelTimeTraining.Text = "Время тренировки:";
            // 
            // textBoxSexChild
            // 
            this.textBoxSexChild.Enabled = false;
            this.textBoxSexChild.Location = new System.Drawing.Point(162, 44);
            this.textBoxSexChild.Name = "textBoxSexChild";
            this.textBoxSexChild.Size = new System.Drawing.Size(256, 20);
            this.textBoxSexChild.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол ребенка:";
            // 
            // textBoxFullNameChild
            // 
            this.textBoxFullNameChild.Enabled = false;
            this.textBoxFullNameChild.Location = new System.Drawing.Point(162, 18);
            this.textBoxFullNameChild.Name = "textBoxFullNameChild";
            this.textBoxFullNameChild.Size = new System.Drawing.Size(256, 20);
            this.textBoxFullNameChild.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО ребенка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCommentsChild);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxChildSportCatigory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxAgeChild);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxSexChild);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFullNameChild);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ребенок";
            // 
            // groupBoxTrainings
            // 
            this.groupBoxTrainings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTrainings.Controls.Add(this.buttonDeleteTraining);
            this.groupBoxTrainings.Controls.Add(this.dataGridView);
            this.groupBoxTrainings.Enabled = false;
            this.groupBoxTrainings.Location = new System.Drawing.Point(6, 206);
            this.groupBoxTrainings.Name = "groupBoxTrainings";
            this.groupBoxTrainings.Size = new System.Drawing.Size(964, 211);
            this.groupBoxTrainings.TabIndex = 10;
            this.groupBoxTrainings.TabStop = false;
            this.groupBoxTrainings.Text = "Текущие тенировки";
            // 
            // RecordChildOnTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 423);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBoxNewTraining);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTrainings);
            this.Name = "RecordChildOnTrainingForm";
            this.Text = "Запись ребенка на тренировку";
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBoxNewTraining.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTrainings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteTraining;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonNewTraining;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxCommentsChild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxChildSportCatigory;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.ComboBox comboBoxTypeTraining;
        private System.Windows.Forms.ComboBox comboBoxCoach;
        private System.Windows.Forms.Label labelTypeTraining;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAgeChild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxNewTraining;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDeyWeek;
        private System.Windows.Forms.ComboBox comboBoxTimeTraining;
        private System.Windows.Forms.ComboBox comboBoxDeyWeek;
        private System.Windows.Forms.Label labelTimeTraining;
        private System.Windows.Forms.TextBox textBoxSexChild;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFullNameChild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxTrainings;
    }
}