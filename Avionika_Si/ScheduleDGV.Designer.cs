namespace Oborot_SI
{
    partial class ScheduleDGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleDGV));
            this.InventoryFactoryNumbersFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.InventoryBox = new System.Windows.Forms.TextBox();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.FactoryBox = new System.Windows.Forms.TextBox();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddScheduleButton = new System.Windows.Forms.Button();
            this.DateFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.NextDateWorkBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryFactoryNumbersFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowArchiveCheck = new System.Windows.Forms.CheckBox();
            this.DateFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.InventoryFactoryNumbersFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.DateFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryFactoryNumbersFilterGroupBox
            // 
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.inventoryLabel);
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.InventoryBox);
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.factoryLabel);
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.FactoryBox);
            this.InventoryFactoryNumbersFilterGroupBox.Location = new System.Drawing.Point(26, 34);
            this.InventoryFactoryNumbersFilterGroupBox.Name = "InventoryFactoryNumbersFilterGroupBox";
            this.InventoryFactoryNumbersFilterGroupBox.Size = new System.Drawing.Size(403, 85);
            this.InventoryFactoryNumbersFilterGroupBox.TabIndex = 51;
            this.InventoryFactoryNumbersFilterGroupBox.TabStop = false;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(5, 24);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 43;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // InventoryBox
            // 
            this.InventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryBox.Location = new System.Drawing.Point(187, 22);
            this.InventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(177, 22);
            this.InventoryBox.TabIndex = 50;
            this.InventoryBox.TextChanged += new System.EventHandler(this.InventoryBox_TextChanged);
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(5, 60);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 45;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // FactoryBox
            // 
            this.FactoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FactoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryBox.Location = new System.Drawing.Point(187, 57);
            this.FactoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.FactoryBox.Name = "FactoryBox";
            this.FactoryBox.Size = new System.Drawing.Size(177, 22);
            this.FactoryBox.TabIndex = 49;
            this.FactoryBox.TextChanged += new System.EventHandler(this.FactoryBox_TextChanged);
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naimenovanie,
            this.dataGridViewTextBoxColumn1,
            this.invent_nomer,
            this.zavod_nomer,
            this.Column3,
            this.Column1,
            this.Jh,
            this.Column4,
            this.Column5,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.scheduleGridView.Location = new System.Drawing.Point(26, 124);
            this.scheduleGridView.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.ReadOnly = true;
            this.scheduleGridView.RowHeadersWidth = 51;
            this.scheduleGridView.RowTemplate.Height = 24;
            this.scheduleGridView.Size = new System.Drawing.Size(1357, 398);
            this.scheduleGridView.TabIndex = 44;
            // 
            // naimenovanie
            // 
            this.naimenovanie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.ReadOnly = true;
            this.naimenovanie.Width = 108;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // invent_nomer
            // 
            this.invent_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.ReadOnly = true;
            this.invent_nomer.Width = 124;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.ReadOnly = true;
            this.zavod_nomer.Width = 112;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Периодичность";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Jh
            // 
            this.Jh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Jh.HeaderText = "Место проведения";
            this.Jh.MinimumWidth = 6;
            this.Jh.Name = "Jh";
            this.Jh.ReadOnly = true;
            this.Jh.Width = 116;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Дата следующей работы";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 145;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Следующее место проведения";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 171;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Вид работы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // AddScheduleButton
            // 
            this.AddScheduleButton.Location = new System.Drawing.Point(844, 72);
            this.AddScheduleButton.Name = "AddScheduleButton";
            this.AddScheduleButton.Size = new System.Drawing.Size(108, 47);
            this.AddScheduleButton.TabIndex = 52;
            this.AddScheduleButton.Text = "Добавить данные в график";
            this.AddScheduleButton.UseVisualStyleBackColor = true;
            this.AddScheduleButton.Click += new System.EventHandler(this.AddScheduleButton_Click);
            // 
            // DateFilterGroupBox
            // 
            this.DateFilterGroupBox.Controls.Add(this.NextDateWorkBox);
            this.DateFilterGroupBox.Controls.Add(this.label1);
            this.DateFilterGroupBox.Enabled = false;
            this.DateFilterGroupBox.Location = new System.Drawing.Point(435, 34);
            this.DateFilterGroupBox.Name = "DateFilterGroupBox";
            this.DateFilterGroupBox.Size = new System.Drawing.Size(403, 85);
            this.DateFilterGroupBox.TabIndex = 53;
            this.DateFilterGroupBox.TabStop = false;
            // 
            // NextDateWorkBox
            // 
            this.NextDateWorkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextDateWorkBox.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextDateWorkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextDateWorkBox.Location = new System.Drawing.Point(5, 42);
            this.NextDateWorkBox.Margin = new System.Windows.Forms.Padding(2);
            this.NextDateWorkBox.Name = "NextDateWorkBox";
            this.NextDateWorkBox.Size = new System.Drawing.Size(297, 24);
            this.NextDateWorkBox.TabIndex = 65;
            this.NextDateWorkBox.ValueChanged += new System.EventHandler(this.NextDateWorkBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Дата следующей работы с СИ";
            // 
            // InventoryFactoryNumbersFilterRadioButton
            // 
            this.InventoryFactoryNumbersFilterRadioButton.AutoSize = true;
            this.InventoryFactoryNumbersFilterRadioButton.Location = new System.Drawing.Point(26, 21);
            this.InventoryFactoryNumbersFilterRadioButton.Name = "InventoryFactoryNumbersFilterRadioButton";
            this.InventoryFactoryNumbersFilterRadioButton.Size = new System.Drawing.Size(120, 17);
            this.InventoryFactoryNumbersFilterRadioButton.TabIndex = 54;
            this.InventoryFactoryNumbersFilterRadioButton.TabStop = true;
            this.InventoryFactoryNumbersFilterRadioButton.Text = "Фильтр по номеру";
            this.InventoryFactoryNumbersFilterRadioButton.UseVisualStyleBackColor = true;
            this.InventoryFactoryNumbersFilterRadioButton.CheckedChanged += new System.EventHandler(this.InventoryFactoryNumbersFilterRadioButton_CheckedChanged);
            // 
            // ShowArchiveCheck
            // 
            this.ShowArchiveCheck.AutoSize = true;
            this.ShowArchiveCheck.Location = new System.Drawing.Point(844, 43);
            this.ShowArchiveCheck.Name = "ShowArchiveCheck";
            this.ShowArchiveCheck.Size = new System.Drawing.Size(147, 17);
            this.ShowArchiveCheck.TabIndex = 55;
            this.ShowArchiveCheck.Text = "Показать архив данных";
            this.ShowArchiveCheck.UseVisualStyleBackColor = true;
            this.ShowArchiveCheck.CheckedChanged += new System.EventHandler(this.ShowArchiveCheck_CheckedChanged);
            // 
            // DateFilterRadioButton
            // 
            this.DateFilterRadioButton.AutoSize = true;
            this.DateFilterRadioButton.Location = new System.Drawing.Point(435, 21);
            this.DateFilterRadioButton.Name = "DateFilterRadioButton";
            this.DateFilterRadioButton.Size = new System.Drawing.Size(106, 17);
            this.DateFilterRadioButton.TabIndex = 56;
            this.DateFilterRadioButton.TabStop = true;
            this.DateFilterRadioButton.Text = "Фильтр по дате";
            this.DateFilterRadioButton.UseVisualStyleBackColor = true;
            this.DateFilterRadioButton.CheckedChanged += new System.EventHandler(this.DateFilterRadioButton_CheckedChanged);
            // 
            // ScheduleDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1404, 533);
            this.Controls.Add(this.DateFilterRadioButton);
            this.Controls.Add(this.ShowArchiveCheck);
            this.Controls.Add(this.InventoryFactoryNumbersFilterRadioButton);
            this.Controls.Add(this.DateFilterGroupBox);
            this.Controls.Add(this.AddScheduleButton);
            this.Controls.Add(this.InventoryFactoryNumbersFilterGroupBox);
            this.Controls.Add(this.scheduleGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScheduleDGV";
            this.Text = "Просмотр графика";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            this.InventoryFactoryNumbersFilterGroupBox.ResumeLayout(false);
            this.InventoryFactoryNumbersFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.DateFilterGroupBox.ResumeLayout(false);
            this.DateFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox InventoryFactoryNumbersFilterGroupBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox InventoryBox;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox FactoryBox;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.Button AddScheduleButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox DateFilterGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NextDateWorkBox;
        private System.Windows.Forms.RadioButton InventoryFactoryNumbersFilterRadioButton;
        private System.Windows.Forms.RadioButton DateFilterRadioButton;
        private System.Windows.Forms.CheckBox ShowArchiveCheck;
    }
}