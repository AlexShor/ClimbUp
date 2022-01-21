

namespace ClimbUp
{
    partial class ClientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClientSearch = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonExportToExcelClients = new System.Windows.Forms.Button();
            this.buttonChangeClientInfo = new System.Windows.Forms.Button();
            this.buttonRecordOnTrainingClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonExportToExcelChildren = new System.Windows.Forms.Button();
            this.buttonChangeChildInfo = new System.Windows.Forms.Button();
            this.buttonRecordOnTrainingChild = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSecondary = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxClientSearchBySex = new System.Windows.Forms.ComboBox();
            this.comboBoxClientSearchBySC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClientSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClientSearchText = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxChildAgeSearch = new System.Windows.Forms.TextBox();
            this.comboBoxChildSearchBySex = new System.Windows.Forms.ComboBox();
            this.comboBoxChildSearchBySC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonChildSearch = new System.Windows.Forms.Button();
            this.textBoxChildSearchText = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondary)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClientSearch
            // 
            this.buttonClientSearch.Location = new System.Drawing.Point(171, 44);
            this.buttonClientSearch.Name = "buttonClientSearch";
            this.buttonClientSearch.Size = new System.Drawing.Size(102, 20);
            this.buttonClientSearch.TabIndex = 1;
            this.buttonClientSearch.Text = "Поиск/Обновить";
            this.buttonClientSearch.UseVisualStyleBackColor = true;
            this.buttonClientSearch.Click += new System.EventHandler(this.buttonClientSearch_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 13);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.RowHeadersWidth = 10;
            this.dataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMain.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMain.RowTemplate.Height = 18;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(956, 162);
            this.dataGridViewMain.TabIndex = 2;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            this.dataGridViewMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellDoubleClick);
            this.dataGridViewMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewMain_DataBindingComplete);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 80);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1MinSize = 50;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(972, 399);
            this.splitContainer.SplitterDistance = 217;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonExportToExcelClients);
            this.groupBox4.Controls.Add(this.buttonChangeClientInfo);
            this.groupBox4.Controls.Add(this.buttonRecordOnTrainingClient);
            this.groupBox4.Location = new System.Drawing.Point(3, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(962, 39);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Клиенты";
            // 
            // buttonExportToExcelClients
            // 
            this.buttonExportToExcelClients.Location = new System.Drawing.Point(321, 13);
            this.buttonExportToExcelClients.Name = "buttonExportToExcelClients";
            this.buttonExportToExcelClients.Size = new System.Drawing.Size(113, 20);
            this.buttonExportToExcelClients.TabIndex = 7;
            this.buttonExportToExcelClients.Text = "Экспорт в Excel";
            this.buttonExportToExcelClients.UseVisualStyleBackColor = true;
            this.buttonExportToExcelClients.Click += new System.EventHandler(this.buttonExportToExcelClients_Click);
            // 
            // buttonChangeClientInfo
            // 
            this.buttonChangeClientInfo.Location = new System.Drawing.Point(148, 13);
            this.buttonChangeClientInfo.Name = "buttonChangeClientInfo";
            this.buttonChangeClientInfo.Size = new System.Drawing.Size(167, 20);
            this.buttonChangeClientInfo.TabIndex = 6;
            this.buttonChangeClientInfo.Text = "Изменить данные клиента";
            this.buttonChangeClientInfo.UseVisualStyleBackColor = true;
            this.buttonChangeClientInfo.Click += new System.EventHandler(this.buttonChangeClientInfo_Click);
            // 
            // buttonRecordOnTrainingClient
            // 
            this.buttonRecordOnTrainingClient.Location = new System.Drawing.Point(9, 13);
            this.buttonRecordOnTrainingClient.Name = "buttonRecordOnTrainingClient";
            this.buttonRecordOnTrainingClient.Size = new System.Drawing.Size(133, 20);
            this.buttonRecordOnTrainingClient.TabIndex = 5;
            this.buttonRecordOnTrainingClient.Text = "Запись на тренировку";
            this.buttonRecordOnTrainingClient.UseVisualStyleBackColor = true;
            this.buttonRecordOnTrainingClient.Click += new System.EventHandler(this.buttonRecordOnTrainingClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewMain);
            this.groupBox1.Location = new System.Drawing.Point(3, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(962, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.buttonExportToExcelChildren);
            this.groupBox5.Controls.Add(this.buttonChangeChildInfo);
            this.groupBox5.Controls.Add(this.buttonRecordOnTrainingChild);
            this.groupBox5.Location = new System.Drawing.Point(3, -1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(962, 39);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дети";
            // 
            // buttonExportToExcelChildren
            // 
            this.buttonExportToExcelChildren.Location = new System.Drawing.Point(321, 13);
            this.buttonExportToExcelChildren.Name = "buttonExportToExcelChildren";
            this.buttonExportToExcelChildren.Size = new System.Drawing.Size(113, 20);
            this.buttonExportToExcelChildren.TabIndex = 8;
            this.buttonExportToExcelChildren.Text = "Экспорт в Excel";
            this.buttonExportToExcelChildren.UseVisualStyleBackColor = true;
            this.buttonExportToExcelChildren.Click += new System.EventHandler(this.ButtonExportToExcelChildren_Click);
            // 
            // buttonChangeChildInfo
            // 
            this.buttonChangeChildInfo.Location = new System.Drawing.Point(148, 13);
            this.buttonChangeChildInfo.Name = "buttonChangeChildInfo";
            this.buttonChangeChildInfo.Size = new System.Drawing.Size(167, 20);
            this.buttonChangeChildInfo.TabIndex = 6;
            this.buttonChangeChildInfo.Text = "Изменить данные ребенка";
            this.buttonChangeChildInfo.UseVisualStyleBackColor = true;
            this.buttonChangeChildInfo.Click += new System.EventHandler(this.buttonChangeChildInfo_Click);
            // 
            // buttonRecordOnTrainingChild
            // 
            this.buttonRecordOnTrainingChild.Location = new System.Drawing.Point(9, 13);
            this.buttonRecordOnTrainingChild.Name = "buttonRecordOnTrainingChild";
            this.buttonRecordOnTrainingChild.Size = new System.Drawing.Size(133, 20);
            this.buttonRecordOnTrainingChild.TabIndex = 5;
            this.buttonRecordOnTrainingChild.Text = "Запись на тренировку";
            this.buttonRecordOnTrainingChild.UseVisualStyleBackColor = true;
            this.buttonRecordOnTrainingChild.Click += new System.EventHandler(this.buttonRecordOnTrainingChild_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewSecondary);
            this.groupBox2.Location = new System.Drawing.Point(3, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(962, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewSecondary
            // 
            this.dataGridViewSecondary.AllowUserToAddRows = false;
            this.dataGridViewSecondary.AllowUserToDeleteRows = false;
            this.dataGridViewSecondary.AllowUserToOrderColumns = true;
            this.dataGridViewSecondary.AllowUserToResizeRows = false;
            this.dataGridViewSecondary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSecondary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSecondary.Location = new System.Drawing.Point(3, 13);
            this.dataGridViewSecondary.Name = "dataGridViewSecondary";
            this.dataGridViewSecondary.ReadOnly = true;
            this.dataGridViewSecondary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSecondary.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSecondary.RowHeadersWidth = 10;
            this.dataGridViewSecondary.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewSecondary.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSecondary.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSecondary.RowTemplate.Height = 18;
            this.dataGridViewSecondary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSecondary.Size = new System.Drawing.Size(956, 104);
            this.dataGridViewSecondary.TabIndex = 3;
            this.dataGridViewSecondary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSecondary_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxClientSearchBySex);
            this.groupBox3.Controls.Add(this.comboBoxClientSearchBySC);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxClientSearchBy);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonClientSearch);
            this.groupBox3.Controls.Add(this.textBoxClientSearchText);
            this.groupBox3.Location = new System.Drawing.Point(5, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Критерии поиска клиента";
            // 
            // comboBoxClientSearchBySex
            // 
            this.comboBoxClientSearchBySex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientSearchBySex.FormattingEnabled = true;
            this.comboBoxClientSearchBySex.Items.AddRange(new object[] {
            "Всё",
            "Мужской",
            "Женский"});
            this.comboBoxClientSearchBySex.Location = new System.Drawing.Point(359, 45);
            this.comboBoxClientSearchBySex.Name = "comboBoxClientSearchBySex";
            this.comboBoxClientSearchBySex.Size = new System.Drawing.Size(111, 21);
            this.comboBoxClientSearchBySex.TabIndex = 8;
            // 
            // comboBoxClientSearchBySC
            // 
            this.comboBoxClientSearchBySC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientSearchBySC.FormattingEnabled = true;
            this.comboBoxClientSearchBySC.Items.AddRange(new object[] {
            "Всё",
            "Нет",
            "Есть",
            "Третий",
            "Второй",
            "Первый",
            "КМС",
            "МС",
            "МСМК"});
            this.comboBoxClientSearchBySC.Location = new System.Drawing.Point(359, 17);
            this.comboBoxClientSearchBySC.Name = "comboBoxClientSearchBySC";
            this.comboBoxClientSearchBySC.Size = new System.Drawing.Size(111, 21);
            this.comboBoxClientSearchBySC.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пол клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Спорт. разряд:";
            // 
            // comboBoxClientSearchBy
            // 
            this.comboBoxClientSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientSearchBy.FormattingEnabled = true;
            this.comboBoxClientSearchBy.Items.AddRange(new object[] {
            "ФИО",
            "Номер телефона",
            "E-Mail"});
            this.comboBoxClientSearchBy.Location = new System.Drawing.Point(65, 17);
            this.comboBoxClientSearchBy.Name = "comboBoxClientSearchBy";
            this.comboBoxClientSearchBy.Size = new System.Drawing.Size(208, 21);
            this.comboBoxClientSearchBy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск по:";
            // 
            // textBoxClientSearchText
            // 
            this.textBoxClientSearchText.Location = new System.Drawing.Point(9, 44);
            this.textBoxClientSearchText.Name = "textBoxClientSearchText";
            this.textBoxClientSearchText.Size = new System.Drawing.Size(156, 20);
            this.textBoxClientSearchText.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxChildAgeSearch);
            this.groupBox6.Controls.Add(this.comboBoxChildSearchBySex);
            this.groupBox6.Controls.Add(this.comboBoxChildSearchBySC);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.buttonChildSearch);
            this.groupBox6.Controls.Add(this.textBoxChildSearchText);
            this.groupBox6.Location = new System.Drawing.Point(487, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(476, 73);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Критерии поиска ребенка";
            // 
            // textBoxChildAgeSearch
            // 
            this.textBoxChildAgeSearch.Location = new System.Drawing.Point(109, 17);
            this.textBoxChildAgeSearch.Name = "textBoxChildAgeSearch";
            this.textBoxChildAgeSearch.Size = new System.Drawing.Size(162, 20);
            this.textBoxChildAgeSearch.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxChildAgeSearch, "Параметры поиска по возрасту:\r\n\"[Число]\" - поиск по конкретному возрасту.\r\n\"[Числ" +
        "о]-[Число]\" - поиск в диапазоне возрастов.");
            // 
            // comboBoxChildSearchBySex
            // 
            this.comboBoxChildSearchBySex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildSearchBySex.FormattingEnabled = true;
            this.comboBoxChildSearchBySex.Items.AddRange(new object[] {
            "Всё",
            "Мужской",
            "Женский"});
            this.comboBoxChildSearchBySex.Location = new System.Drawing.Point(359, 45);
            this.comboBoxChildSearchBySex.Name = "comboBoxChildSearchBySex";
            this.comboBoxChildSearchBySex.Size = new System.Drawing.Size(111, 21);
            this.comboBoxChildSearchBySex.TabIndex = 8;
            // 
            // comboBoxChildSearchBySC
            // 
            this.comboBoxChildSearchBySC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChildSearchBySC.FormattingEnabled = true;
            this.comboBoxChildSearchBySC.Items.AddRange(new object[] {
            "Всё",
            "Нет",
            "Есть",
            "Третий",
            "Второй",
            "Первый",
            "КМС",
            "МС"});
            this.comboBoxChildSearchBySC.Location = new System.Drawing.Point(359, 17);
            this.comboBoxChildSearchBySC.Name = "comboBoxChildSearchBySC";
            this.comboBoxChildSearchBySC.Size = new System.Drawing.Size(111, 21);
            this.comboBoxChildSearchBySC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пол ребенка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Спорт. разряд:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Возраст ребенка:";
            this.toolTip.SetToolTip(this.label6, "Параметры поиска по возрасту:\r\n\"[Число]\" - поиск по конкретному возрасту.\r\n\"[Числ" +
        "о]-[Число]\" - поиск в диапазоне возрастов.\r\n");
            // 
            // buttonChildSearch
            // 
            this.buttonChildSearch.Location = new System.Drawing.Point(171, 44);
            this.buttonChildSearch.Name = "buttonChildSearch";
            this.buttonChildSearch.Size = new System.Drawing.Size(102, 20);
            this.buttonChildSearch.TabIndex = 1;
            this.buttonChildSearch.Text = "Поиск/Обновить";
            this.buttonChildSearch.UseVisualStyleBackColor = true;
            this.buttonChildSearch.Click += new System.EventHandler(this.ButtonChildSearch_Click);
            // 
            // textBoxChildSearchText
            // 
            this.textBoxChildSearchText.Location = new System.Drawing.Point(9, 44);
            this.textBoxChildSearchText.Name = "textBoxChildSearchText";
            this.textBoxChildSearchText.Size = new System.Drawing.Size(156, 20);
            this.textBoxChildSearchText.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 479);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitContainer);
            this.Name = "ClientsForm";
            this.Text = "База данных клиентов";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondary)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClientSearch;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridViewSecondary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxClientSearchText;
        private System.Windows.Forms.ComboBox comboBoxClientSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRecordOnTrainingClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonChangeClientInfo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonChangeChildInfo;
        private System.Windows.Forms.Button buttonRecordOnTrainingChild;
        private System.Windows.Forms.ComboBox comboBoxClientSearchBySex;
        private System.Windows.Forms.ComboBox comboBoxClientSearchBySC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExportToExcelClients;
        private System.Windows.Forms.Button buttonExportToExcelChildren;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxChildSearchBySex;
        private System.Windows.Forms.ComboBox comboBoxChildSearchBySC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonChildSearch;
        private System.Windows.Forms.TextBox textBoxChildSearchText;
        private System.Windows.Forms.TextBox textBoxChildAgeSearch;
        private System.Windows.Forms.ToolTip toolTip;
    }
}