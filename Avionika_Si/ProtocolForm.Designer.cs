namespace Oborot_SI
{
    partial class ProtocolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtocolForm));
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.RichTextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(8, 64);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 16);
            this.descriptionLabel.TabIndex = 42;
            this.descriptionLabel.Text = "Примечание*";
            // 
            // NoteBox
            // 
            this.NoteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoteBox.Location = new System.Drawing.Point(11, 82);
            this.NoteBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(305, 189);
            this.NoteBox.TabIndex = 43;
            this.NoteBox.Text = "";
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(8, 11);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(110, 16);
            this.employeeLabel.TabIndex = 44;
            this.employeeLabel.Text = "Ответственный";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(11, 277);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(173, 37);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Добавить новую запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // employeeBox
            // 
            this.employeeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeBox.DisplayMember = "id_sotrudnik";
            this.employeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(11, 29);
            this.employeeBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(250, 24);
            this.employeeBox.TabIndex = 49;
            this.employeeBox.ValueMember = "id_sotrudnik";
            // 
            // ProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(383, 325);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.descriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProtocolForm";
            this.Text = "Метрология - заполнение протокола СИ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProtocolForm_FormClosing);
            this.Load += new System.EventHandler(this.Protocol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox NoteBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox employeeBox;
    }
}