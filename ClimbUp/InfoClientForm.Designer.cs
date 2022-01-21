namespace ClimbUp
{
    partial class InfoClientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChildren = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonChangeClientInfo = new System.Windows.Forms.Button();
            this.buttonRecordOnTrainingClient = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTraining = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraining)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewChildren);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дети";
            // 
            // dataGridViewChildren
            // 
            this.dataGridViewChildren.AllowUserToAddRows = false;
            this.dataGridViewChildren.AllowUserToDeleteRows = false;
            this.dataGridViewChildren.AllowUserToOrderColumns = true;
            this.dataGridViewChildren.AllowUserToResizeRows = false;
            this.dataGridViewChildren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChildren.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewChildren.Name = "dataGridViewChildren";
            this.dataGridViewChildren.ReadOnly = true;
            this.dataGridViewChildren.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChildren.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChildren.RowHeadersWidth = 10;
            this.dataGridViewChildren.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewChildren.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewChildren.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewChildren.RowTemplate.Height = 18;
            this.dataGridViewChildren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChildren.Size = new System.Drawing.Size(466, 181);
            this.dataGridViewChildren.TabIndex = 4;
            this.dataGridViewChildren.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChildren_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIdClient);
            this.groupBox2.Controls.Add(this.label1);
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
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 259);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиент";
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Enabled = false;
            this.textBoxIdClient.Location = new System.Drawing.Point(161, 22);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(308, 20);
            this.textBoxIdClient.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID клиента:";
            // 
            // textBoxCommentsClient
            // 
            this.textBoxCommentsClient.Enabled = false;
            this.textBoxCommentsClient.Location = new System.Drawing.Point(161, 178);
            this.textBoxCommentsClient.Multiline = true;
            this.textBoxCommentsClient.Name = "textBoxCommentsClient";
            this.textBoxCommentsClient.Size = new System.Drawing.Size(308, 73);
            this.textBoxCommentsClient.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Коменнтарии:";
            // 
            // textBoxClientSportCatigory
            // 
            this.textBoxClientSportCatigory.Enabled = false;
            this.textBoxClientSportCatigory.Location = new System.Drawing.Point(161, 152);
            this.textBoxClientSportCatigory.Name = "textBoxClientSportCatigory";
            this.textBoxClientSportCatigory.Size = new System.Drawing.Size(308, 20);
            this.textBoxClientSportCatigory.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Спортивный разряд клиента:";
            // 
            // textBoxEMailClient
            // 
            this.textBoxEMailClient.Enabled = false;
            this.textBoxEMailClient.Location = new System.Drawing.Point(161, 126);
            this.textBoxEMailClient.Name = "textBoxEMailClient";
            this.textBoxEMailClient.Size = new System.Drawing.Size(308, 20);
            this.textBoxEMailClient.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "E-Mail клиента:";
            // 
            // textBoxPhoneNumberClient
            // 
            this.textBoxPhoneNumberClient.Enabled = false;
            this.textBoxPhoneNumberClient.Location = new System.Drawing.Point(161, 100);
            this.textBoxPhoneNumberClient.Name = "textBoxPhoneNumberClient";
            this.textBoxPhoneNumberClient.Size = new System.Drawing.Size(308, 20);
            this.textBoxPhoneNumberClient.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер телефона клиента:";
            // 
            // textBoxSexClient
            // 
            this.textBoxSexClient.Enabled = false;
            this.textBoxSexClient.Location = new System.Drawing.Point(161, 74);
            this.textBoxSexClient.Name = "textBoxSexClient";
            this.textBoxSexClient.Size = new System.Drawing.Size(308, 20);
            this.textBoxSexClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол клиента:";
            // 
            // textBoxFullNameClient
            // 
            this.textBoxFullNameClient.Enabled = false;
            this.textBoxFullNameClient.Location = new System.Drawing.Point(161, 48);
            this.textBoxFullNameClient.Name = "textBoxFullNameClient";
            this.textBoxFullNameClient.Size = new System.Drawing.Size(308, 20);
            this.textBoxFullNameClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО клиента:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.buttonChangeClientInfo);
            this.groupBox3.Controls.Add(this.buttonRecordOnTrainingClient);
            this.groupBox3.Location = new System.Drawing.Point(486, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия";
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
            // buttonChangeClientInfo
            // 
            this.buttonChangeClientInfo.Location = new System.Drawing.Point(6, 89);
            this.buttonChangeClientInfo.Name = "buttonChangeClientInfo";
            this.buttonChangeClientInfo.Size = new System.Drawing.Size(167, 29);
            this.buttonChangeClientInfo.TabIndex = 7;
            this.buttonChangeClientInfo.Text = "Изменить данные клиента";
            this.buttonChangeClientInfo.UseVisualStyleBackColor = true;
            this.buttonChangeClientInfo.Click += new System.EventHandler(this.buttonChangeClientInfo_Click);
            // 
            // buttonRecordOnTrainingClient
            // 
            this.buttonRecordOnTrainingClient.Location = new System.Drawing.Point(6, 54);
            this.buttonRecordOnTrainingClient.Name = "buttonRecordOnTrainingClient";
            this.buttonRecordOnTrainingClient.Size = new System.Drawing.Size(167, 29);
            this.buttonRecordOnTrainingClient.TabIndex = 6;
            this.buttonRecordOnTrainingClient.Text = "Запись на тренировку";
            this.buttonRecordOnTrainingClient.UseVisualStyleBackColor = true;
            this.buttonRecordOnTrainingClient.Click += new System.EventHandler(this.buttonRecordOnTrainingClient_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewTraining);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(481, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 200);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTraining.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTraining.RowHeadersWidth = 10;
            this.dataGridViewTraining.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTraining.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTraining.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTraining.RowTemplate.Height = 18;
            this.dataGridViewTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTraining.Size = new System.Drawing.Size(375, 181);
            this.dataGridViewTraining.TabIndex = 5;
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(5, 262);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(865, 206);
            this.tableLayoutPanel.TabIndex = 7;
            // 
            // InfoClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(873, 472);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "InfoClientForm";
            this.Text = "Информация о клиенте";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraining)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewChildren;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonRecordOnTrainingClient;
        private System.Windows.Forms.Button buttonChangeClientInfo;
        private System.Windows.Forms.Button buttonUpdate;
    }
}