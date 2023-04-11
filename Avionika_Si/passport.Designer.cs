namespace Oborot_SI
{
    partial class passport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passport));
            this.passportLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.passportGridView = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinadlejnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakluch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.passportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passportLabel
            // 
            this.passportLabel.AutoSize = true;
            this.passportLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportLabel.Location = new System.Drawing.Point(20, 23);
            this.passportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(150, 33);
            this.passportLabel.TabIndex = 4;
            this.passportLabel.Text = "ПАСПОРТ";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(16, 155);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(195, 24);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // passportGridView
            // 
            this.passportGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naimenovanie,
            this.dataGridViewTextBoxColumn1,
            this.firma,
            this.invent_nomer,
            this.zavod_nomer,
            this.prinadlejnost,
            this.Column1,
            this.Zakluch,
            this.Column2});
            this.passportGridView.Location = new System.Drawing.Point(9, 342);
            this.passportGridView.Margin = new System.Windows.Forms.Padding(2);
            this.passportGridView.Name = "passportGridView";
            this.passportGridView.RowHeadersWidth = 51;
            this.passportGridView.RowTemplate.Height = 24;
            this.passportGridView.Size = new System.Drawing.Size(797, 207);
            this.passportGridView.TabIndex = 23;
            this.passportGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pasport_GridView_CellContentClick);
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // firma
            // 
            this.firma.HeaderText = "Фирма";
            this.firma.MinimumWidth = 6;
            this.firma.Name = "firma";
            this.firma.Width = 125;
            // 
            // invent_nomer
            // 
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.Width = 125;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.Width = 125;
            // 
            // prinadlejnost
            // 
            this.prinadlejnost.HeaderText = "Принадлежность";
            this.prinadlejnost.MinimumWidth = 6;
            this.prinadlejnost.Name = "prinadlejnost";
            this.prinadlejnost.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Zakluch
            // 
            this.Zakluch.HeaderText = "Заключение";
            this.Zakluch.MinimumWidth = 6;
            this.Zakluch.Name = "Zakluch";
            this.Zakluch.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вид работы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // factoryLabel
            // 
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(16, 212);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(170, 24);
            this.factoryLabel.TabIndex = 25;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewButton.Location = new System.Drawing.Point(252, 270);
            this.viewButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(154, 54);
            this.viewButton.TabIndex = 31;
            this.viewButton.Text = "Просмотреть данные";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(9, 562);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 46);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLabel.Location = new System.Drawing.Point(20, 76);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(363, 33);
            this.chooseLabel.TabIndex = 33;
            this.chooseLabel.Text = "ВЫБЕРИТЕ УСТРОЙСТВО";
            // 
            // factoryBox
            // 
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(252, 207);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(250, 29);
            this.factoryBox.TabIndex = 40;
            this.factoryBox.Text = "0";
            // 
            // inventoryBox
            // 
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(252, 150);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(250, 29);
            this.inventoryBox.TabIndex = 41;
            this.inventoryBox.Text = "0";
            // 
            // passport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(815, 618);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.passportGridView);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.passportLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "passport";
            this.Text = "Заполнение папорта СИ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.passport_FormClosing);
            this.Load += new System.EventHandler(this.Pasport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.DataGridView passportGridView;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinadlejnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zakluch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}