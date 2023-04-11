namespace Oborot_SI
{
    partial class certificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(certificate));
            this.attestatLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateWork = new System.Windows.Forms.DateTimePicker();
            this.belongLabel = new System.Windows.Forms.Label();
            this.belongBox = new System.Windows.Forms.ComboBox();
            this.newdateLabel = new System.Windows.Forms.Label();
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.measuringBox = new System.Windows.Forms.ComboBox();
            this.protocolNum = new System.Windows.Forms.TextBox();
            this.protocolLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attestatLabel
            // 
            this.attestatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attestatLabel.AutoSize = true;
            this.attestatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attestatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attestatLabel.Location = new System.Drawing.Point(258, 40);
            this.attestatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attestatLabel.Name = "attestatLabel";
            this.attestatLabel.Size = new System.Drawing.Size(158, 33);
            this.attestatLabel.TabIndex = 17;
            this.attestatLabel.Text = "АТТЕСТАТ";
            this.attestatLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(540, 116);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 37);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(44, 248);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(170, 24);
            this.factoryLabel.TabIndex = 45;
            this.factoryLabel.Text = "Заводской номер";
            this.factoryLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(267, 243);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.ReadOnly = true;
            this.factoryBox.Size = new System.Drawing.Size(250, 29);
            this.factoryBox.TabIndex = 44;
            this.factoryBox.Text = "0";
            this.factoryBox.TextChanged += new System.EventHandler(this.zavod_Box_TextChanged);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(267, 179);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.ReadOnly = true;
            this.inventoryBox.Size = new System.Drawing.Size(250, 29);
            this.inventoryBox.TabIndex = 43;
            this.inventoryBox.Text = "0";
            this.inventoryBox.TextChanged += new System.EventHandler(this.invent_Box_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(44, 184);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(195, 24);
            this.inventoryLabel.TabIndex = 42;
            this.inventoryLabel.Text = "Инвентарный номер";
            this.inventoryLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(44, 428);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(125, 24);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "Дата работы";
            this.dateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateWork
            // 
            this.dateWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateWork.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateWork.Enabled = false;
            this.dateWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateWork.Location = new System.Drawing.Point(267, 423);
            this.dateWork.Margin = new System.Windows.Forms.Padding(2);
            this.dateWork.Name = "dateWork";
            this.dateWork.Size = new System.Drawing.Size(250, 29);
            this.dateWork.TabIndex = 47;
            this.dateWork.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // belongLabel
            // 
            this.belongLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.belongLabel.AutoSize = true;
            this.belongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongLabel.Location = new System.Drawing.Point(44, 371);
            this.belongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.belongLabel.Name = "belongLabel";
            this.belongLabel.Size = new System.Drawing.Size(166, 24);
            this.belongLabel.TabIndex = 50;
            this.belongLabel.Text = "Принадлежность";
            this.belongLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // belongBox
            // 
            this.belongBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.belongBox.DisplayMember = "prinadlejnost";
            this.belongBox.Enabled = false;
            this.belongBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongBox.FormattingEnabled = true;
            this.belongBox.Location = new System.Drawing.Point(267, 363);
            this.belongBox.Margin = new System.Windows.Forms.Padding(2);
            this.belongBox.Name = "belongBox";
            this.belongBox.Size = new System.Drawing.Size(250, 32);
            this.belongBox.TabIndex = 49;
            this.belongBox.ValueMember = "prinadlejnost";
            this.belongBox.SelectedIndexChanged += new System.EventHandler(this.prinadl_Box_SelectedIndexChanged);
            // 
            // newdateLabel
            // 
            this.newdateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newdateLabel.AutoSize = true;
            this.newdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newdateLabel.Location = new System.Drawing.Point(44, 479);
            this.newdateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newdateLabel.Name = "newdateLabel";
            this.newdateLabel.Size = new System.Drawing.Size(169, 24);
            this.newdateLabel.TabIndex = 55;
            this.newdateLabel.Text = "Действителен до";
            this.newdateLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // newDate
            // 
            this.newDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newDate.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDate.Enabled = false;
            this.newDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDate.Location = new System.Drawing.Point(267, 474);
            this.newDate.Margin = new System.Windows.Forms.Padding(2);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(250, 29);
            this.newDate.TabIndex = 54;
            this.newDate.ValueChanged += new System.EventHandler(this.new_date_ValueChanged);
            // 
            // employeeBox
            // 
            this.employeeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeBox.DisplayMember = "surname";
            this.employeeBox.Enabled = false;
            this.employeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(267, 529);
            this.employeeBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(250, 32);
            this.employeeBox.TabIndex = 57;
            this.employeeBox.ValueMember = "id_sotrudnik";
            this.employeeBox.SelectedIndexChanged += new System.EventHandler(this.sotrudnik_Box_SelectedIndexChanged);
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(44, 537);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(155, 24);
            this.employeeLabel.TabIndex = 56;
            this.employeeLabel.Text = "Ответственный";
            this.employeeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(286, 609);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(189, 46);
            this.createButton.TabIndex = 58;
            this.createButton.Text = "Создать аттестат";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(80, 609);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 46);
            this.backButton.TabIndex = 59;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(44, 315);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(175, 24);
            this.nameLabel.TabIndex = 61;
            this.nameLabel.Text = "Наименование СИ";
            this.nameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // measuringBox
            // 
            this.measuringBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.measuringBox.DisplayMember = "naimenovanie";
            this.measuringBox.Enabled = false;
            this.measuringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measuringBox.FormattingEnabled = true;
            this.measuringBox.Location = new System.Drawing.Point(267, 307);
            this.measuringBox.Margin = new System.Windows.Forms.Padding(2);
            this.measuringBox.Name = "measuringBox";
            this.measuringBox.Size = new System.Drawing.Size(250, 32);
            this.measuringBox.TabIndex = 60;
            this.measuringBox.ValueMember = "naimenovanie";
            this.measuringBox.SelectedIndexChanged += new System.EventHandler(this.naimen_Box_SelectedIndexChanged);
            // 
            // protocolNum
            // 
            this.protocolNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocolNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNum.Location = new System.Drawing.Point(267, 116);
            this.protocolNum.Margin = new System.Windows.Forms.Padding(2);
            this.protocolNum.Name = "protocolNum";
            this.protocolNum.Size = new System.Drawing.Size(250, 29);
            this.protocolNum.TabIndex = 63;
            this.protocolNum.TextChanged += new System.EventHandler(this.protocol_num_TextChanged);
            // 
            // protocolLabel
            // 
            this.protocolLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolLabel.Location = new System.Drawing.Point(44, 121);
            this.protocolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(126, 24);
            this.protocolLabel.TabIndex = 62;
            this.protocolLabel.Text = "№Протокола";
            this.protocolLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(650, 666);
            this.Controls.Add(this.protocolNum);
            this.Controls.Add(this.protocolLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.measuringBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.newdateLabel);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.belongLabel);
            this.Controls.Add(this.belongBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateWork);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.attestatLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "certificate";
            this.Text = "Создание аттестата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.certificate_FormClosing);
            this.Load += new System.EventHandler(this.Attestat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label attestatLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateWork;
        private System.Windows.Forms.Label belongLabel;
        private System.Windows.Forms.ComboBox belongBox;
        private System.Windows.Forms.Label newdateLabel;
        private System.Windows.Forms.DateTimePicker newDate;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox measuringBox;
        private System.Windows.Forms.TextBox protocolNum;
        private System.Windows.Forms.Label protocolLabel;
    }
}