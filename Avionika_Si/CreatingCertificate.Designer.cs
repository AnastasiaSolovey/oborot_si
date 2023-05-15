﻿namespace Avionika_Si
{
    partial class CreatingCertificate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CertificateGridView = new System.Windows.Forms.DataGridView();
            this.NumProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinadlejnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.factoryBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CertificateGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CertificateGridView
            // 
            this.CertificateGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CertificateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CertificateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumProtocol,
            this.naimenovanie,
            this.zavod_nomer,
            this.invent_nomer,
            this.prinadlejnost,
            this.Column1,
            this.NewData,
            this.EmployeeName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CertificateGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.CertificateGridView.Location = new System.Drawing.Point(12, 148);
            this.CertificateGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CertificateGridView.Name = "CertificateGridView";
            this.CertificateGridView.ReadOnly = true;
            this.CertificateGridView.RowHeadersWidth = 51;
            this.CertificateGridView.RowTemplate.Height = 24;
            this.CertificateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CertificateGridView.Size = new System.Drawing.Size(1189, 365);
            this.CertificateGridView.TabIndex = 24;
            this.CertificateGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CertificateGridView_CellDoubleClick);
            // 
            // NumProtocol
            // 
            this.NumProtocol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumProtocol.HeaderText = "Номер в протоколе";
            this.NumProtocol.Name = "NumProtocol";
            this.NumProtocol.ReadOnly = true;
            this.NumProtocol.Width = 120;
            // 
            // naimenovanie
            // 
            this.naimenovanie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.ReadOnly = true;
            this.naimenovanie.Width = 108;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.ReadOnly = true;
            this.zavod_nomer.Width = 112;
            // 
            // invent_nomer
            // 
            this.invent_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.ReadOnly = true;
            this.invent_nomer.Width = 124;
            // 
            // prinadlejnost
            // 
            this.prinadlejnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prinadlejnost.HeaderText = "Принадлежность";
            this.prinadlejnost.MinimumWidth = 6;
            this.prinadlejnost.Name = "prinadlejnost";
            this.prinadlejnost.ReadOnly = true;
            this.prinadlejnost.Width = 119;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // NewData
            // 
            this.NewData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NewData.HeaderText = "Действителен до";
            this.NewData.MinimumWidth = 6;
            this.NewData.Name = "NewData";
            this.NewData.ReadOnly = true;
            this.NewData.Width = 110;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.HeaderText = "Ответственный";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inventoryBox);
            this.groupBox1.Controls.Add(this.factoryBox);
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 130);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите средство измерения";
            // 
            // inventoryBox
            // 
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryBox.Location = new System.Drawing.Point(5, 91);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(250, 22);
            this.inventoryBox.TabIndex = 41;
            this.inventoryBox.TextChanged += new System.EventHandler(this.inventoryBox_TextChanged);
            // 
            // factoryBox
            // 
            this.factoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryBox.Location = new System.Drawing.Point(5, 39);
            this.factoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(250, 22);
            this.factoryBox.TabIndex = 40;
            this.factoryBox.TextChanged += new System.EventHandler(this.factoryBox_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(5, 73);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // factoryLabel
            // 
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(2, 21);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 25;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLabel.Location = new System.Drawing.Point(330, 196);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(0, 20);
            this.chooseLabel.TabIndex = 44;
            // 
            // CreatingCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.CertificateGridView);
            this.Name = "CreatingCertificate";
            this.Text = "Метрология - создание аттестата";
            this.Load += new System.EventHandler(this.CreatingCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CertificateGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CertificateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinadlejnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox factoryBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.Label chooseLabel;
    }
}