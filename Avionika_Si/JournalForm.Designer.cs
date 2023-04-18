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
            this.DateworkBox = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.TypeworkBox = new System.Windows.Forms.ComboBox();
            this.typeworkLabel = new System.Windows.Forms.Label();
            this.ConclusionBox = new System.Windows.Forms.ComboBox();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(28, 138);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(144, 16);
            this.factoryLabel.TabIndex = 15;
            this.factoryLabel.Text = "Заводской номер СИ";
            this.factoryLabel.Click += new System.EventHandler(this.factoryLabel_Click);
            // 
            // FactoryBox
            // 
            this.FactoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FactoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryBox.Location = new System.Drawing.Point(31, 156);
            this.FactoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.FactoryBox.Name = "FactoryBox";
            this.FactoryBox.Size = new System.Drawing.Size(269, 22);
            this.FactoryBox.TabIndex = 14;
            this.FactoryBox.TextChanged += new System.EventHandler(this.factoryBox_TextChanged);
            // 
            // InventoryBox
            // 
            this.InventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryBox.Location = new System.Drawing.Point(31, 102);
            this.InventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(269, 22);
            this.InventoryBox.TabIndex = 13;
            this.InventoryBox.TextChanged += new System.EventHandler(this.inventoryBox_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(28, 84);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(163, 16);
            this.inventoryLabel.TabIndex = 12;
            this.inventoryLabel.Text = "Инвентарный номер СИ";
            this.inventoryLabel.Click += new System.EventHandler(this.inventoryLabel_Click);
            // 
            // DateworkBox
            // 
            this.DateworkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateworkBox.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateworkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateworkBox.Location = new System.Drawing.Point(31, 212);
            this.DateworkBox.Margin = new System.Windows.Forms.Padding(2);
            this.DateworkBox.Name = "DateworkBox";
            this.DateworkBox.Size = new System.Drawing.Size(269, 22);
            this.DateworkBox.TabIndex = 17;
            this.DateworkBox.ValueChanged += new System.EventHandler(this.dateworkBox_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(28, 194);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 16);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "Дата работы";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // TypeworkBox
            // 
            this.TypeworkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeworkBox.DisplayMember = "vid_rabot";
            this.TypeworkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeworkBox.FormattingEnabled = true;
            this.TypeworkBox.Location = new System.Drawing.Point(30, 266);
            this.TypeworkBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeworkBox.Name = "TypeworkBox";
            this.TypeworkBox.Size = new System.Drawing.Size(270, 24);
            this.TypeworkBox.TabIndex = 19;
            this.TypeworkBox.ValueMember = "vid_rabot";
            this.TypeworkBox.SelectedIndexChanged += new System.EventHandler(this.typeworkBox_SelectedIndexChanged);
            // 
            // typeworkLabel
            // 
            this.typeworkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeworkLabel.AutoSize = true;
            this.typeworkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeworkLabel.Location = new System.Drawing.Point(28, 248);
            this.typeworkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeworkLabel.Name = "typeworkLabel";
            this.typeworkLabel.Size = new System.Drawing.Size(83, 16);
            this.typeworkLabel.TabIndex = 20;
            this.typeworkLabel.Text = "Вид работы";
            this.typeworkLabel.Click += new System.EventHandler(this.typeworkLabel_Click);
            // 
            // ConclusionBox
            // 
            this.ConclusionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConclusionBox.DisplayMember = "zakluchenie";
            this.ConclusionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConclusionBox.FormattingEnabled = true;
            this.ConclusionBox.Location = new System.Drawing.Point(31, 326);
            this.ConclusionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConclusionBox.Name = "ConclusionBox";
            this.ConclusionBox.Size = new System.Drawing.Size(269, 24);
            this.ConclusionBox.TabIndex = 21;
            this.ConclusionBox.ValueMember = "zakluchenie";
            this.ConclusionBox.SelectedIndexChanged += new System.EventHandler(this.conclusionBox_SelectedIndexChanged);
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusionLabel.Location = new System.Drawing.Point(27, 308);
            this.conclusionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(89, 16);
            this.conclusionLabel.TabIndex = 22;
            this.conclusionLabel.Text = "Заключение";
            this.conclusionLabel.Click += new System.EventHandler(this.conclusionLabel_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(31, 380);
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
            this.idLabel.Location = new System.Drawing.Point(28, 22);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(121, 16);
            this.idLabel.TabIndex = 33;
            this.idLabel.Text = "Номер в журнале";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // NumBox
            // 
            this.NumBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumBox.Location = new System.Drawing.Point(31, 40);
            this.NumBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(269, 22);
            this.NumBox.TabIndex = 34;
            this.NumBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(370, 435);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.ConclusionBox);
            this.Controls.Add(this.typeworkLabel);
            this.Controls.Add(this.TypeworkBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.DateworkBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox FactoryBox;
        private System.Windows.Forms.TextBox InventoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.DateTimePicker DateworkBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox TypeworkBox;
        private System.Windows.Forms.Label typeworkLabel;
        private System.Windows.Forms.ComboBox ConclusionBox;
        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox NumBox;
    }
}