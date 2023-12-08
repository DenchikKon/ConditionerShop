namespace KursTRPO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Conditioners = new System.Windows.Forms.TabControl();
            this.Sells = new System.Windows.Forms.TabPage();
            this.buttonAddSells = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterConditionerName = new System.Windows.Forms.ComboBox();
            this.checkBoxMaxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxMinDate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFilterMax = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFilterMin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFilterBuyer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonApplyFilterSells = new System.Windows.Forms.Button();
            this.ButtonCancelFilterSells = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearchSells = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSells = new System.Windows.Forms.DataGridView();
            this.contextMenuStripSells = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Conditioner = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearchConditioner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridConditioner = new System.Windows.Forms.DataGridView();
            this.contextMenuStripConditioner = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Clients = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearchClients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStripClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Conditioners.SuspendLayout();
            this.Sells.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSells)).BeginInit();
            this.contextMenuStripSells.SuspendLayout();
            this.Conditioner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConditioner)).BeginInit();
            this.contextMenuStripConditioner.SuspendLayout();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.contextMenuStripClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // Conditioners
            // 
            this.Conditioners.Controls.Add(this.Sells);
            this.Conditioners.Controls.Add(this.Conditioner);
            this.Conditioners.Controls.Add(this.Clients);
            this.Conditioners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Conditioners.Location = new System.Drawing.Point(0, 0);
            this.Conditioners.Name = "Conditioners";
            this.Conditioners.SelectedIndex = 0;
            this.Conditioners.Size = new System.Drawing.Size(985, 553);
            this.Conditioners.TabIndex = 0;
            // 
            // Sells
            // 
            this.Sells.Controls.Add(this.button4);
            this.Sells.Controls.Add(this.button3);
            this.Sells.Controls.Add(this.buttonAddSells);
            this.Sells.Controls.Add(this.groupBox1);
            this.Sells.Controls.Add(this.textBoxSearchSells);
            this.Sells.Controls.Add(this.label1);
            this.Sells.Controls.Add(this.dataGridSells);
            this.Sells.Location = new System.Drawing.Point(4, 22);
            this.Sells.Name = "Sells";
            this.Sells.Padding = new System.Windows.Forms.Padding(3);
            this.Sells.Size = new System.Drawing.Size(977, 527);
            this.Sells.TabIndex = 0;
            this.Sells.Text = "Продажи";
            this.Sells.UseVisualStyleBackColor = true;
            // 
            // buttonAddSells
            // 
            this.buttonAddSells.Location = new System.Drawing.Point(861, 489);
            this.buttonAddSells.Name = "buttonAddSells";
            this.buttonAddSells.Size = new System.Drawing.Size(116, 36);
            this.buttonAddSells.TabIndex = 7;
            this.buttonAddSells.Text = "Продажа";
            this.buttonAddSells.UseVisualStyleBackColor = true;
            this.buttonAddSells.Click += new System.EventHandler(this.buttonAddSells_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFilterConditionerName);
            this.groupBox1.Controls.Add(this.checkBoxMaxDate);
            this.groupBox1.Controls.Add(this.checkBoxMinDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerFilterMax);
            this.groupBox1.Controls.Add(this.dateTimePickerFilterMin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxFilterBuyer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonApplyFilterSells);
            this.groupBox1.Controls.Add(this.ButtonCancelFilterSells);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(611, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // comboBoxFilterConditionerName
            // 
            this.comboBoxFilterConditionerName.FormattingEnabled = true;
            this.comboBoxFilterConditionerName.Location = new System.Drawing.Point(9, 58);
            this.comboBoxFilterConditionerName.Name = "comboBoxFilterConditionerName";
            this.comboBoxFilterConditionerName.Size = new System.Drawing.Size(220, 21);
            this.comboBoxFilterConditionerName.TabIndex = 13;
            // 
            // checkBoxMaxDate
            // 
            this.checkBoxMaxDate.AutoSize = true;
            this.checkBoxMaxDate.Location = new System.Drawing.Point(323, 240);
            this.checkBoxMaxDate.Name = "checkBoxMaxDate";
            this.checkBoxMaxDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMaxDate.TabIndex = 12;
            this.checkBoxMaxDate.UseVisualStyleBackColor = true;
            this.checkBoxMaxDate.CheckedChanged += new System.EventHandler(this.checkBoxMaxDate_CheckedChanged);
            // 
            // checkBoxMinDate
            // 
            this.checkBoxMinDate.AutoSize = true;
            this.checkBoxMinDate.Location = new System.Drawing.Point(163, 240);
            this.checkBoxMinDate.Name = "checkBoxMinDate";
            this.checkBoxMinDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMinDate.TabIndex = 11;
            this.checkBoxMinDate.UseVisualStyleBackColor = true;
            this.checkBoxMinDate.CheckedChanged += new System.EventHandler(this.checkBoxMinDate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "—";
            // 
            // dateTimePickerFilterMax
            // 
            this.dateTimePickerFilterMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilterMax.Location = new System.Drawing.Point(205, 214);
            this.dateTimePickerFilterMax.Name = "dateTimePickerFilterMax";
            this.dateTimePickerFilterMax.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerFilterMax.TabIndex = 9;
            // 
            // dateTimePickerFilterMin
            // 
            this.dateTimePickerFilterMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilterMin.Location = new System.Drawing.Point(45, 214);
            this.dateTimePickerFilterMin.Name = "dateTimePickerFilterMin";
            this.dateTimePickerFilterMin.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerFilterMin.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата:";
            // 
            // comboBoxFilterBuyer
            // 
            this.comboBoxFilterBuyer.FormattingEnabled = true;
            this.comboBoxFilterBuyer.Location = new System.Drawing.Point(9, 139);
            this.comboBoxFilterBuyer.Name = "comboBoxFilterBuyer";
            this.comboBoxFilterBuyer.Size = new System.Drawing.Size(220, 21);
            this.comboBoxFilterBuyer.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Покупатель:";
            // 
            // buttonApplyFilterSells
            // 
            this.buttonApplyFilterSells.Location = new System.Drawing.Point(223, 285);
            this.buttonApplyFilterSells.Name = "buttonApplyFilterSells";
            this.buttonApplyFilterSells.Size = new System.Drawing.Size(143, 23);
            this.buttonApplyFilterSells.TabIndex = 3;
            this.buttonApplyFilterSells.Text = "Применить фильтры";
            this.buttonApplyFilterSells.UseVisualStyleBackColor = true;
            this.buttonApplyFilterSells.Click += new System.EventHandler(this.buttonApplyFilterSells_Click);
            // 
            // ButtonCancelFilterSells
            // 
            this.ButtonCancelFilterSells.Location = new System.Drawing.Point(0, 285);
            this.ButtonCancelFilterSells.Name = "ButtonCancelFilterSells";
            this.ButtonCancelFilterSells.Size = new System.Drawing.Size(127, 23);
            this.ButtonCancelFilterSells.TabIndex = 2;
            this.ButtonCancelFilterSells.Text = "Сбросить фильтры";
            this.ButtonCancelFilterSells.UseVisualStyleBackColor = true;
            this.ButtonCancelFilterSells.Click += new System.EventHandler(this.ButtonCancelFilterSells_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Наименование кондиционера:";
            // 
            // textBoxSearchSells
            // 
            this.textBoxSearchSells.Location = new System.Drawing.Point(816, 0);
            this.textBoxSearchSells.Name = "textBoxSearchSells";
            this.textBoxSearchSells.Size = new System.Drawing.Size(161, 20);
            this.textBoxSearchSells.TabIndex = 2;
            this.textBoxSearchSells.TextChanged += new System.EventHandler(this.textBoxSearchSells_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск:";
            // 
            // dataGridSells
            // 
            this.dataGridSells.AllowUserToAddRows = false;
            this.dataGridSells.AllowUserToDeleteRows = false;
            this.dataGridSells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSells.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSells.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSells.ContextMenuStrip = this.contextMenuStripSells;
            this.dataGridSells.Location = new System.Drawing.Point(0, 0);
            this.dataGridSells.Name = "dataGridSells";
            this.dataGridSells.ReadOnly = true;
            this.dataGridSells.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSells.RowHeadersVisible = false;
            this.dataGridSells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSells.Size = new System.Drawing.Size(586, 527);
            this.dataGridSells.TabIndex = 0;
            this.dataGridSells.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridSells_CellMouseDown);
            // 
            // contextMenuStripSells
            // 
            this.contextMenuStripSells.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStripSells.Name = "contextMenuStripSells";
            this.contextMenuStripSells.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Conditioner
            // 
            this.Conditioner.Controls.Add(this.button1);
            this.Conditioner.Controls.Add(this.textBoxSearchConditioner);
            this.Conditioner.Controls.Add(this.label2);
            this.Conditioner.Controls.Add(this.dataGridConditioner);
            this.Conditioner.Location = new System.Drawing.Point(4, 22);
            this.Conditioner.Name = "Conditioner";
            this.Conditioner.Padding = new System.Windows.Forms.Padding(3);
            this.Conditioner.Size = new System.Drawing.Size(977, 527);
            this.Conditioner.TabIndex = 1;
            this.Conditioner.Text = "Кондиционеры";
            this.Conditioner.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить кондиционер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxSearchConditioner
            // 
            this.textBoxSearchConditioner.Location = new System.Drawing.Point(816, 0);
            this.textBoxSearchConditioner.Name = "textBoxSearchConditioner";
            this.textBoxSearchConditioner.Size = new System.Drawing.Size(161, 20);
            this.textBoxSearchConditioner.TabIndex = 4;
            this.textBoxSearchConditioner.TextChanged += new System.EventHandler(this.textBoxSearchConditioner_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск:";
            // 
            // dataGridConditioner
            // 
            this.dataGridConditioner.AllowUserToAddRows = false;
            this.dataGridConditioner.AllowUserToDeleteRows = false;
            this.dataGridConditioner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConditioner.BackgroundColor = System.Drawing.Color.White;
            this.dataGridConditioner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridConditioner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConditioner.ContextMenuStrip = this.contextMenuStripConditioner;
            this.dataGridConditioner.Location = new System.Drawing.Point(6, 3);
            this.dataGridConditioner.Name = "dataGridConditioner";
            this.dataGridConditioner.ReadOnly = true;
            this.dataGridConditioner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridConditioner.RowHeadersVisible = false;
            this.dataGridConditioner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConditioner.Size = new System.Drawing.Size(756, 527);
            this.dataGridConditioner.TabIndex = 1;
            this.dataGridConditioner.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridConditioner_CellMouseDown);
            // 
            // contextMenuStripConditioner
            // 
            this.contextMenuStripConditioner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStripConditioner.Name = "contextMenuStripConditioner";
            this.contextMenuStripConditioner.Size = new System.Drawing.Size(129, 48);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.button2);
            this.Clients.Controls.Add(this.textBoxSearchClients);
            this.Clients.Controls.Add(this.label3);
            this.Clients.Controls.Add(this.dataGridClients);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(977, 527);
            this.Clients.TabIndex = 2;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить клиента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSearchClients
            // 
            this.textBoxSearchClients.Location = new System.Drawing.Point(816, 0);
            this.textBoxSearchClients.Name = "textBoxSearchClients";
            this.textBoxSearchClients.Size = new System.Drawing.Size(161, 20);
            this.textBoxSearchClients.TabIndex = 4;
            this.textBoxSearchClients.TextChanged += new System.EventHandler(this.textBoxSearchClients_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поиск:";
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.ContextMenuStrip = this.contextMenuStripClients;
            this.dataGridClients.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridClients.Location = new System.Drawing.Point(8, 3);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridClients.RowHeadersVisible = false;
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(754, 527);
            this.dataGridClients.TabIndex = 1;
            this.dataGridClients.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridClients_CellMouseDown);
            // 
            // contextMenuStripClients
            // 
            this.contextMenuStripClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem2});
            this.contextMenuStripClients.Name = "contextMenuStripClients";
            this.contextMenuStripClients.Size = new System.Drawing.Size(129, 48);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Вывод Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(887, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Вывод в Word";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 553);
            this.Controls.Add(this.Conditioners);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Сonditioner Seller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conditioners.ResumeLayout(false);
            this.Sells.ResumeLayout(false);
            this.Sells.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSells)).EndInit();
            this.contextMenuStripSells.ResumeLayout(false);
            this.Conditioner.ResumeLayout(false);
            this.Conditioner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConditioner)).EndInit();
            this.contextMenuStripConditioner.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            this.Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.contextMenuStripClients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Conditioners;
        private System.Windows.Forms.TabPage Sells;
        private System.Windows.Forms.TabPage Conditioner;
        private System.Windows.Forms.TextBox textBoxSearchSells;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridSells;
        private System.Windows.Forms.TextBox textBoxSearchConditioner;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridConditioner;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.TextBox textBoxSearchClients;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonApplyFilterSells;
        private System.Windows.Forms.Button ButtonCancelFilterSells;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddSells;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSells;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConditioner;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClients;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterMax;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxFilterBuyer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxMaxDate;
        private System.Windows.Forms.CheckBox checkBoxMinDate;
        private System.Windows.Forms.ComboBox comboBoxFilterConditionerName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

