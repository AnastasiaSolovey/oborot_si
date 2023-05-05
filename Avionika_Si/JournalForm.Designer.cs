namespace Oborot_SI
{
    partial class JournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.factoryLabel = new System.Windows.Forms.Label();
            this.FactoryBox = new System.Windows.Forms.TextBox();
            this.InventoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.ConclusionBox = new System.Windows.Forms.ComboBox();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.JournalNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.LastNumLabel = new System.Windows.Forms.Label();
            this.ChoseMeasuringInstrumentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JournalNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(8, 138);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(144, 16);
            this.factoryLabel.TabIndex = 15;
            this.factoryLabel.Text = "Заводской номер СИ";
            // 
            // FactoryBox
            // 
            this.FactoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FactoryBox.Enabled = false;
            this.FactoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryBox.Location = new System.Drawing.Point(11, 156);
            this.FactoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.FactoryBox.Name = "FactoryBox";
            this.FactoryBox.Size = new System.Drawing.Size(269, 22);
            this.FactoryBox.TabIndex = 14;
            // 
            // InventoryBox
            // 
            this.InventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryBox.Enabled = false;
            this.InventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryBox.Location = new System.Drawing.Point(11, 102);
            this.InventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(269, 22);
            this.InventoryBox.TabIndex = 13;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(8, 84);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(163, 16);
            this.inventoryLabel.TabIndex = 12;
            this.inventoryLabel.Text = "Инвентарный номер СИ";
            // 
            // ConclusionBox
            // 
            this.ConclusionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConclusionBox.DisplayMember = "zakluchenie";
            this.ConclusionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConclusionBox.FormattingEnabled = true;
            this.ConclusionBox.Location = new System.Drawing.Point(11, 254);
            this.ConclusionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConclusionBox.Name = "ConclusionBox";
            this.ConclusionBox.Size = new System.Drawing.Size(269, 24);
            this.ConclusionBox.TabIndex = 21;
            this.ConclusionBox.ValueMember = "zakluchenie";
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusionLabel.Location = new System.Drawing.Point(7, 236);
            this.conclusionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(89, 16);
            this.conclusionLabel.TabIndex = 22;
            this.conclusionLabel.Text = "Заключение";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(10, 295);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 40);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(6, 17);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(121, 16);
            this.idLabel.TabIndex = 33;
            this.idLabel.Text = "Номер в журнале";
            // 
            // JournalNumberUpDown
            // 
            this.JournalNumberUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JournalNumberUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalNumberUpDown.Location = new System.Drawing.Point(10, 36);
            this.JournalNumberUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.JournalNumberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JournalNumberUpDown.Name = "JournalNumberUpDown";
            this.JournalNumberUpDown.Size = new System.Drawing.Size(269, 22);
            this.JournalNumberUpDown.TabIndex = 35;
            this.JournalNumberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LastNumLabel
            // 
            this.LastNumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNumLabel.AutoSize = true;
            this.LastNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNumLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastNumLabel.Location = new System.Drawing.Point(7, 61);
            this.LastNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNumLabel.Name = "LastNumLabel";
            this.LastNumLabel.Size = new System.Drawing.Size(92, 13);
            this.LastNumLabel.TabIndex = 36;
            this.LastNumLabel.Text = "LastNumInJournal";
            // 
            // ChoseMeasuringInstrumentButton
            // 
            this.ChoseMeasuringInstrumentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChoseMeasuringInstrumentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoseMeasuringInstrumentButton.Location = new System.Drawing.Point(11, 188);
            this.ChoseMeasuringInstrumentButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChoseMeasuringInstrumentButton.Name = "ChoseMeasuringInstrumentButton";
            this.ChoseMeasuringInstrumentButton.Size = new System.Drawing.Size(127, 37);
            this.ChoseMeasuringInstrumentButton.TabIndex = 52;
            this.ChoseMeasuringInstrumentButton.Text = "Выбрать СИ";
            this.ChoseMeasuringInstrumentButton.UseVisualStyleBackColor = true;
            this.ChoseMeasuringInstrumentButton.Click += new System.EventHandler(this.ChoseMeasuringInstrumentButton_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(361, 355);
            this.Controls.Add(this.ChoseMeasuringInstrumentButton);
            this.Controls.Add(this.LastNumLabel);
            this.Controls.Add(this.JournalNumberUpDown);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.ConclusionBox);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.FactoryBox);
            this.Controls.Add(this.InventoryBox);
            this.Controls.Add(this.inventoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "JournalForm";
            this.Text = "Заполнение журнала";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.Resize += new System.EventHandler(this.JournalForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.JournalNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox FactoryBox;
        private System.Windows.Forms.TextBox InventoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.ComboBox ConclusionBox;
        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.NumericUpDown JournalNumberUpDown;
        private System.Windows.Forms.Label LastNumLabel;
        private System.Windows.Forms.Button ChoseMeasuringInstrumentButton;
    }
}