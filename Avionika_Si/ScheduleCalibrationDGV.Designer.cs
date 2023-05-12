namespace Avionika_Si
{
    partial class ScheduleCalibrationDGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.InventoryFactoryNumbersFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.NextDateWorkBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.AddScheduleButton = new System.Windows.Forms.Button();
            this.ShowArchiveCheck = new System.Windows.Forms.CheckBox();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.InventoryBox = new System.Windows.Forms.TextBox();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.FactoryBox = new System.Windows.Forms.TextBox();
            this.InventoryFactoryNumbersFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowCalibrationMeasuringInstruments = new System.Windows.Forms.CheckBox();
            this.ShowCheckSchedule = new System.Windows.Forms.CheckBox();
            this.DateFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.InventoryFactoryNumbersFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateFilterRadioButton
            // 
            this.DateFilterRadioButton.AutoSize = true;
            this.DateFilterRadioButton.Location = new System.Drawing.Point(420, 18);
            this.DateFilterRadioButton.Name = "DateFilterRadioButton";
            this.DateFilterRadioButton.Size = new System.Drawing.Size(106, 17);
            this.DateFilterRadioButton.TabIndex = 63;
            this.DateFilterRadioButton.TabStop = true;
            this.DateFilterRadioButton.Text = "Фильтр по дате";
            this.DateFilterRadioButton.UseVisualStyleBackColor = true;
            this.DateFilterRadioButton.CheckedChanged += new System.EventHandler(this.DateFilterRadioButton_CheckedChanged);
            // 
            // InventoryFactoryNumbersFilterRadioButton
            // 
            this.InventoryFactoryNumbersFilterRadioButton.AutoSize = true;
            this.InventoryFactoryNumbersFilterRadioButton.Location = new System.Drawing.Point(11, 18);
            this.InventoryFactoryNumbersFilterRadioButton.Name = "InventoryFactoryNumbersFilterRadioButton";
            this.InventoryFactoryNumbersFilterRadioButton.Size = new System.Drawing.Size(120, 17);
            this.InventoryFactoryNumbersFilterRadioButton.TabIndex = 61;
            this.InventoryFactoryNumbersFilterRadioButton.TabStop = true;
            this.InventoryFactoryNumbersFilterRadioButton.Text = "Фильтр по номеру";
            this.InventoryFactoryNumbersFilterRadioButton.UseVisualStyleBackColor = true;
            this.InventoryFactoryNumbersFilterRadioButton.CheckedChanged += new System.EventHandler(this.InventoryFactoryNumbersFilterRadioButton_CheckedChanged);
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
            this.NextDateWorkBox.ValueChanged += new System.EventHandler(this.NextDateWorkBox_ValueChanged_1);
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
            // DateFilterGroupBox
            // 
            this.DateFilterGroupBox.Controls.Add(this.NextDateWorkBox);
            this.DateFilterGroupBox.Controls.Add(this.label1);
            this.DateFilterGroupBox.Enabled = false;
            this.DateFilterGroupBox.Location = new System.Drawing.Point(420, 31);
            this.DateFilterGroupBox.Name = "DateFilterGroupBox";
            this.DateFilterGroupBox.Size = new System.Drawing.Size(403, 85);
            this.DateFilterGroupBox.TabIndex = 60;
            this.DateFilterGroupBox.TabStop = false;
            // 
            // AddScheduleButton
            // 
            this.AddScheduleButton.Location = new System.Drawing.Point(829, 76);
            this.AddScheduleButton.Name = "AddScheduleButton";
            this.AddScheduleButton.Size = new System.Drawing.Size(108, 40);
            this.AddScheduleButton.TabIndex = 59;
            this.AddScheduleButton.Text = "Добавить данные в график";
            this.AddScheduleButton.UseVisualStyleBackColor = true;
            this.AddScheduleButton.Click += new System.EventHandler(this.AddScheduleButton_Click);
            // 
            // ShowArchiveCheck
            // 
            this.ShowArchiveCheck.AutoSize = true;
            this.ShowArchiveCheck.Location = new System.Drawing.Point(829, 53);
            this.ShowArchiveCheck.Name = "ShowArchiveCheck";
            this.ShowArchiveCheck.Size = new System.Drawing.Size(147, 17);
            this.ShowArchiveCheck.TabIndex = 62;
            this.ShowArchiveCheck.Text = "Показать архив данных";
            this.ShowArchiveCheck.UseVisualStyleBackColor = true;
            this.ShowArchiveCheck.CheckedChanged += new System.EventHandler(this.ShowArchiveCheck_CheckedChanged_1);
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
            this.zavod_nomer,
            this.invent_nomer,
            this.Column1,
            this.Data,
            this.Column3,
            this.Column4,
            this.TypeOfWork});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.scheduleGridView.Location = new System.Drawing.Point(11, 121);
            this.scheduleGridView.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.ReadOnly = true;
            this.scheduleGridView.RowHeadersWidth = 51;
            this.scheduleGridView.RowTemplate.Height = 24;
            this.scheduleGridView.Size = new System.Drawing.Size(1187, 391);
            this.scheduleGridView.TabIndex = 57;
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
            // zavod_nomer
            // 
            this.zavod_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.ReadOnly = true;
            this.zavod_nomer.Width = 112;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Подразделение";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 112;
            // 
            // Data
            // 
            this.Data.HeaderText = "Дата";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Дата следующей работы";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 145;
            // 
            // TypeOfWork
            // 
            this.TypeOfWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeOfWork.HeaderText = "Вид работы";
            this.TypeOfWork.Name = "TypeOfWork";
            this.TypeOfWork.ReadOnly = true;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(5, 60);
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
            this.InventoryBox.Location = new System.Drawing.Point(187, 57);
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
            this.factoryLabel.Location = new System.Drawing.Point(5, 24);
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
            this.FactoryBox.Location = new System.Drawing.Point(187, 22);
            this.FactoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.FactoryBox.Name = "FactoryBox";
            this.FactoryBox.Size = new System.Drawing.Size(177, 22);
            this.FactoryBox.TabIndex = 49;
            this.FactoryBox.TextChanged += new System.EventHandler(this.FactoryBox_TextChanged_1);
            // 
            // InventoryFactoryNumbersFilterGroupBox
            // 
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.inventoryLabel);
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.InventoryBox);
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.factoryLabel);
            this.InventoryFactoryNumbersFilterGroupBox.Controls.Add(this.FactoryBox);
            this.InventoryFactoryNumbersFilterGroupBox.Location = new System.Drawing.Point(11, 31);
            this.InventoryFactoryNumbersFilterGroupBox.Name = "InventoryFactoryNumbersFilterGroupBox";
            this.InventoryFactoryNumbersFilterGroupBox.Size = new System.Drawing.Size(403, 85);
            this.InventoryFactoryNumbersFilterGroupBox.TabIndex = 58;
            this.InventoryFactoryNumbersFilterGroupBox.TabStop = false;
            // 
            // ShowCalibrationMeasuringInstruments
            // 
            this.ShowCalibrationMeasuringInstruments.AutoSize = true;
            this.ShowCalibrationMeasuringInstruments.Location = new System.Drawing.Point(829, 30);
            this.ShowCalibrationMeasuringInstruments.Name = "ShowCalibrationMeasuringInstruments";
            this.ShowCalibrationMeasuringInstruments.Size = new System.Drawing.Size(176, 17);
            this.ShowCalibrationMeasuringInstruments.TabIndex = 64;
            this.ShowCalibrationMeasuringInstruments.Text = "Показать только калибровки";
            this.ShowCalibrationMeasuringInstruments.UseVisualStyleBackColor = true;
            this.ShowCalibrationMeasuringInstruments.CheckedChanged += new System.EventHandler(this.ShowCalibrationMeasuringInstruments_CheckedChanged);
            // 
            // ShowCheckSchedule
            // 
            this.ShowCheckSchedule.AutoSize = true;
            this.ShowCheckSchedule.Location = new System.Drawing.Point(1010, 30);
            this.ShowCheckSchedule.Name = "ShowCheckSchedule";
            this.ShowCheckSchedule.Size = new System.Drawing.Size(164, 17);
            this.ShowCheckSchedule.TabIndex = 65;
            this.ShowCheckSchedule.Text = "Показать только проверки";
            this.ShowCheckSchedule.UseVisualStyleBackColor = true;
            this.ShowCheckSchedule.CheckedChanged += new System.EventHandler(this.ShowCheckSchedule_CheckedChanged);
            // 
            // ScheduleCalibrationDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 542);
            this.Controls.Add(this.ShowCheckSchedule);
            this.Controls.Add(this.ShowCalibrationMeasuringInstruments);
            this.Controls.Add(this.DateFilterRadioButton);
            this.Controls.Add(this.InventoryFactoryNumbersFilterRadioButton);
            this.Controls.Add(this.DateFilterGroupBox);
            this.Controls.Add(this.AddScheduleButton);
            this.Controls.Add(this.ShowArchiveCheck);
            this.Controls.Add(this.scheduleGridView);
            this.Controls.Add(this.InventoryFactoryNumbersFilterGroupBox);
            this.Name = "ScheduleCalibrationDGV";
            this.Text = "Метрология - просмотр графика калибровки и проверки";
            this.Load += new System.EventHandler(this.ScheduleCalibrationDGV_Load);
            this.DateFilterGroupBox.ResumeLayout(false);
            this.DateFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.InventoryFactoryNumbersFilterGroupBox.ResumeLayout(false);
            this.InventoryFactoryNumbersFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DateFilterRadioButton;
        private System.Windows.Forms.RadioButton InventoryFactoryNumbersFilterRadioButton;
        private System.Windows.Forms.DateTimePicker NextDateWorkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DateFilterGroupBox;
        private System.Windows.Forms.Button AddScheduleButton;
        private System.Windows.Forms.CheckBox ShowArchiveCheck;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox InventoryBox;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox FactoryBox;
        private System.Windows.Forms.GroupBox InventoryFactoryNumbersFilterGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfWork;
        private System.Windows.Forms.CheckBox ShowCalibrationMeasuringInstruments;
        private System.Windows.Forms.CheckBox ShowCheckSchedule;
    }
}