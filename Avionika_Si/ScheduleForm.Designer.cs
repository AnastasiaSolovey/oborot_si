﻿namespace Oborot_SI
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.factoryLabel = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequencyBox = new System.Windows.Forms.ComboBox();
            this.oldVenueLabel = new System.Windows.Forms.Label();
            this.newVenueLabel = new System.Windows.Forms.Label();
            this.newDateBox = new System.Windows.Forms.DateTimePicker();
            this.newDateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CalculateDateButton = new System.Windows.Forms.Button();
            this.oldVenueBox = new System.Windows.Forms.ComboBox();
            this.newVenueBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(16, 75);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 44;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(19, 93);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(297, 22);
            this.factoryBox.TabIndex = 43;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(19, 40);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(297, 22);
            this.inventoryBox.TabIndex = 42;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(16, 22);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 41;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyLabel.Location = new System.Drawing.Point(16, 133);
            this.frequencyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(159, 16);
            this.frequencyLabel.TabIndex = 45;
            this.frequencyLabel.Text = "Периодичность (в мес.)";
            // 
            // frequencyBox
            // 
            this.frequencyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequencyBox.DisplayMember = "periodichnost";
            this.frequencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyBox.FormattingEnabled = true;
            this.frequencyBox.Items.AddRange(new object[] {
            "12",
            "18",
            "24",
            "36",
            "48",
            "6"});
            this.frequencyBox.Location = new System.Drawing.Point(19, 151);
            this.frequencyBox.Margin = new System.Windows.Forms.Padding(2);
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(297, 24);
            this.frequencyBox.TabIndex = 46;
            this.frequencyBox.ValueMember = "periodichnost";
            // 
            // oldVenueLabel
            // 
            this.oldVenueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldVenueLabel.AutoSize = true;
            this.oldVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldVenueLabel.Location = new System.Drawing.Point(428, 32);
            this.oldVenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldVenueLabel.Name = "oldVenueLabel";
            this.oldVenueLabel.Size = new System.Drawing.Size(130, 16);
            this.oldVenueLabel.TabIndex = 47;
            this.oldVenueLabel.Text = "Место проведения";
            // 
            // newVenueLabel
            // 
            this.newVenueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newVenueLabel.AutoSize = true;
            this.newVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newVenueLabel.Location = new System.Drawing.Point(428, 85);
            this.newVenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newVenueLabel.Name = "newVenueLabel";
            this.newVenueLabel.Size = new System.Drawing.Size(207, 16);
            this.newVenueLabel.TabIndex = 49;
            this.newVenueLabel.Text = "Следующее место проведения";
            // 
            // newDateBox
            // 
            this.newDateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newDateBox.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateBox.Enabled = false;
            this.newDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateBox.Location = new System.Drawing.Point(431, 163);
            this.newDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.newDateBox.Name = "newDateBox";
            this.newDateBox.Size = new System.Drawing.Size(297, 24);
            this.newDateBox.TabIndex = 52;
            // 
            // newDateLabel
            // 
            this.newDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newDateLabel.AutoSize = true;
            this.newDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateLabel.Location = new System.Drawing.Point(428, 145);
            this.newDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newDateLabel.Name = "newDateLabel";
            this.newDateLabel.Size = new System.Drawing.Size(199, 16);
            this.newDateLabel.TabIndex = 53;
            this.newDateLabel.Text = "Дата следующей работы с СИ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 478);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 54;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(431, 196);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 34);
            this.AddButton.TabIndex = 57;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // CalculateDateButton
            // 
            this.CalculateDateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateDateButton.Location = new System.Drawing.Point(19, 184);
            this.CalculateDateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateDateButton.Name = "CalculateDateButton";
            this.CalculateDateButton.Size = new System.Drawing.Size(106, 34);
            this.CalculateDateButton.TabIndex = 59;
            this.CalculateDateButton.Text = "Рассчитать";
            this.CalculateDateButton.UseVisualStyleBackColor = true;
            this.CalculateDateButton.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // oldVenueBox
            // 
            this.oldVenueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldVenueBox.DisplayMember = "periodichnost";
            this.oldVenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldVenueBox.FormattingEnabled = true;
            this.oldVenueBox.Location = new System.Drawing.Point(431, 50);
            this.oldVenueBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldVenueBox.Name = "oldVenueBox";
            this.oldVenueBox.Size = new System.Drawing.Size(297, 24);
            this.oldVenueBox.TabIndex = 61;
            this.oldVenueBox.ValueMember = "periodichnost";
            this.oldVenueBox.Visible = false;
            // 
            // newVenueBox
            // 
            this.newVenueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newVenueBox.DisplayMember = "periodichnost";
            this.newVenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newVenueBox.FormattingEnabled = true;
            this.newVenueBox.Location = new System.Drawing.Point(431, 103);
            this.newVenueBox.Margin = new System.Windows.Forms.Padding(2);
            this.newVenueBox.Name = "newVenueBox";
            this.newVenueBox.Size = new System.Drawing.Size(297, 24);
            this.newVenueBox.TabIndex = 62;
            this.newVenueBox.ValueMember = "periodichnost";
            this.newVenueBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.inventoryBox);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Controls.Add(this.factoryBox);
            this.groupBox1.Controls.Add(this.CalculateDateButton);
            this.groupBox1.Controls.Add(this.frequencyLabel);
            this.groupBox1.Controls.Add(this.frequencyBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 230);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Средство измерения";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(763, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newVenueBox);
            this.Controls.Add(this.oldVenueBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newDateLabel);
            this.Controls.Add(this.newDateBox);
            this.Controls.Add(this.newVenueLabel);
            this.Controls.Add(this.oldVenueLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Schedule";
            this.Text = "Заполнение графика СИ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.schedule_FormClosing);
            this.Load += new System.EventHandler(this.Grafic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.ComboBox frequencyBox;
        private System.Windows.Forms.Label oldVenueLabel;
        private System.Windows.Forms.Label newVenueLabel;
        private System.Windows.Forms.DateTimePicker newDateBox;
        private System.Windows.Forms.Label newDateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CalculateDateButton;
        private System.Windows.Forms.ComboBox oldVenueBox;
        private System.Windows.Forms.ComboBox newVenueBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}