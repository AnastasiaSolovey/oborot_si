namespace Oborot_SI
{
    partial class MeasuringInstrument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasuringInstrument));
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.measuringsGridView = new System.Windows.Forms.DataGridView();
            this.id_si = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diapazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etalon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostoyanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komplectacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinadlejnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.ComboBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.EtalonStatusCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.measuringsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBox.DisplayMember = "naimenovanie";
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(263, 91);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(261, 32);
            this.nameBox.TabIndex = 0;
            this.nameBox.ValueMember = "naimenovanie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "СРЕДСТВА ИЗМЕРЕНИЯ";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(15, 91);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(175, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование СИ";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(15, 144);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 24);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Тип";
            // 
            // rangeLabel
            // 
            this.rangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabel.Location = new System.Drawing.Point(13, 256);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(98, 24);
            this.rangeLabel.TabIndex = 5;
            this.rangeLabel.Text = "Диапазон";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(13, 308);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(195, 24);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.Location = new System.Drawing.Point(263, 144);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(261, 29);
            this.typeBox.TabIndex = 7;
            // 
            // rangeBox
            // 
            this.rangeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeBox.Location = new System.Drawing.Point(263, 251);
            this.rangeBox.Margin = new System.Windows.Forms.Padding(2);
            this.rangeBox.Name = "rangeBox";
            this.rangeBox.Size = new System.Drawing.Size(261, 29);
            this.rangeBox.TabIndex = 8;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(263, 303);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(261, 29);
            this.inventoryBox.TabIndex = 9;
            this.inventoryBox.Text = "0";
            // 
            // factoryBox
            // 
            this.factoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(263, 357);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(261, 29);
            this.factoryBox.TabIndex = 10;
            this.factoryBox.Text = "0";
            // 
            // factoryLabel
            // 
            this.factoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(13, 357);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(170, 24);
            this.factoryLabel.TabIndex = 11;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // etalonLabel
            // 
            this.etalonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.etalonLabel.AutoSize = true;
            this.etalonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etalonLabel.Location = new System.Drawing.Point(15, 410);
            this.etalonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etalonLabel.Name = "etalonLabel";
            this.etalonLabel.Size = new System.Drawing.Size(75, 24);
            this.etalonLabel.TabIndex = 14;
            this.etalonLabel.Text = "Эталон";
            // 
            // belongLabel
            // 
            this.belongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.belongLabel.AutoSize = true;
            this.belongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongLabel.Location = new System.Drawing.Point(13, 653);
            this.belongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.belongLabel.Name = "belongLabel";
            this.belongLabel.Size = new System.Drawing.Size(166, 24);
            this.belongLabel.TabIndex = 16;
            this.belongLabel.Text = "Принадлежность";
            // 
            // belongBox
            // 
            this.belongBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.belongBox.DisplayMember = "prinadlejnost";
            this.belongBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.belongBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongBox.FormattingEnabled = true;
            this.belongBox.Location = new System.Drawing.Point(263, 648);
            this.belongBox.Margin = new System.Windows.Forms.Padding(2);
            this.belongBox.Name = "belongBox";
            this.belongBox.Size = new System.Drawing.Size(261, 29);
            this.belongBox.TabIndex = 15;
            this.belongBox.ValueMember = "prinadlejnost";
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentLabel.Location = new System.Drawing.Point(13, 522);
            this.equipmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(139, 24);
            this.equipmentLabel.TabIndex = 18;
            this.equipmentLabel.Text = "Комплектация";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(263, 578);
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
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 588);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 24);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Описание";
            // 
            // equipmentBox
            // 
            this.equipmentBox.Location = new System.Drawing.Point(263, 511);
            this.equipmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(457, 47);
            this.equipmentBox.TabIndex = 21;
            this.equipmentBox.Text = "";
            // 
            // measuringsGridView
            // 
            this.measuringsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.measuringsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.measuringsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.measuringsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.measuringsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_si,
            this.naimenovanie,
            this.tip,
            this.firma,
            this.Diapazon,
            this.invent_nomer,
            this.zavod_nomer,
            this.etalon,
            this.sostoyanie,
            this.komplectacia,
            this.opisanie,
            this.prinadlejnost});
            this.measuringsGridView.Location = new System.Drawing.Point(765, 91);
            this.measuringsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.measuringsGridView.Name = "measuringsGridView";
            this.measuringsGridView.RowHeadersWidth = 51;
            this.measuringsGridView.RowTemplate.Height = 24;
            this.measuringsGridView.Size = new System.Drawing.Size(464, 398);
            this.measuringsGridView.TabIndex = 22;
            this.measuringsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_si
            // 
            this.id_si.HeaderText = "ID СИ";
            this.id_si.MinimumWidth = 6;
            this.id_si.Name = "id_si";
            this.id_si.Width = 57;
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.Width = 108;
            // 
            // tip
            // 
            this.tip.HeaderText = "Тип";
            this.tip.MinimumWidth = 6;
            this.tip.Name = "tip";
            this.tip.Width = 51;
            // 
            // firma
            // 
            this.firma.HeaderText = "Фирма";
            this.firma.MinimumWidth = 6;
            this.firma.Name = "firma";
            this.firma.Width = 69;
            // 
            // Diapazon
            // 
            this.Diapazon.HeaderText = "Диапазон";
            this.Diapazon.MinimumWidth = 6;
            this.Diapazon.Name = "Diapazon";
            this.Diapazon.Width = 83;
            // 
            // invent_nomer
            // 
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.Width = 124;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.Width = 112;
            // 
            // etalon
            // 
            this.etalon.HeaderText = "Эталон";
            this.etalon.MinimumWidth = 6;
            this.etalon.Name = "etalon";
            this.etalon.Width = 68;
            // 
            // sostoyanie
            // 
            this.sostoyanie.HeaderText = "Состояние";
            this.sostoyanie.MinimumWidth = 6;
            this.sostoyanie.Name = "sostoyanie";
            this.sostoyanie.Width = 86;
            // 
            // komplectacia
            // 
            this.komplectacia.HeaderText = "Комплектация";
            this.komplectacia.MinimumWidth = 6;
            this.komplectacia.Name = "komplectacia";
            this.komplectacia.Width = 106;
            // 
            // opisanie
            // 
            this.opisanie.HeaderText = "Описание";
            this.opisanie.MinimumWidth = 6;
            this.opisanie.Name = "opisanie";
            this.opisanie.Width = 82;
            // 
            // prinadlejnost
            // 
            this.prinadlejnost.HeaderText = "Принадлежность";
            this.prinadlejnost.MinimumWidth = 6;
            this.prinadlejnost.Name = "prinadlejnost";
            this.prinadlejnost.Width = 119;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(201, 693);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(206, 46);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Добавить новое СИ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(15, 693);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 46);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerBox.Location = new System.Drawing.Point(263, 201);
            this.manufacturerBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(261, 29);
            this.manufacturerBox.TabIndex = 25;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerLabel.Location = new System.Drawing.Point(15, 206);
            this.manufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(71, 24);
            this.manufacturerLabel.TabIndex = 26;
            this.manufacturerLabel.Text = "Фирма";
            // 
            // conditionBox
            // 
            this.conditionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.conditionBox.DisplayMember = "sostoyanie";
            this.conditionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionBox.FormattingEnabled = true;
            this.conditionBox.Location = new System.Drawing.Point(263, 457);
            this.conditionBox.Margin = new System.Windows.Forms.Padding(2);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(261, 32);
            this.conditionBox.TabIndex = 27;
            this.conditionBox.ValueMember = "sostoyanie";
            // 
            // conditionLabel
            // 
            this.conditionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionLabel.Location = new System.Drawing.Point(15, 465);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(108, 24);
            this.conditionLabel.TabIndex = 28;
            this.conditionLabel.Text = "Состояние";
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(549, 318);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(74, 46);
            this.Search_Button.TabIndex = 30;
            this.Search_Button.Text = "Поиск";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(688, 693);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(187, 46);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "Очистить поля";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(461, 693);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(187, 46);
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
            this.EtalonStatusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EtalonStatusCheckBox.Location = new System.Drawing.Point(263, 406);
            this.EtalonStatusCheckBox.Name = "EtalonStatusCheckBox";
            this.EtalonStatusCheckBox.Size = new System.Drawing.Size(53, 28);
            this.EtalonStatusCheckBox.TabIndex = 33;
            this.EtalonStatusCheckBox.Text = "Да";
            this.EtalonStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeasuringInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1240, 792);
            this.Controls.Add(this.EtalonStatusCheckBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.conditionBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.measuringsGridView);
            this.Controls.Add(this.equipmentBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.equipmentLabel);
            this.Controls.Add(this.belongLabel);
            this.Controls.Add(this.belongBox);
            this.Controls.Add(this.etalonLabel);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.rangeBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MeasuringInstrument";
            this.Text = "Средства измерения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.measuringInstrument_FormClosing);
            this.Load += new System.EventHandler(this.Card_si_Load);
            ((System.ComponentModel.ISupportInitialize)(this.measuringsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView measuringsGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_si;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diapazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn etalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostoyanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn komplectacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinadlejnost;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.ComboBox conditionBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox EtalonStatusCheckBox;
    }
}