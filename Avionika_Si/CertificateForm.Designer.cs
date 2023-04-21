namespace Oborot_SI
{
    partial class Certificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificate));
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.measuringBox = new System.Windows.Forms.ComboBox();
            this.protocolNum = new System.Windows.Forms.TextBox();
            this.protocolLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(16, 189);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 32);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(13, 141);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 45;
            this.factoryLabel.Text = "Заводской номер";
            this.factoryLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(16, 159);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.ReadOnly = true;
            this.factoryBox.Size = new System.Drawing.Size(250, 22);
            this.factoryBox.TabIndex = 44;
            this.factoryBox.Text = "0";
            this.factoryBox.TextChanged += new System.EventHandler(this.zavod_Box_TextChanged);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(16, 103);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.ReadOnly = true;
            this.inventoryBox.Size = new System.Drawing.Size(250, 22);
            this.inventoryBox.TabIndex = 43;
            this.inventoryBox.Text = "0";
            this.inventoryBox.TextChanged += new System.EventHandler(this.invent_Box_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(13, 85);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 42;
            this.inventoryLabel.Text = "Инвентарный номер";
            this.inventoryLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(33, 383);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 16);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "Дата работы";
            this.dateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateWork
            // 
            this.dateWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateWork.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateWork.Enabled = false;
            this.dateWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateWork.Location = new System.Drawing.Point(36, 401);
            this.dateWork.Margin = new System.Windows.Forms.Padding(2);
            this.dateWork.Name = "dateWork";
            this.dateWork.Size = new System.Drawing.Size(250, 22);
            this.dateWork.TabIndex = 47;
            this.dateWork.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // belongLabel
            // 
            this.belongLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.belongLabel.AutoSize = true;
            this.belongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongLabel.Location = new System.Drawing.Point(33, 323);
            this.belongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.belongLabel.Name = "belongLabel";
            this.belongLabel.Size = new System.Drawing.Size(119, 16);
            this.belongLabel.TabIndex = 50;
            this.belongLabel.Text = "Принадлежность";
            this.belongLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // belongBox
            // 
            this.belongBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.belongBox.DisplayMember = "prinadlejnost";
            this.belongBox.Enabled = false;
            this.belongBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongBox.FormattingEnabled = true;
            this.belongBox.Location = new System.Drawing.Point(36, 341);
            this.belongBox.Margin = new System.Windows.Forms.Padding(2);
            this.belongBox.Name = "belongBox";
            this.belongBox.Size = new System.Drawing.Size(250, 24);
            this.belongBox.TabIndex = 49;
            this.belongBox.ValueMember = "prinadlejnost";
            this.belongBox.SelectedIndexChanged += new System.EventHandler(this.prinadl_Box_SelectedIndexChanged);
            // 
            // newdateLabel
            // 
            this.newdateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newdateLabel.AutoSize = true;
            this.newdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newdateLabel.Location = new System.Drawing.Point(33, 440);
            this.newdateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newdateLabel.Name = "newdateLabel";
            this.newdateLabel.Size = new System.Drawing.Size(120, 16);
            this.newdateLabel.TabIndex = 55;
            this.newdateLabel.Text = "Действителен до";
            this.newdateLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // newDate
            // 
            this.newDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newDate.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDate.Enabled = false;
            this.newDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDate.Location = new System.Drawing.Point(36, 458);
            this.newDate.Margin = new System.Windows.Forms.Padding(2);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(250, 22);
            this.newDate.TabIndex = 54;
            this.newDate.ValueChanged += new System.EventHandler(this.new_date_ValueChanged);
            // 
            // employeeBox
            // 
            this.employeeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeBox.DisplayMember = "surname";
            this.employeeBox.Enabled = false;
            this.employeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(36, 519);
            this.employeeBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(250, 24);
            this.employeeBox.TabIndex = 57;
            this.employeeBox.ValueMember = "id_sotrudnik";
            this.employeeBox.SelectedIndexChanged += new System.EventHandler(this.sotrudnik_Box_SelectedIndexChanged);
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(33, 501);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(110, 16);
            this.employeeLabel.TabIndex = 56;
            this.employeeLabel.Text = "Ответственный";
            this.employeeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(36, 561);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(189, 46);
            this.createButton.TabIndex = 58;
            this.createButton.Text = "Создать аттестат";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(33, 265);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 16);
            this.nameLabel.TabIndex = 61;
            this.nameLabel.Text = "Наименование СИ";
            this.nameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // measuringBox
            // 
            this.measuringBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.measuringBox.DisplayMember = "naimenovanie";
            this.measuringBox.Enabled = false;
            this.measuringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measuringBox.FormattingEnabled = true;
            this.measuringBox.Location = new System.Drawing.Point(36, 283);
            this.measuringBox.Margin = new System.Windows.Forms.Padding(2);
            this.measuringBox.Name = "measuringBox";
            this.measuringBox.Size = new System.Drawing.Size(250, 24);
            this.measuringBox.TabIndex = 60;
            this.measuringBox.ValueMember = "naimenovanie";
            this.measuringBox.SelectedIndexChanged += new System.EventHandler(this.naimen_Box_SelectedIndexChanged);
            // 
            // protocolNum
            // 
            this.protocolNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocolNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNum.Location = new System.Drawing.Point(16, 45);
            this.protocolNum.Margin = new System.Windows.Forms.Padding(2);
            this.protocolNum.Name = "protocolNum";
            this.protocolNum.Size = new System.Drawing.Size(250, 22);
            this.protocolNum.TabIndex = 63;
            this.protocolNum.TextChanged += new System.EventHandler(this.protocol_num_TextChanged);
            // 
            // protocolLabel
            // 
            this.protocolLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolLabel.Location = new System.Drawing.Point(13, 27);
            this.protocolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(93, 16);
            this.protocolLabel.TabIndex = 62;
            this.protocolLabel.Text = "№Протокола";
            this.protocolLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.factoryBox);
            this.groupBox1.Controls.Add(this.protocolNum);
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.protocolLabel);
            this.groupBox1.Controls.Add(this.inventoryBox);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 236);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Средство измерения";
            // 
            // Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(368, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.measuringBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.newdateLabel);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.belongLabel);
            this.Controls.Add(this.belongBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Certificate";
            this.Text = "Создание аттестата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.certificate_FormClosing);
            this.Load += new System.EventHandler(this.Attestat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox measuringBox;
        private System.Windows.Forms.TextBox protocolNum;
        private System.Windows.Forms.Label protocolLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}