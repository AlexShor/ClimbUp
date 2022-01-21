namespace ClimbUp
{
    partial class AddClientForm
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
            this.textBoxClientFullName = new System.Windows.Forms.TextBox();
            this.labelClientFullName = new System.Windows.Forms.Label();
            this.labelClientPhoneNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxClientComment = new System.Windows.Forms.TextBox();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.comboBoxClientSportCatigory = new System.Windows.Forms.ComboBox();
            this.comboBoxClientSex = new System.Windows.Forms.ComboBox();
            this.labelClientSex = new System.Windows.Forms.Label();
            this.textBoxClientEMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxChild = new System.Windows.Forms.GroupBox();
            this.comboBoxChildSportCatigory = new System.Windows.Forms.ComboBox();
            this.comboBoxChildSex = new System.Windows.Forms.ComboBox();
            this.labelChildSex = new System.Windows.Forms.Label();
            this.buttonAddChild = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelChildFullName = new System.Windows.Forms.Label();
            this.textBoxChildComment = new System.Windows.Forms.TextBox();
            this.textBoxChildFullName = new System.Windows.Forms.TextBox();
            this.textBoxChildAge = new System.Windows.Forms.TextBox();
            this.labelChildAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxQuestionChildren = new System.Windows.Forms.GroupBox();
            this.groupBoxAmountChildren = new System.Windows.Forms.GroupBox();
            this.comboBoxAmountChildren = new System.Windows.Forms.ComboBox();
            this.buttonAddChildren = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAddChild = new System.Windows.Forms.CheckBox();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxChild.SuspendLayout();
            this.groupBoxQuestionChildren.SuspendLayout();
            this.groupBoxAmountChildren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxClientFullName
            // 
            this.textBoxClientFullName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxClientFullName.Location = new System.Drawing.Point(119, 30);
            this.textBoxClientFullName.Name = "textBoxClientFullName";
            this.textBoxClientFullName.Size = new System.Drawing.Size(196, 20);
            this.textBoxClientFullName.TabIndex = 0;
            this.textBoxClientFullName.Click += new System.EventHandler(this.textBoxClientFullName_Click);
            // 
            // labelClientFullName
            // 
            this.labelClientFullName.AutoSize = true;
            this.labelClientFullName.Location = new System.Drawing.Point(6, 33);
            this.labelClientFullName.Name = "labelClientFullName";
            this.labelClientFullName.Size = new System.Drawing.Size(81, 13);
            this.labelClientFullName.TabIndex = 1;
            this.labelClientFullName.Text = "ФИО клиента:";
            // 
            // labelClientPhoneNumber
            // 
            this.labelClientPhoneNumber.AutoSize = true;
            this.labelClientPhoneNumber.Location = new System.Drawing.Point(6, 59);
            this.labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            this.labelClientPhoneNumber.Size = new System.Drawing.Size(96, 13);
            this.labelClientPhoneNumber.TabIndex = 2;
            this.labelClientPhoneNumber.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Коментарии:";
            // 
            // textBoxClientPhoneNumber
            // 
            this.textBoxClientPhoneNumber.Location = new System.Drawing.Point(119, 56);
            this.textBoxClientPhoneNumber.Name = "textBoxClientPhoneNumber";
            this.textBoxClientPhoneNumber.Size = new System.Drawing.Size(196, 20);
            this.textBoxClientPhoneNumber.TabIndex = 4;
            this.textBoxClientPhoneNumber.Click += new System.EventHandler(this.textBoxClientPhoneNumber_Click);
            // 
            // textBoxClientComment
            // 
            this.textBoxClientComment.Location = new System.Drawing.Point(395, 56);
            this.textBoxClientComment.Multiline = true;
            this.textBoxClientComment.Name = "textBoxClientComment";
            this.textBoxClientComment.Size = new System.Drawing.Size(196, 72);
            this.textBoxClientComment.TabIndex = 5;
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.buttonAddClient);
            this.groupBoxClient.Controls.Add(this.comboBoxClientSportCatigory);
            this.groupBoxClient.Controls.Add(this.comboBoxClientSex);
            this.groupBoxClient.Controls.Add(this.labelClientSex);
            this.groupBoxClient.Controls.Add(this.textBoxClientEMail);
            this.groupBoxClient.Controls.Add(this.label8);
            this.groupBoxClient.Controls.Add(this.label7);
            this.groupBoxClient.Controls.Add(this.labelClientFullName);
            this.groupBoxClient.Controls.Add(this.textBoxClientComment);
            this.groupBoxClient.Controls.Add(this.textBoxClientFullName);
            this.groupBoxClient.Controls.Add(this.textBoxClientPhoneNumber);
            this.groupBoxClient.Controls.Add(this.labelClientPhoneNumber);
            this.groupBoxClient.Controls.Add(this.label3);
            this.groupBoxClient.Location = new System.Drawing.Point(4, 35);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(601, 181);
            this.groupBoxClient.TabIndex = 6;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Новый клиент";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(474, 134);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(117, 24);
            this.buttonAddClient.TabIndex = 8;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // comboBoxClientSportCatigory
            // 
            this.comboBoxClientSportCatigory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientSportCatigory.FormattingEnabled = true;
            this.comboBoxClientSportCatigory.Items.AddRange(new object[] {
            "",
            "Третий",
            "Второй",
            "Первый",
            "КМС",
            "МС",
            "МСМК"});
            this.comboBoxClientSportCatigory.Location = new System.Drawing.Point(119, 108);
            this.comboBoxClientSportCatigory.Name = "comboBoxClientSportCatigory";
            this.comboBoxClientSportCatigory.Size = new System.Drawing.Size(196, 21);
            this.comboBoxClientSportCatigory.TabIndex = 11;
            // 
            // comboBoxClientSex
            // 
            this.comboBoxClientSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientSex.FormattingEnabled = true;
            this.comboBoxClientSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxClientSex.Location = new System.Drawing.Point(395, 29);
            this.comboBoxClientSex.Name = "comboBoxClientSex";
            this.comboBoxClientSex.Size = new System.Drawing.Size(95, 21);
            this.comboBoxClientSex.TabIndex = 4;
            this.comboBoxClientSex.Click += new System.EventHandler(this.comboBoxClientSex_Click);
            // 
            // labelClientSex
            // 
            this.labelClientSex.AutoSize = true;
            this.labelClientSex.Location = new System.Drawing.Point(321, 33);
            this.labelClientSex.Name = "labelClientSex";
            this.labelClientSex.Size = new System.Drawing.Size(74, 13);
            this.labelClientSex.TabIndex = 10;
            this.labelClientSex.Text = "Пол клиента:";
            // 
            // textBoxClientEMail
            // 
            this.textBoxClientEMail.Location = new System.Drawing.Point(119, 82);
            this.textBoxClientEMail.Name = "textBoxClientEMail";
            this.textBoxClientEMail.Size = new System.Drawing.Size(196, 20);
            this.textBoxClientEMail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "E-Mail клиента:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Спортивный разряд:";
            // 
            // groupBoxChild
            // 
            this.groupBoxChild.Controls.Add(this.comboBoxChildSportCatigory);
            this.groupBoxChild.Controls.Add(this.comboBoxChildSex);
            this.groupBoxChild.Controls.Add(this.labelChildSex);
            this.groupBoxChild.Controls.Add(this.buttonAddChild);
            this.groupBoxChild.Controls.Add(this.label9);
            this.groupBoxChild.Controls.Add(this.labelChildFullName);
            this.groupBoxChild.Controls.Add(this.textBoxChildComment);
            this.groupBoxChild.Controls.Add(this.textBoxChildFullName);
            this.groupBoxChild.Controls.Add(this.textBoxChildAge);
            this.groupBoxChild.Controls.Add(this.labelChildAge);
            this.groupBoxChild.Controls.Add(this.label6);
            this.groupBoxChild.Location = new System.Drawing.Point(4, 276);
            this.groupBoxChild.Name = "groupBoxChild";
            this.groupBoxChild.Size = new System.Drawing.Size(601, 149);
            this.groupBoxChild.TabIndex = 7;
            this.groupBoxChild.TabStop = false;
            this.groupBoxChild.Text = "Ребенок";
            this.groupBoxChild.Visible = false;
            // 
            // comboBoxChildSportCatigory
            // 
            this.comboBoxChildSportCatigory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildSportCatigory.FormattingEnabled = true;
            this.comboBoxChildSportCatigory.Items.AddRange(new object[] {
            "",
            "Третий",
            "Второй",
            "Первый",
            "КМС",
            "МС",
            "МСМК"});
            this.comboBoxChildSportCatigory.Location = new System.Drawing.Point(119, 82);
            this.comboBoxChildSportCatigory.Name = "comboBoxChildSportCatigory";
            this.comboBoxChildSportCatigory.Size = new System.Drawing.Size(196, 21);
            this.comboBoxChildSportCatigory.TabIndex = 14;
            // 
            // comboBoxChildSex
            // 
            this.comboBoxChildSex.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxChildSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildSex.FormattingEnabled = true;
            this.comboBoxChildSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxChildSex.Location = new System.Drawing.Point(395, 30);
            this.comboBoxChildSex.Name = "comboBoxChildSex";
            this.comboBoxChildSex.Size = new System.Drawing.Size(95, 21);
            this.comboBoxChildSex.TabIndex = 11;
            this.comboBoxChildSex.Click += new System.EventHandler(this.comboBoxChildSex_Click);
            // 
            // labelChildSex
            // 
            this.labelChildSex.AutoSize = true;
            this.labelChildSex.Location = new System.Drawing.Point(321, 33);
            this.labelChildSex.Name = "labelChildSex";
            this.labelChildSex.Size = new System.Drawing.Size(75, 13);
            this.labelChildSex.TabIndex = 11;
            this.labelChildSex.Text = "Пол ребенка:";
            // 
            // buttonAddChild
            // 
            this.buttonAddChild.Location = new System.Drawing.Point(474, 108);
            this.buttonAddChild.Name = "buttonAddChild";
            this.buttonAddChild.Size = new System.Drawing.Size(117, 23);
            this.buttonAddChild.TabIndex = 10;
            this.buttonAddChild.Text = "Добавить ребенка";
            this.buttonAddChild.UseVisualStyleBackColor = true;
            this.buttonAddChild.Click += new System.EventHandler(this.buttonAddChild_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Спортивный разряд:";
            // 
            // labelChildFullName
            // 
            this.labelChildFullName.AutoSize = true;
            this.labelChildFullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelChildFullName.Location = new System.Drawing.Point(6, 33);
            this.labelChildFullName.Name = "labelChildFullName";
            this.labelChildFullName.Size = new System.Drawing.Size(82, 13);
            this.labelChildFullName.TabIndex = 1;
            this.labelChildFullName.Text = "ФИО ребенка:";
            // 
            // textBoxChildComment
            // 
            this.textBoxChildComment.Location = new System.Drawing.Point(395, 56);
            this.textBoxChildComment.Multiline = true;
            this.textBoxChildComment.Name = "textBoxChildComment";
            this.textBoxChildComment.Size = new System.Drawing.Size(196, 46);
            this.textBoxChildComment.TabIndex = 5;
            // 
            // textBoxChildFullName
            // 
            this.textBoxChildFullName.Location = new System.Drawing.Point(119, 30);
            this.textBoxChildFullName.Name = "textBoxChildFullName";
            this.textBoxChildFullName.Size = new System.Drawing.Size(196, 20);
            this.textBoxChildFullName.TabIndex = 0;
            this.textBoxChildFullName.Click += new System.EventHandler(this.textBoxChildFullName_Click);
            // 
            // textBoxChildAge
            // 
            this.textBoxChildAge.Location = new System.Drawing.Point(119, 56);
            this.textBoxChildAge.Name = "textBoxChildAge";
            this.textBoxChildAge.Size = new System.Drawing.Size(196, 20);
            this.textBoxChildAge.TabIndex = 4;
            this.textBoxChildAge.Click += new System.EventHandler(this.textBoxChildAge_Click);
            // 
            // labelChildAge
            // 
            this.labelChildAge.AutoSize = true;
            this.labelChildAge.Location = new System.Drawing.Point(6, 59);
            this.labelChildAge.Name = "labelChildAge";
            this.labelChildAge.Size = new System.Drawing.Size(97, 13);
            this.labelChildAge.TabIndex = 2;
            this.labelChildAge.Text = "Возраст ребенка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Коментарии:";
            // 
            // groupBoxQuestionChildren
            // 
            this.groupBoxQuestionChildren.Controls.Add(this.groupBoxAmountChildren);
            this.groupBoxQuestionChildren.Controls.Add(this.checkBoxAddChild);
            this.groupBoxQuestionChildren.Location = new System.Drawing.Point(4, 216);
            this.groupBoxQuestionChildren.Name = "groupBoxQuestionChildren";
            this.groupBoxQuestionChildren.Size = new System.Drawing.Size(601, 60);
            this.groupBoxQuestionChildren.TabIndex = 9;
            this.groupBoxQuestionChildren.TabStop = false;
            this.groupBoxQuestionChildren.Visible = false;
            // 
            // groupBoxAmountChildren
            // 
            this.groupBoxAmountChildren.Controls.Add(this.comboBoxAmountChildren);
            this.groupBoxAmountChildren.Controls.Add(this.buttonAddChildren);
            this.groupBoxAmountChildren.Controls.Add(this.label10);
            this.groupBoxAmountChildren.Location = new System.Drawing.Point(166, 8);
            this.groupBoxAmountChildren.Name = "groupBoxAmountChildren";
            this.groupBoxAmountChildren.Size = new System.Drawing.Size(324, 44);
            this.groupBoxAmountChildren.TabIndex = 10;
            this.groupBoxAmountChildren.TabStop = false;
            this.groupBoxAmountChildren.Visible = false;
            // 
            // comboBoxAmountChildren
            // 
            this.comboBoxAmountChildren.FormattingEnabled = true;
            this.comboBoxAmountChildren.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxAmountChildren.Location = new System.Drawing.Point(113, 13);
            this.comboBoxAmountChildren.Name = "comboBoxAmountChildren";
            this.comboBoxAmountChildren.Size = new System.Drawing.Size(47, 21);
            this.comboBoxAmountChildren.TabIndex = 3;
            this.comboBoxAmountChildren.Text = "1";
            // 
            // buttonAddChildren
            // 
            this.buttonAddChildren.Location = new System.Drawing.Point(162, 12);
            this.buttonAddChildren.Name = "buttonAddChildren";
            this.buttonAddChildren.Size = new System.Drawing.Size(88, 22);
            this.buttonAddChildren.TabIndex = 2;
            this.buttonAddChildren.Text = "Добавить";
            this.buttonAddChildren.UseVisualStyleBackColor = true;
            this.buttonAddChildren.Click += new System.EventHandler(this.buttonAddChildren_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Количество детей:";
            // 
            // checkBoxAddChild
            // 
            this.checkBoxAddChild.AutoSize = true;
            this.checkBoxAddChild.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAddChild.Location = new System.Drawing.Point(9, 23);
            this.checkBoxAddChild.Name = "checkBoxAddChild";
            this.checkBoxAddChild.Size = new System.Drawing.Size(127, 17);
            this.checkBoxAddChild.TabIndex = 9;
            this.checkBoxAddChild.Text = "Добавить ребенка?";
            this.checkBoxAddChild.UseVisualStyleBackColor = true;
            this.checkBoxAddChild.CheckedChanged += new System.EventHandler(this.checkBoxAddChild_CheckedChanged);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(6, 11);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(136, 21);
            this.buttonNewClient.TabIndex = 11;
            this.buttonNewClient.Text = "Новый клиент";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNewClient);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 37);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxQuestionChildren);
            this.Controls.Add(this.groupBoxChild);
            this.Controls.Add(this.groupBoxClient);
            this.Name = "AddClientForm";
            this.Text = "Добавить клиента";
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxChild.ResumeLayout(false);
            this.groupBoxChild.PerformLayout();
            this.groupBoxQuestionChildren.ResumeLayout(false);
            this.groupBoxQuestionChildren.PerformLayout();
            this.groupBoxAmountChildren.ResumeLayout(false);
            this.groupBoxAmountChildren.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClientFullName;
        private System.Windows.Forms.Label labelClientFullName;
        private System.Windows.Forms.Label labelClientPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientPhoneNumber;
        private System.Windows.Forms.TextBox textBoxClientComment;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.TextBox textBoxClientEMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxChild;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelChildFullName;
        private System.Windows.Forms.TextBox textBoxChildComment;
        private System.Windows.Forms.TextBox textBoxChildFullName;
        private System.Windows.Forms.TextBox textBoxChildAge;
        private System.Windows.Forms.Label labelChildAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.GroupBox groupBoxQuestionChildren;
        private System.Windows.Forms.CheckBox checkBoxAddChild;
        private System.Windows.Forms.GroupBox groupBoxAmountChildren;
        private System.Windows.Forms.Button buttonAddChildren;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAmountChildren;
        private System.Windows.Forms.Button buttonAddChild;
        private System.Windows.Forms.ComboBox comboBoxClientSex;
        private System.Windows.Forms.Label labelClientSex;
        private System.Windows.Forms.ComboBox comboBoxChildSex;
        private System.Windows.Forms.Label labelChildSex;
        private System.Windows.Forms.ComboBox comboBoxClientSportCatigory;
        private System.Windows.Forms.ComboBox comboBoxChildSportCatigory;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}