namespace Avionika_Si
{
    partial class MeasuringInstrumentDGV
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
            this.measuringsGridView = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diapazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etalon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostoyanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komplectacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinadlejnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mesInstrInvNumbLabel = new System.Windows.Forms.Label();
            this.updateMeasuringIstrumentButton = new System.Windows.Forms.Button();
            this.createMeasuringInstrumentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.measuringsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // measuringsGridView
            // 
            this.measuringsGridView.AllowUserToAddRows = false;
            this.measuringsGridView.AllowUserToDeleteRows = false;
            this.measuringsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.measuringsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.measuringsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.measuringsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naimenovanie,
            this.tip,
            this.firma,
            this.Diapazon,
            this.invent_nomer,
            this.zavod_nomer,
            this.etalon,
            this.sostoyanie,
            this.komplectacia,
            this.opisanie,
            this.prinadlejnost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.measuringsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.measuringsGridView.Location = new System.Drawing.Point(11, 11);
            this.measuringsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.measuringsGridView.MultiSelect = false;
            this.measuringsGridView.Name = "measuringsGridView";
            this.measuringsGridView.ReadOnly = true;
            this.measuringsGridView.RowHeadersWidth = 51;
            this.measuringsGridView.RowTemplate.Height = 24;
            this.measuringsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.measuringsGridView.Size = new System.Drawing.Size(1093, 684);
            this.measuringsGridView.TabIndex = 23;
            this.measuringsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.measuringsGridView_CellDoubleClick);
            this.measuringsGridView.SelectionChanged += new System.EventHandler(this.measuringsGridView_SelectionChanged);
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.ReadOnly = true;
            this.naimenovanie.Width = 108;
            // 
            // tip
            // 
            this.tip.HeaderText = "Тип";
            this.tip.MinimumWidth = 6;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Width = 51;
            // 
            // firma
            // 
            this.firma.HeaderText = "Фирма";
            this.firma.MinimumWidth = 6;
            this.firma.Name = "firma";
            this.firma.ReadOnly = true;
            this.firma.Width = 69;
            // 
            // Diapazon
            // 
            this.Diapazon.HeaderText = "Диапазон";
            this.Diapazon.MinimumWidth = 6;
            this.Diapazon.Name = "Diapazon";
            this.Diapazon.ReadOnly = true;
            this.Diapazon.Width = 83;
            // 
            // invent_nomer
            // 
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.ReadOnly = true;
            this.invent_nomer.Width = 124;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.ReadOnly = true;
            this.zavod_nomer.Width = 112;
            // 
            // etalon
            // 
            this.etalon.HeaderText = "Эталон";
            this.etalon.MinimumWidth = 6;
            this.etalon.Name = "etalon";
            this.etalon.ReadOnly = true;
            this.etalon.Width = 68;
            // 
            // sostoyanie
            // 
            this.sostoyanie.HeaderText = "Состояние";
            this.sostoyanie.MinimumWidth = 6;
            this.sostoyanie.Name = "sostoyanie";
            this.sostoyanie.ReadOnly = true;
            this.sostoyanie.Width = 86;
            // 
            // komplectacia
            // 
            this.komplectacia.HeaderText = "Комплектация";
            this.komplectacia.MinimumWidth = 6;
            this.komplectacia.Name = "komplectacia";
            this.komplectacia.ReadOnly = true;
            this.komplectacia.Width = 106;
            // 
            // opisanie
            // 
            this.opisanie.HeaderText = "Описание";
            this.opisanie.MinimumWidth = 6;
            this.opisanie.Name = "opisanie";
            this.opisanie.ReadOnly = true;
            this.opisanie.Width = 82;
            // 
            // prinadlejnost
            // 
            this.prinadlejnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prinadlejnost.HeaderText = "Принадлежность";
            this.prinadlejnost.MinimumWidth = 6;
            this.prinadlejnost.Name = "prinadlejnost";
            this.prinadlejnost.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.factoryBox);
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.inventoryBox);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(1109, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 155);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(5, 106);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(259, 21);
            this.factoryBox.TabIndex = 10;
            this.factoryBox.TextChanged += new System.EventHandler(this.factoryBox_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(2, 38);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(5, 56);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(260, 21);
            this.inventoryBox.TabIndex = 9;
            this.inventoryBox.TextChanged += new System.EventHandler(this.inventoryBox_TextChanged);
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(2, 88);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 11;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mesInstrInvNumbLabel);
            this.groupBox2.Controls.Add(this.updateMeasuringIstrumentButton);
            this.groupBox2.Controls.Add(this.createMeasuringInstrumentButton);
            this.groupBox2.Location = new System.Drawing.Point(1109, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 311);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // mesInstrInvNumbLabel
            // 
            this.mesInstrInvNumbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mesInstrInvNumbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mesInstrInvNumbLabel.Location = new System.Drawing.Point(10, 100);
            this.mesInstrInvNumbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mesInstrInvNumbLabel.Name = "mesInstrInvNumbLabel";
            this.mesInstrInvNumbLabel.Size = new System.Drawing.Size(248, 142);
            this.mesInstrInvNumbLabel.TabIndex = 38;
            this.mesInstrInvNumbLabel.Text = "mesInstrumentInvNum";
            // 
            // updateMeasuringIstrumentButton
            // 
            this.updateMeasuringIstrumentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateMeasuringIstrumentButton.Location = new System.Drawing.Point(10, 250);
            this.updateMeasuringIstrumentButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateMeasuringIstrumentButton.Name = "updateMeasuringIstrumentButton";
            this.updateMeasuringIstrumentButton.Size = new System.Drawing.Size(248, 42);
            this.updateMeasuringIstrumentButton.TabIndex = 31;
            this.updateMeasuringIstrumentButton.Text = "Обновить средство измерения";
            this.updateMeasuringIstrumentButton.UseVisualStyleBackColor = true;
            this.updateMeasuringIstrumentButton.Click += new System.EventHandler(this.updateMeasuringIstrumentButton_Click);
            // 
            // createMeasuringInstrumentButton
            // 
            this.createMeasuringInstrumentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createMeasuringInstrumentButton.Location = new System.Drawing.Point(10, 35);
            this.createMeasuringInstrumentButton.Margin = new System.Windows.Forms.Padding(2);
            this.createMeasuringInstrumentButton.Name = "createMeasuringInstrumentButton";
            this.createMeasuringInstrumentButton.Size = new System.Drawing.Size(248, 42);
            this.createMeasuringInstrumentButton.TabIndex = 30;
            this.createMeasuringInstrumentButton.Text = "Добавить средство измерения";
            this.createMeasuringInstrumentButton.UseVisualStyleBackColor = true;
            this.createMeasuringInstrumentButton.Click += new System.EventHandler(this.createMeasuringInstrumentButton_Click);
            // 
            // MeasuringInstrumentDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.measuringsGridView);
            this.Name = "MeasuringInstrumentDGV";
            this.Text = "Метрология - список средств измерений";
            this.Load += new System.EventHandler(this.MeasuringInstrumentDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.measuringsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView measuringsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diapazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn etalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostoyanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn komplectacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinadlejnost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateMeasuringIstrumentButton;
        private System.Windows.Forms.Button createMeasuringInstrumentButton;
        private System.Windows.Forms.Label mesInstrInvNumbLabel;
    }
}