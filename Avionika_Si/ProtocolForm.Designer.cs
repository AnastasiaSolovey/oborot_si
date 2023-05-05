﻿namespace Oborot_SI
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
            this.factoryLabel = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.RichTextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LastNumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProtocolNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(3, 80);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(141, 16);
            this.factoryLabel.TabIndex = 40;
            this.factoryLabel.Text = "Инвентарный номер";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Enabled = false;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(5, 149);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(250, 22);
            this.factoryBox.TabIndex = 39;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Enabled = false;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(6, 98);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(250, 22);
            this.inventoryBox.TabIndex = 38;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(2, 18);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(123, 16);
            this.inventoryLabel.TabIndex = 37;
            this.inventoryLabel.Text = "Номер протокола";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(313, 12);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 16);
            this.descriptionLabel.TabIndex = 42;
            this.descriptionLabel.Text = "Примечание*";
            // 
            // NoteBox
            // 
            this.NoteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoteBox.Location = new System.Drawing.Point(316, 30);
            this.NoteBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(305, 219);
            this.NoteBox.TabIndex = 43;
            this.NoteBox.Text = "";
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(16, 207);
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
            this.addButton.Location = new System.Drawing.Point(19, 274);
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
            this.employeeBox.Location = new System.Drawing.Point(19, 225);
            this.employeeBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(250, 24);
            this.employeeBox.TabIndex = 49;
            this.employeeBox.ValueMember = "id_sotrudnik";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.LastNumLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProtocolNumberUpDown);
            this.groupBox1.Controls.Add(this.factoryBox);
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.inventoryBox);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 182);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Средство измерения";
            // 
            // LastNumLabel
            // 
            this.LastNumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNumLabel.AutoSize = true;
            this.LastNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNumLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastNumLabel.Location = new System.Drawing.Point(3, 60);
            this.LastNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNumLabel.Name = "LastNumLabel";
            this.LastNumLabel.Size = new System.Drawing.Size(97, 13);
            this.LastNumLabel.TabIndex = 52;
            this.LastNumLabel.Text = "LastNumInProtocol";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Заводской номер";
            // 
            // ProtocolNumberUpDown
            // 
            this.ProtocolNumberUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProtocolNumberUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProtocolNumberUpDown.Location = new System.Drawing.Point(6, 35);
            this.ProtocolNumberUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ProtocolNumberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProtocolNumberUpDown.Name = "ProtocolNumberUpDown";
            this.ProtocolNumberUpDown.Size = new System.Drawing.Size(250, 22);
            this.ProtocolNumberUpDown.TabIndex = 51;
            this.ProtocolNumberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(632, 325);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.descriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProtocolForm";
            this.Text = "Заполнение протокола СИ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProtocolForm_FormClosing);
            this.Load += new System.EventHandler(this.Protocol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox NoteBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastNumLabel;
        private System.Windows.Forms.NumericUpDown ProtocolNumberUpDown;
    }
}