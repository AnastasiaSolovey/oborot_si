namespace Oborot_SI
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.oldVenueLabel = new System.Windows.Forms.Label();
            this.newVenueLabel = new System.Windows.Forms.Label();
            this.newDateBox = new System.Windows.Forms.DateTimePicker();
            this.newDateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.oldVenueBox = new System.Windows.Forms.ComboBox();
            this.newVenueBox = new System.Windows.Forms.ComboBox();
            this.frequencyBox = new System.Windows.Forms.ComboBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.oldDateBox = new System.Windows.Forms.DateTimePicker();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PickMesInstrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldVenueLabel
            // 
            this.oldVenueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldVenueLabel.AutoSize = true;
            this.oldVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldVenueLabel.Location = new System.Drawing.Point(8, 284);
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
            this.newVenueLabel.Location = new System.Drawing.Point(8, 337);
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
            this.newDateBox.Location = new System.Drawing.Point(11, 411);
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
            this.newDateLabel.Location = new System.Drawing.Point(8, 393);
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
            this.label8.Location = new System.Drawing.Point(27, 679);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 54;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(11, 462);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 34);
            this.AddButton.TabIndex = 57;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // oldVenueBox
            // 
            this.oldVenueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldVenueBox.DisplayMember = "periodichnost";
            this.oldVenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldVenueBox.FormattingEnabled = true;
            this.oldVenueBox.Location = new System.Drawing.Point(11, 302);
            this.oldVenueBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldVenueBox.Name = "oldVenueBox";
            this.oldVenueBox.Size = new System.Drawing.Size(297, 24);
            this.oldVenueBox.TabIndex = 61;
            this.oldVenueBox.ValueMember = "periodichnost";
            // 
            // newVenueBox
            // 
            this.newVenueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newVenueBox.DisplayMember = "periodichnost";
            this.newVenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newVenueBox.FormattingEnabled = true;
            this.newVenueBox.Location = new System.Drawing.Point(11, 355);
            this.newVenueBox.Margin = new System.Windows.Forms.Padding(2);
            this.newVenueBox.Name = "newVenueBox";
            this.newVenueBox.Size = new System.Drawing.Size(297, 24);
            this.newVenueBox.TabIndex = 62;
            this.newVenueBox.ValueMember = "periodichnost";
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
            this.frequencyBox.Location = new System.Drawing.Point(11, 247);
            this.frequencyBox.Margin = new System.Windows.Forms.Padding(2);
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(297, 24);
            this.frequencyBox.TabIndex = 46;
            this.frequencyBox.ValueMember = "periodichnost";
            this.frequencyBox.TextChanged += new System.EventHandler(this.frequencyBox_TextChanged);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyLabel.Location = new System.Drawing.Point(8, 229);
            this.frequencyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(159, 16);
            this.frequencyLabel.TabIndex = 45;
            this.frequencyLabel.Text = "Периодичность (в мес.)";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(11, 89);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.ReadOnly = true;
            this.factoryBox.Size = new System.Drawing.Size(297, 22);
            this.factoryBox.TabIndex = 43;
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(8, 71);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 44;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(11, 36);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.ReadOnly = true;
            this.inventoryBox.Size = new System.Drawing.Size(297, 22);
            this.inventoryBox.TabIndex = 42;
            // 
            // oldDateBox
            // 
            this.oldDateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldDateBox.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldDateBox.Location = new System.Drawing.Point(11, 196);
            this.oldDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldDateBox.Name = "oldDateBox";
            this.oldDateBox.Size = new System.Drawing.Size(297, 24);
            this.oldDateBox.TabIndex = 64;
            this.oldDateBox.ValueChanged += new System.EventHandler(this.oldDateBox_ValueChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(8, 18);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 41;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Дата текущей работы с СИ";
            // 
            // PickMesInstrButton
            // 
            this.PickMesInstrButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PickMesInstrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickMesInstrButton.Location = new System.Drawing.Point(11, 129);
            this.PickMesInstrButton.Margin = new System.Windows.Forms.Padding(2);
            this.PickMesInstrButton.Name = "PickMesInstrButton";
            this.PickMesInstrButton.Size = new System.Drawing.Size(164, 34);
            this.PickMesInstrButton.TabIndex = 66;
            this.PickMesInstrButton.Text = "Выбрать СИ";
            this.PickMesInstrButton.UseVisualStyleBackColor = true;
            this.PickMesInstrButton.Click += new System.EventHandler(this.PickMesInstrButton_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(365, 562);
            this.Controls.Add(this.PickMesInstrButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.newVenueBox);
            this.Controls.Add(this.oldDateBox);
            this.Controls.Add(this.oldVenueBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.newDateLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.newDateBox);
            this.Controls.Add(this.frequencyBox);
            this.Controls.Add(this.newVenueLabel);
            this.Controls.Add(this.oldVenueLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScheduleForm";
            this.Text = "Заполнение графика СИ";
            this.Load += new System.EventHandler(this.Grafic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label oldVenueLabel;
        private System.Windows.Forms.Label newVenueLabel;
        private System.Windows.Forms.DateTimePicker newDateBox;
        private System.Windows.Forms.Label newDateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox oldVenueBox;
        private System.Windows.Forms.ComboBox newVenueBox;
        private System.Windows.Forms.ComboBox frequencyBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.DateTimePicker oldDateBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PickMesInstrButton;
    }
}