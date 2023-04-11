namespace Oborot_SI
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.measuringButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainmenuLabel = new System.Windows.Forms.Label();
            this.passportButton = new System.Windows.Forms.Button();
            this.protocolButton = new System.Windows.Forms.Button();
            this.journalButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.certificateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // measuringButton
            // 
            this.measuringButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.measuringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measuringButton.Location = new System.Drawing.Point(18, 107);
            this.measuringButton.Margin = new System.Windows.Forms.Padding(2);
            this.measuringButton.Name = "measuringButton";
            this.measuringButton.Size = new System.Drawing.Size(169, 64);
            this.measuringButton.TabIndex = 1;
            this.measuringButton.Text = "Средство измерения";
            this.measuringButton.UseVisualStyleBackColor = true;
            this.measuringButton.Click += new System.EventHandler(this.Card_Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(206, 288);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(169, 64);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход из приложения";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainmenuLabel
            // 
            this.mainmenuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainmenuLabel.AutoSize = true;
            this.mainmenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainmenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainmenuLabel.Location = new System.Drawing.Point(180, 28);
            this.mainmenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainmenuLabel.Name = "mainmenuLabel";
            this.mainmenuLabel.Size = new System.Drawing.Size(239, 33);
            this.mainmenuLabel.TabIndex = 3;
            this.mainmenuLabel.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // passportButton
            // 
            this.passportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportButton.Location = new System.Drawing.Point(412, 107);
            this.passportButton.Margin = new System.Windows.Forms.Padding(2);
            this.passportButton.Name = "passportButton";
            this.passportButton.Size = new System.Drawing.Size(169, 64);
            this.passportButton.TabIndex = 4;
            this.passportButton.Text = "Паспорт";
            this.passportButton.UseVisualStyleBackColor = true;
            this.passportButton.Click += new System.EventHandler(this.toPasp_Button_Click);
            // 
            // protocolButton
            // 
            this.protocolButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolButton.Location = new System.Drawing.Point(206, 107);
            this.protocolButton.Margin = new System.Windows.Forms.Padding(2);
            this.protocolButton.Name = "protocolButton";
            this.protocolButton.Size = new System.Drawing.Size(169, 64);
            this.protocolButton.TabIndex = 5;
            this.protocolButton.Text = "Протокол";
            this.protocolButton.UseVisualStyleBackColor = true;
            this.protocolButton.Click += new System.EventHandler(this.Protocol_Button_Click);
            // 
            // journalButton
            // 
            this.journalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.journalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalButton.Location = new System.Drawing.Point(18, 194);
            this.journalButton.Margin = new System.Windows.Forms.Padding(2);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(169, 64);
            this.journalButton.TabIndex = 6;
            this.journalButton.Text = "Журнал";
            this.journalButton.UseVisualStyleBackColor = true;
            this.journalButton.Click += new System.EventHandler(this.Journal_Button_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleButton.Location = new System.Drawing.Point(206, 194);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(169, 64);
            this.scheduleButton.TabIndex = 7;
            this.scheduleButton.Text = "График";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // certificateButton
            // 
            this.certificateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.certificateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certificateButton.Location = new System.Drawing.Point(412, 194);
            this.certificateButton.Margin = new System.Windows.Forms.Padding(2);
            this.certificateButton.Name = "certificateButton";
            this.certificateButton.Size = new System.Drawing.Size(169, 64);
            this.certificateButton.TabIndex = 8;
            this.certificateButton.Text = "Аттестат";
            this.certificateButton.UseVisualStyleBackColor = true;
            this.certificateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.certificateButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.journalButton);
            this.Controls.Add(this.protocolButton);
            this.Controls.Add(this.passportButton);
            this.Controls.Add(this.mainmenuLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.measuringButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button measuringButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label mainmenuLabel;
        private System.Windows.Forms.Button passportButton;
        private System.Windows.Forms.Button protocolButton;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button certificateButton;
    }
}