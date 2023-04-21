namespace Oborot_SI
{
    partial class MeasuringInstrumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasuringInstrumentForm));
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.rangeBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.etalonLabel = new System.Windows.Forms.Label();
            this.belongLabel = new System.Windows.Forms.Label();
            this.belongBox = new System.Windows.Forms.ComboBox();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.equipmentBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.ComboBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.EtalonStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGWMeasureViewLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBox.DisplayMember = "naimenovanie";
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(10, 91);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(261, 23);
            this.nameBox.TabIndex = 0;
            this.nameBox.ValueMember = "naimenovanie";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(8, 73);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Выбор СИ";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(8, 130);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(32, 16);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Тип";
            // 
            // rangeLabel
            // 
            this.rangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabel.Location = new System.Drawing.Point(7, 233);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(147, 16);
            this.rangeLabel.TabIndex = 5;
            this.rangeLabel.Text = "Диапазон измерения";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(-2, 13);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.Location = new System.Drawing.Point(11, 148);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(261, 21);
            this.typeBox.TabIndex = 7;
            // 
            // rangeBox
            // 
            this.rangeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeBox.Location = new System.Drawing.Point(10, 251);
            this.rangeBox.Margin = new System.Windows.Forms.Padding(2);
            this.rangeBox.Name = "rangeBox";
            this.rangeBox.Size = new System.Drawing.Size(261, 21);
            this.rangeBox.TabIndex = 8;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(1, 30);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(261, 21);
            this.inventoryBox.TabIndex = 9;
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(2, 84);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(261, 21);
            this.factoryBox.TabIndex = 10;
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(-2, 66);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 11;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // etalonLabel
            // 
            this.etalonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.etalonLabel.AutoSize = true;
            this.etalonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etalonLabel.Location = new System.Drawing.Point(7, 420);
            this.etalonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etalonLabel.Name = "etalonLabel";
            this.etalonLabel.Size = new System.Drawing.Size(56, 16);
            this.etalonLabel.TabIndex = 14;
            this.etalonLabel.Text = "Эталон";
            // 
            // belongLabel
            // 
            this.belongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.belongLabel.AutoSize = true;
            this.belongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongLabel.Location = new System.Drawing.Point(15, 687);
            this.belongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.belongLabel.Name = "belongLabel";
            this.belongLabel.Size = new System.Drawing.Size(0, 16);
            this.belongLabel.TabIndex = 16;
            // 
            // belongBox
            // 
            this.belongBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.belongBox.DisplayMember = "prinadlejnost";
            this.belongBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.belongBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongBox.FormattingEnabled = true;
            this.belongBox.Location = new System.Drawing.Point(11, 705);
            this.belongBox.Margin = new System.Windows.Forms.Padding(2);
            this.belongBox.Name = "belongBox";
            this.belongBox.Size = new System.Drawing.Size(261, 23);
            this.belongBox.TabIndex = 15;
            this.belongBox.ValueMember = "prinadlejnost";
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentLabel.Location = new System.Drawing.Point(8, 522);
            this.equipmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(101, 16);
            this.equipmentLabel.TabIndex = 18;
            this.equipmentLabel.Text = "Комплектация";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(11, 627);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(457, 47);
            this.descriptionBox.TabIndex = 19;
            this.descriptionBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(8, 609);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 16);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Описание";
            // 
            // equipmentBox
            // 
            this.equipmentBox.Location = new System.Drawing.Point(12, 540);
            this.equipmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(457, 47);
            this.equipmentBox.TabIndex = 21;
            this.equipmentBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(10, 755);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 46);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Добавить новое СИ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerBox.Location = new System.Drawing.Point(11, 198);
            this.manufacturerBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(261, 21);
            this.manufacturerBox.TabIndex = 25;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerLabel.Location = new System.Drawing.Point(7, 180);
            this.manufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(145, 16);
            this.manufacturerLabel.TabIndex = 26;
            this.manufacturerLabel.Text = "Фирма изготовитель";
            // 
            // conditionBox
            // 
            this.conditionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.conditionBox.DisplayMember = "sostoyanie";
            this.conditionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionBox.FormattingEnabled = true;
            this.conditionBox.Location = new System.Drawing.Point(12, 480);
            this.conditionBox.Margin = new System.Windows.Forms.Padding(2);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(261, 23);
            this.conditionBox.TabIndex = 27;
            this.conditionBox.ValueMember = "sostoyanie";
            // 
            // conditionLabel
            // 
            this.conditionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionLabel.Location = new System.Drawing.Point(9, 462);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(119, 16);
            this.conditionLabel.TabIndex = 28;
            this.conditionLabel.Text = "Выбор состояния";
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(279, 55);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(85, 26);
            this.Search_Button.TabIndex = 30;
            this.Search_Button.Text = "Поиск";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(189, 755);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(159, 46);
            this.updateButton.TabIndex = 32;
            this.updateButton.Text = "Обновить данные";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // EtalonStatusCheckBox
            // 
            this.EtalonStatusCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EtalonStatusCheckBox.AutoSize = true;
            this.EtalonStatusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EtalonStatusCheckBox.Location = new System.Drawing.Point(93, 420);
            this.EtalonStatusCheckBox.Name = "EtalonStatusCheckBox";
            this.EtalonStatusCheckBox.Size = new System.Drawing.Size(42, 19);
            this.EtalonStatusCheckBox.TabIndex = 33;
            this.EtalonStatusCheckBox.Text = "Да";
            this.EtalonStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 687);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Выбор отдела";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_Button);
            this.groupBox1.Controls.Add(this.factoryBox);
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.inventoryBox);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 118);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // DGWMeasureViewLabel
            // 
            this.DGWMeasureViewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGWMeasureViewLabel.AutoSize = true;
            this.DGWMeasureViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGWMeasureViewLabel.Location = new System.Drawing.Point(-1, 14);
            this.DGWMeasureViewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DGWMeasureViewLabel.Name = "DGWMeasureViewLabel";
            this.DGWMeasureViewLabel.Size = new System.Drawing.Size(304, 20);
            this.DGWMeasureViewLabel.TabIndex = 61;
            this.DGWMeasureViewLabel.TabStop = true;
            this.DGWMeasureViewLabel.Text = "Просмотреть все средства измерения";
            this.DGWMeasureViewLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DGWMeasureViewLabel_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGWMeasureViewLabel);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 43);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // MeasuringInstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(521, 824);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EtalonStatusCheckBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.conditionBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.equipmentBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.equipmentLabel);
            this.Controls.Add(this.belongLabel);
            this.Controls.Add(this.belongBox);
            this.Controls.Add(this.etalonLabel);
            this.Controls.Add(this.rangeBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MeasuringInstrumentForm";
            this.Text = "Средства измерения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.measuringInstrument_FormClosing);
            this.Load += new System.EventHandler(this.Card_si_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox rangeBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.Label etalonLabel;
        private System.Windows.Forms.Label belongLabel;
        private System.Windows.Forms.ComboBox belongBox;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox equipmentBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.ComboBox conditionBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox EtalonStatusCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel DGWMeasureViewLabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}