namespace ClimbUp
{
    partial class ChangeInfoChildForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxChildSportCatigory = new System.Windows.Forms.ComboBox();
            this.comboBoxSexChild = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAgeChild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFullNameChild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCommentsChild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonCancelChange = new System.Windows.Forms.Button();
            this.buttonEditData = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(611, 223);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxChildSportCatigory);
            this.groupBox1.Controls.Add(this.comboBoxSexChild);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxAgeChild);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFullNameChild);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о ребенке";
            // 
            // comboBoxChildSportCatigory
            // 
            this.comboBoxChildSportCatigory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildSportCatigory.Enabled = false;
            this.comboBoxChildSportCatigory.FormattingEnabled = true;
            this.comboBoxChildSportCatigory.Items.AddRange(new object[] {
            "",
            "Третий",
            "Второй",
            "Первый",
            "КМС",
            "МС"});
            this.comboBoxChildSportCatigory.Location = new System.Drawing.Point(180, 107);
            this.comboBoxChildSportCatigory.Name = "comboBoxChildSportCatigory";
            this.comboBoxChildSportCatigory.Size = new System.Drawing.Size(252, 21);
            this.comboBoxChildSportCatigory.TabIndex = 13;
            // 
            // comboBoxSexChild
            // 
            this.comboBoxSexChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexChild.Enabled = false;
            this.comboBoxSexChild.FormattingEnabled = true;
            this.comboBoxSexChild.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxSexChild.Location = new System.Drawing.Point(180, 55);
            this.comboBoxSexChild.Name = "comboBoxSexChild";
            this.comboBoxSexChild.Size = new System.Drawing.Size(252, 21);
            this.comboBoxSexChild.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Спортивный разряд ребенка:";
            // 
            // textBoxAgeChild
            // 
            this.textBoxAgeChild.Enabled = false;
            this.textBoxAgeChild.Location = new System.Drawing.Point(180, 81);
            this.textBoxAgeChild.Name = "textBoxAgeChild";
            this.textBoxAgeChild.Size = new System.Drawing.Size(60, 20);
            this.textBoxAgeChild.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Возраст ребенка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пол ребенка:";
            // 
            // textBoxFullNameChild
            // 
            this.textBoxFullNameChild.Enabled = false;
            this.textBoxFullNameChild.Location = new System.Drawing.Point(180, 29);
            this.textBoxFullNameChild.Name = "textBoxFullNameChild";
            this.textBoxFullNameChild.Size = new System.Drawing.Size(252, 20);
            this.textBoxFullNameChild.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО ребенка:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCommentsChild);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(598, 69);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // textBoxCommentsChild
            // 
            this.textBoxCommentsChild.Enabled = false;
            this.textBoxCommentsChild.Location = new System.Drawing.Point(180, 12);
            this.textBoxCommentsChild.Multiline = true;
            this.textBoxCommentsChild.Name = "textBoxCommentsChild";
            this.textBoxCommentsChild.Size = new System.Drawing.Size(412, 50);
            this.textBoxCommentsChild.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Комментарии:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSaveData);
            this.groupBox2.Controls.Add(this.buttonCancelChange);
            this.groupBox2.Controls.Add(this.buttonEditData);
            this.groupBox2.Location = new System.Drawing.Point(450, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Измение данных ребенка";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Enabled = false;
            this.buttonSaveData.Location = new System.Drawing.Point(6, 55);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(142, 21);
            this.buttonSaveData.TabIndex = 2;
            this.buttonSaveData.Text = "Сохранить изменения";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonCancelChange
            // 
            this.buttonCancelChange.Enabled = false;
            this.buttonCancelChange.Location = new System.Drawing.Point(6, 107);
            this.buttonCancelChange.Name = "buttonCancelChange";
            this.buttonCancelChange.Size = new System.Drawing.Size(142, 21);
            this.buttonCancelChange.TabIndex = 1;
            this.buttonCancelChange.Text = "Отменить изменения";
            this.buttonCancelChange.UseVisualStyleBackColor = true;
            this.buttonCancelChange.Click += new System.EventHandler(this.buttonCancelChange_Click);
            // 
            // buttonEditData
            // 
            this.buttonEditData.Location = new System.Drawing.Point(6, 29);
            this.buttonEditData.Name = "buttonEditData";
            this.buttonEditData.Size = new System.Drawing.Size(142, 20);
            this.buttonEditData.TabIndex = 0;
            this.buttonEditData.Text = "Изменить данные";
            this.buttonEditData.UseVisualStyleBackColor = true;
            this.buttonEditData.Click += new System.EventHandler(this.buttonEditData_Click);
            // 
            // ChangeInfoChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 233);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeInfoChildForm";
            this.Text = "Изменить данные ребенка";
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxChildSportCatigory;
        private System.Windows.Forms.ComboBox comboBoxSexChild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAgeChild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFullNameChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCommentsChild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonCancelChange;
        private System.Windows.Forms.Button buttonEditData;
    }
}