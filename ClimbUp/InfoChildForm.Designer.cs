namespace ClimbUp
{
    partial class InfoChildForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRecordOnTrainingChild = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTraining = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.textBoxIdChild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCommentsChild = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxChildSportCatigory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonChangeChildInfo = new System.Windows.Forms.Button();
            this.textBoxAgeChild = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSexChild = new System.Windows.Forms.TextBox();
            this.textBoxFullNameChild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraining)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 19);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(167, 29);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRecordOnTrainingChild
            // 
            this.buttonRecordOnTrainingChild.Location = new System.Drawing.Point(6, 54);
            this.buttonRecordOnTrainingChild.Name = "buttonRecordOnTrainingChild";
            this.buttonRecordOnTrainingChild.Size = new System.Drawing.Size(167, 29);
            this.buttonRecordOnTrainingChild.TabIndex = 6;
            this.buttonRecordOnTrainingChild.Text = "Запись на тренировку";
            this.buttonRecordOnTrainingChild.UseVisualStyleBackColor = true;
            this.buttonRecordOnTrainingChild.Click += new System.EventHandler(this.buttonRecordOnTrainingChild_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.37572F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.62428F));
            this.tableLayoutPanel.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 258);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(859, 206);
            this.tableLayoutPanel.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewTraining);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(478, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 200);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тренировки";
            // 
            // dataGridViewTraining
            // 
            this.dataGridViewTraining.AllowUserToAddRows = false;
            this.dataGridViewTraining.AllowUserToDeleteRows = false;
            this.dataGridViewTraining.AllowUserToOrderColumns = true;
            this.dataGridViewTraining.AllowUserToResizeRows = false;
            this.dataGridViewTraining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTraining.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTraining.Name = "dataGridViewTraining";
            this.dataGridViewTraining.ReadOnly = true;
            this.dataGridViewTraining.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTraining.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTraining.RowHeadersWidth = 10;
            this.dataGridViewTraining.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTraining.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTraining.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTraining.RowTemplate.Height = 18;
            this.dataGridViewTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTraining.Size = new System.Drawing.Size(372, 181);
            this.dataGridViewTraining.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewClients);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToOrderColumns = true;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClients.RowHeadersWidth = 10;
            this.dataGridViewClients.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewClients.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewClients.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.RowTemplate.Height = 18;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(463, 181);
            this.dataGridViewClients.TabIndex = 4;
            this.dataGridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellDoubleClick);
            // 
            // textBoxIdChild
            // 
            this.textBoxIdChild.Enabled = false;
            this.textBoxIdChild.Location = new System.Drawing.Point(161, 22);
            this.textBoxIdChild.Name = "textBoxIdChild";
            this.textBoxIdChild.Size = new System.Drawing.Size(308, 20);
            this.textBoxIdChild.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID ребенка:";
            // 
            // textBoxCommentsChild
            // 
            this.textBoxCommentsChild.Enabled = false;
            this.textBoxCommentsChild.Location = new System.Drawing.Point(161, 152);
            this.textBoxCommentsChild.Multiline = true;
            this.textBoxCommentsChild.Name = "textBoxCommentsChild";
            this.textBoxCommentsChild.Size = new System.Drawing.Size(308, 73);
            this.textBoxCommentsChild.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Коменнтарии:";
            // 
            // textBoxChildSportCatigory
            // 
            this.textBoxChildSportCatigory.Enabled = false;
            this.textBoxChildSportCatigory.Location = new System.Drawing.Point(161, 126);
            this.textBoxChildSportCatigory.Name = "textBoxChildSportCatigory";
            this.textBoxChildSportCatigory.Size = new System.Drawing.Size(308, 20);
            this.textBoxChildSportCatigory.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Спортивный разряд ребенка:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.buttonChangeChildInfo);
            this.groupBox3.Controls.Add(this.buttonRecordOnTrainingChild);
            this.groupBox3.Location = new System.Drawing.Point(484, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 259);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия";
            // 
            // buttonChangeChildInfo
            // 
            this.buttonChangeChildInfo.Location = new System.Drawing.Point(6, 89);
            this.buttonChangeChildInfo.Name = "buttonChangeChildInfo";
            this.buttonChangeChildInfo.Size = new System.Drawing.Size(167, 29);
            this.buttonChangeChildInfo.TabIndex = 7;
            this.buttonChangeChildInfo.Text = "Изменить данные ребенка";
            this.buttonChangeChildInfo.UseVisualStyleBackColor = true;
            this.buttonChangeChildInfo.Click += new System.EventHandler(this.buttonChangeChildInfo_Click);
            // 
            // textBoxAgeChild
            // 
            this.textBoxAgeChild.Enabled = false;
            this.textBoxAgeChild.Location = new System.Drawing.Point(161, 100);
            this.textBoxAgeChild.Name = "textBoxAgeChild";
            this.textBoxAgeChild.Size = new System.Drawing.Size(308, 20);
            this.textBoxAgeChild.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Возраст ребенка:";
            // 
            // textBoxSexChild
            // 
            this.textBoxSexChild.Enabled = false;
            this.textBoxSexChild.Location = new System.Drawing.Point(161, 74);
            this.textBoxSexChild.Name = "textBoxSexChild";
            this.textBoxSexChild.Size = new System.Drawing.Size(308, 20);
            this.textBoxSexChild.TabIndex = 4;
            // 
            // textBoxFullNameChild
            // 
            this.textBoxFullNameChild.Enabled = false;
            this.textBoxFullNameChild.Location = new System.Drawing.Point(161, 48);
            this.textBoxFullNameChild.Name = "textBoxFullNameChild";
            this.textBoxFullNameChild.Size = new System.Drawing.Size(308, 20);
            this.textBoxFullNameChild.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО ребенка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIdChild);
            this.groupBox2.Controls.Add(this.label1);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 259);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ребенок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол ребенка:";
            // 
            // InfoChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 465);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "InfoChildForm";
            this.Text = "Информация о ребенке";
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraining)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRecordOnTrainingChild;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewTraining;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TextBox textBoxIdChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCommentsChild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxChildSportCatigory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonChangeChildInfo;
        private System.Windows.Forms.TextBox textBoxAgeChild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSexChild;
        private System.Windows.Forms.TextBox textBoxFullNameChild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}