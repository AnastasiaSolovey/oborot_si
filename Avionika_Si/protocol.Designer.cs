namespace Oborot_SI
{
    partial class protocol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(protocol));
            this.protocolLabel = new System.Windows.Forms.Label();
            this.idProtocolBox = new System.Windows.Forms.TextBox();
            this.idProtocolLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // protocolLabel
            // 
            this.protocolLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.protocolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolLabel.Location = new System.Drawing.Point(11, 17);
            this.protocolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(171, 33);
            this.protocolLabel.TabIndex = 17;
            this.protocolLabel.Text = "ПРОТОКОЛ";
            // 
            // idProtocolBox
            // 
            this.idProtocolBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idProtocolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idProtocolBox.Location = new System.Drawing.Point(255, 78);
            this.idProtocolBox.Margin = new System.Windows.Forms.Padding(2);
            this.idProtocolBox.Name = "idProtocolBox";
            this.idProtocolBox.ReadOnly = true;
            this.idProtocolBox.Size = new System.Drawing.Size(250, 29);
            this.idProtocolBox.TabIndex = 36;
            this.idProtocolBox.Text = "0";
            // 
            // idProtocolLabel
            // 
            this.idProtocolLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idProtocolLabel.AutoSize = true;
            this.idProtocolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idProtocolLabel.Location = new System.Drawing.Point(11, 83);
            this.idProtocolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idProtocolLabel.Name = "idProtocolLabel";
            this.idProtocolLabel.Size = new System.Drawing.Size(185, 24);
            this.idProtocolLabel.TabIndex = 35;
            this.idProtocolLabel.Text = "Номер в протоколе";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(535, 151);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 46);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(11, 188);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(170, 24);
            this.factoryLabel.TabIndex = 40;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(255, 183);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(250, 29);
            this.factoryBox.TabIndex = 39;
            this.factoryBox.Text = "0";
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(255, 130);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(250, 29);
            this.inventoryBox.TabIndex = 38;
            this.inventoryBox.Text = "0";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(11, 135);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(195, 24);
            this.inventoryLabel.TabIndex = 37;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(11, 247);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(129, 24);
            this.descriptionLabel.TabIndex = 42;
            this.descriptionLabel.Text = "Примечание*";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.Location = new System.Drawing.Point(250, 247);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(335, 94);
            this.descriptionBox.TabIndex = 43;
            this.descriptionBox.Text = "";
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(11, 375);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(155, 24);
            this.employeeLabel.TabIndex = 44;
            this.employeeLabel.Text = "Ответственный";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(212, 445);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(174, 59);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Добавить новую запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(24, 445);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 59);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(441, 445);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 59);
            this.clearButton.TabIndex = 48;
            this.clearButton.Text = "Очистить поля";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // employeeBox
            // 
            this.employeeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeBox.DisplayMember = "id_sotrudnik";
            this.employeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(250, 367);
            this.employeeBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(335, 32);
            this.employeeBox.TabIndex = 49;
            this.employeeBox.ValueMember = "id_sotrudnik";
            // 
            // protocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(632, 515);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idProtocolBox);
            this.Controls.Add(this.idProtocolLabel);
            this.Controls.Add(this.protocolLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "protocol";
            this.Text = "Заполнение протокола СИ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.protocol_FormClosing);
            this.Load += new System.EventHandler(this.Protocol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label protocolLabel;
        private System.Windows.Forms.TextBox idProtocolBox;
        private System.Windows.Forms.Label idProtocolLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox employeeBox;
    }
}