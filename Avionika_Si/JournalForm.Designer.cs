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
            this.ConclusionBox = new System.Windows.Forms.ComboBox();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.JournalNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.LastNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JournalNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ConclusionBox
            // 
            this.ConclusionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConclusionBox.DisplayMember = "zakluchenie";
            this.ConclusionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConclusionBox.FormattingEnabled = true;
            this.ConclusionBox.Location = new System.Drawing.Point(12, 104);
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
            this.conclusionLabel.Location = new System.Drawing.Point(8, 86);
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
            this.addButton.Location = new System.Drawing.Point(11, 145);
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
            this.idLabel.Location = new System.Drawing.Point(8, 16);
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
            this.JournalNumberUpDown.Location = new System.Drawing.Point(12, 35);
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
            this.LastNumLabel.Location = new System.Drawing.Point(9, 60);
            this.LastNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNumLabel.Name = "LastNumLabel";
            this.LastNumLabel.Size = new System.Drawing.Size(92, 13);
            this.LastNumLabel.TabIndex = 36;
            this.LastNumLabel.Text = "LastNumInJournal";
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(361, 205);
            this.Controls.Add(this.LastNumLabel);
            this.Controls.Add(this.JournalNumberUpDown);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.ConclusionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "JournalForm";
            this.Text = "Метрология - заполнение журнала";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.Resize += new System.EventHandler(this.JournalForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.JournalNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ConclusionBox;
        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.NumericUpDown JournalNumberUpDown;
        private System.Windows.Forms.Label LastNumLabel;
    }
}