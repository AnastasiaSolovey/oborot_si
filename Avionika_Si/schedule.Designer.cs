namespace Oborot_SI
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
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.newDateBox = new System.Windows.Forms.DateTimePicker();
            this.newDateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.sceduleViewLabel = new System.Windows.Forms.LinkLabel();
            this.oldVenueBox = new System.Windows.Forms.ComboBox();
            this.newVenueBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(30, 162);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(170, 24);
            this.factoryLabel.TabIndex = 44;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(335, 157);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(297, 29);
            this.factoryBox.TabIndex = 43;
            this.factoryBox.Text = "0";
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(335, 104);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(297, 29);
            this.inventoryBox.TabIndex = 42;
            this.inventoryBox.Text = "0";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(30, 109);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(195, 24);
            this.inventoryLabel.TabIndex = 41;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyLabel.Location = new System.Drawing.Point(30, 220);
            this.frequencyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(225, 24);
            this.frequencyLabel.TabIndex = 45;
            this.frequencyLabel.Text = "Периодичность (в мес.)";
            // 
            // frequencyBox
            // 
            this.frequencyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequencyBox.DisplayMember = "periodichnost";
            this.frequencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyBox.FormattingEnabled = true;
            this.frequencyBox.Items.AddRange(new object[] {
            "12",
            "18",
            "24",
            "36",
            "48",
            "6"});
            this.frequencyBox.Location = new System.Drawing.Point(335, 212);
            this.frequencyBox.Margin = new System.Windows.Forms.Padding(2);
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(297, 32);
            this.frequencyBox.TabIndex = 46;
            this.frequencyBox.ValueMember = "periodichnost";
            // 
            // oldVenueLabel
            // 
            this.oldVenueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldVenueLabel.AutoSize = true;
            this.oldVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldVenueLabel.Location = new System.Drawing.Point(30, 353);
            this.oldVenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldVenueLabel.Name = "oldVenueLabel";
            this.oldVenueLabel.Size = new System.Drawing.Size(183, 24);
            this.oldVenueLabel.TabIndex = 47;
            this.oldVenueLabel.Text = "Место проведения";
            // 
            // newVenueLabel
            // 
            this.newVenueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newVenueLabel.AutoSize = true;
            this.newVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newVenueLabel.Location = new System.Drawing.Point(26, 423);
            this.newVenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newVenueLabel.Name = "newVenueLabel";
            this.newVenueLabel.Size = new System.Drawing.Size(289, 24);
            this.newVenueLabel.TabIndex = 49;
            this.newVenueLabel.Text = "Следующее место проведения";
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleLabel.Location = new System.Drawing.Point(34, 26);
            this.scheduleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(128, 33);
            this.scheduleLabel.TabIndex = 51;
            this.scheduleLabel.Text = "ГРАФИК";
            // 
            // newDateBox
            // 
            this.newDateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newDateBox.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateBox.Enabled = false;
            this.newDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateBox.Location = new System.Drawing.Point(335, 479);
            this.newDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.newDateBox.Name = "newDateBox";
            this.newDateBox.Size = new System.Drawing.Size(297, 29);
            this.newDateBox.TabIndex = 52;
            // 
            // newDateLabel
            // 
            this.newDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newDateLabel.AutoSize = true;
            this.newDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateLabel.Location = new System.Drawing.Point(30, 484);
            this.newDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newDateLabel.Name = "newDateLabel";
            this.newDateLabel.Size = new System.Drawing.Size(277, 24);
            this.newDateLabel.TabIndex = 53;
            this.newDateLabel.Text = "Дата следующей работы с СИ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 525);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 54;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(518, 560);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(159, 46);
            this.clearButton.TabIndex = 58;
            this.clearButton.Text = "Очистить поля";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(283, 560);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(194, 46);
            this.addButton.TabIndex = 57;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(89, 560);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 46);
            this.backButton.TabIndex = 56;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(335, 275);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 46);
            this.searchButton.TabIndex = 59;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // sceduleViewLabel
            // 
            this.sceduleViewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sceduleViewLabel.AutoSize = true;
            this.sceduleViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceduleViewLabel.Location = new System.Drawing.Point(239, 626);
            this.sceduleViewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sceduleViewLabel.Name = "sceduleViewLabel";
            this.sceduleViewLabel.Size = new System.Drawing.Size(295, 24);
            this.sceduleViewLabel.TabIndex = 60;
            this.sceduleViewLabel.TabStop = true;
            this.sceduleViewLabel.Text = "Перейти к просмотру графиков";
            this.sceduleViewLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // oldVenueBox
            // 
            this.oldVenueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldVenueBox.DisplayMember = "periodichnost";
            this.oldVenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldVenueBox.FormattingEnabled = true;
            this.oldVenueBox.Location = new System.Drawing.Point(335, 345);
            this.oldVenueBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldVenueBox.Name = "oldVenueBox";
            this.oldVenueBox.Size = new System.Drawing.Size(297, 32);
            this.oldVenueBox.TabIndex = 61;
            this.oldVenueBox.ValueMember = "periodichnost";
            this.oldVenueBox.Visible = false;
            // 
            // newVenueBox
            // 
            this.newVenueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newVenueBox.DisplayMember = "periodichnost";
            this.newVenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newVenueBox.FormattingEnabled = true;
            this.newVenueBox.Location = new System.Drawing.Point(335, 415);
            this.newVenueBox.Margin = new System.Windows.Forms.Padding(2);
            this.newVenueBox.Name = "newVenueBox";
            this.newVenueBox.Size = new System.Drawing.Size(297, 32);
            this.newVenueBox.TabIndex = 62;
            this.newVenueBox.ValueMember = "periodichnost";
            this.newVenueBox.Visible = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(763, 672);
            this.Controls.Add(this.newVenueBox);
            this.Controls.Add(this.oldVenueBox);
            this.Controls.Add(this.sceduleViewLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newDateLabel);
            this.Controls.Add(this.newDateBox);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.newVenueLabel);
            this.Controls.Add(this.oldVenueLabel);
            this.Controls.Add(this.frequencyBox);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.inventoryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Schedule";
            this.Text = "Заполнение графика СИ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.schedule_FormClosing);
            this.Load += new System.EventHandler(this.Grafic_Load);
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
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.DateTimePicker newDateBox;
        private System.Windows.Forms.Label newDateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.LinkLabel sceduleViewLabel;
        private System.Windows.Forms.ComboBox oldVenueBox;
        private System.Windows.Forms.ComboBox newVenueBox;
    }
}