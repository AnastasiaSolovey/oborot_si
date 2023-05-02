namespace Oborot_SI
{
    partial class ScheduleDGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleDGV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.invent_Box = new System.Windows.Forms.TextBox();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.zavod_Box = new System.Windows.Forms.TextBox();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakluch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.invent_Box);
            this.groupBox1.Controls.Add(this.factoryLabel);
            this.groupBox1.Controls.Add(this.zavod_Box);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 107);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр по номеру";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(5, 32);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 43;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // invent_Box
            // 
            this.invent_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invent_Box.Location = new System.Drawing.Point(187, 26);
            this.invent_Box.Margin = new System.Windows.Forms.Padding(2);
            this.invent_Box.Name = "invent_Box";
            this.invent_Box.Size = new System.Drawing.Size(177, 22);
            this.invent_Box.TabIndex = 50;
            // 
            // factoryLabel
            // 
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(5, 74);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 45;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // zavod_Box
            // 
            this.zavod_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavod_Box.Location = new System.Drawing.Point(187, 68);
            this.zavod_Box.Margin = new System.Windows.Forms.Padding(2);
            this.zavod_Box.Name = "zavod_Box";
            this.zavod_Box.Size = new System.Drawing.Size(177, 22);
            this.zavod_Box.TabIndex = 49;
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naimenovanie,
            this.dataGridViewTextBoxColumn1,
            this.invent_nomer,
            this.zavod_nomer,
            this.Column3,
            this.Column1,
            this.Jh,
            this.Column4,
            this.Column5,
            this.Zakluch,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.scheduleGridView.Location = new System.Drawing.Point(26, 124);
            this.scheduleGridView.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.ReadOnly = true;
            this.scheduleGridView.RowHeadersWidth = 51;
            this.scheduleGridView.RowTemplate.Height = 24;
            this.scheduleGridView.Size = new System.Drawing.Size(1387, 398);
            this.scheduleGridView.TabIndex = 44;
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.ReadOnly = true;
            this.naimenovanie.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // invent_nomer
            // 
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.ReadOnly = true;
            this.invent_nomer.Width = 125;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.ReadOnly = true;
            this.zavod_nomer.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Периодичность";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Jh
            // 
            this.Jh.HeaderText = "Место проведения";
            this.Jh.MinimumWidth = 6;
            this.Jh.Name = "Jh";
            this.Jh.ReadOnly = true;
            this.Jh.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата следующей работы";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Следующее место проведения";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Zakluch
            // 
            this.Zakluch.HeaderText = "Заключение";
            this.Zakluch.MinimumWidth = 6;
            this.Zakluch.Name = "Zakluch";
            this.Zakluch.ReadOnly = true;
            this.Zakluch.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Вид работы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ScheduleDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1434, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scheduleGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScheduleDGV";
            this.Text = "Просмотр графика";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox invent_Box;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox zavod_Box;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zakluch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}