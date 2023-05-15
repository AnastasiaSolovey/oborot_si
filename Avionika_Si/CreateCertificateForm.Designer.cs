namespace Oborot_SI
{
    partial class CreateCertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCertificateForm));
            this.dateLabel = new System.Windows.Forms.Label();
            this.belongLabel = new System.Windows.Forms.Label();
            this.newdateLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.factoryLabel = new System.Windows.Forms.Label();
            this.InventoryNumBox = new System.Windows.Forms.TextBox();
            this.protocolLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.FactoryNumBox = new System.Windows.Forms.TextBox();
            this.NameMeasuringInstrumentBox = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.EmployeeBox = new System.Windows.Forms.TextBox();
            this.NumProtocolBox = new System.Windows.Forms.TextBox();
            this.oldDateTextBox = new System.Windows.Forms.TextBox();
            this.newDateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(8, 315);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 16);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "Дата работы";
            // 
            // belongLabel
            // 
            this.belongLabel.AutoSize = true;
            this.belongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belongLabel.Location = new System.Drawing.Point(8, 255);
            this.belongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.belongLabel.Name = "belongLabel";
            this.belongLabel.Size = new System.Drawing.Size(119, 16);
            this.belongLabel.TabIndex = 50;
            this.belongLabel.Text = "Принадлежность";
            // 
            // newdateLabel
            // 
            this.newdateLabel.AutoSize = true;
            this.newdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newdateLabel.Location = new System.Drawing.Point(8, 372);
            this.newdateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newdateLabel.Name = "newdateLabel";
            this.newdateLabel.Size = new System.Drawing.Size(120, 16);
            this.newdateLabel.TabIndex = 55;
            this.newdateLabel.Text = "Действителен до";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(8, 433);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(110, 16);
            this.employeeLabel.TabIndex = 56;
            this.employeeLabel.Text = "Ответственный";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(11, 493);
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
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(8, 197);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 16);
            this.nameLabel.TabIndex = 61;
            this.nameLabel.Text = "Наименование СИ";
            // 
            // factoryLabel
            // 
            this.factoryLabel.AutoSize = true;
            this.factoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factoryLabel.Location = new System.Drawing.Point(8, 135);
            this.factoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(122, 16);
            this.factoryLabel.TabIndex = 45;
            this.factoryLabel.Text = "Заводской номер";
            // 
            // InventoryNumBox
            // 
            this.InventoryNumBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InventoryNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryNumBox.Location = new System.Drawing.Point(11, 91);
            this.InventoryNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryNumBox.Name = "InventoryNumBox";
            this.InventoryNumBox.ReadOnly = true;
            this.InventoryNumBox.Size = new System.Drawing.Size(290, 22);
            this.InventoryNumBox.TabIndex = 43;
            // 
            // protocolLabel
            // 
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolLabel.Location = new System.Drawing.Point(8, 20);
            this.protocolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(93, 16);
            this.protocolLabel.TabIndex = 62;
            this.protocolLabel.Text = "№Протокола";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.Location = new System.Drawing.Point(8, 73);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(141, 16);
            this.inventoryLabel.TabIndex = 42;
            this.inventoryLabel.Text = "Инвентарный номер";
            // 
            // FactoryNumBox
            // 
            this.FactoryNumBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FactoryNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryNumBox.Location = new System.Drawing.Point(11, 153);
            this.FactoryNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.FactoryNumBox.Name = "FactoryNumBox";
            this.FactoryNumBox.ReadOnly = true;
            this.FactoryNumBox.Size = new System.Drawing.Size(290, 22);
            this.FactoryNumBox.TabIndex = 44;
            // 
            // NameMeasuringInstrumentBox
            // 
            this.NameMeasuringInstrumentBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameMeasuringInstrumentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameMeasuringInstrumentBox.Location = new System.Drawing.Point(11, 215);
            this.NameMeasuringInstrumentBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameMeasuringInstrumentBox.Name = "NameMeasuringInstrumentBox";
            this.NameMeasuringInstrumentBox.ReadOnly = true;
            this.NameMeasuringInstrumentBox.Size = new System.Drawing.Size(290, 22);
            this.NameMeasuringInstrumentBox.TabIndex = 64;
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DepartmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentBox.Location = new System.Drawing.Point(11, 273);
            this.DepartmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.ReadOnly = true;
            this.DepartmentBox.Size = new System.Drawing.Size(290, 22);
            this.DepartmentBox.TabIndex = 65;
            // 
            // EmployeeBox
            // 
            this.EmployeeBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeBox.Location = new System.Drawing.Point(11, 451);
            this.EmployeeBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeBox.Name = "EmployeeBox";
            this.EmployeeBox.ReadOnly = true;
            this.EmployeeBox.Size = new System.Drawing.Size(290, 22);
            this.EmployeeBox.TabIndex = 66;
            // 
            // NumProtocolBox
            // 
            this.NumProtocolBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumProtocolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumProtocolBox.Location = new System.Drawing.Point(11, 38);
            this.NumProtocolBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumProtocolBox.Name = "NumProtocolBox";
            this.NumProtocolBox.ReadOnly = true;
            this.NumProtocolBox.Size = new System.Drawing.Size(290, 22);
            this.NumProtocolBox.TabIndex = 67;
            // 
            // oldDateTextBox
            // 
            this.oldDateTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oldDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldDateTextBox.Location = new System.Drawing.Point(11, 333);
            this.oldDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldDateTextBox.Name = "oldDateTextBox";
            this.oldDateTextBox.ReadOnly = true;
            this.oldDateTextBox.Size = new System.Drawing.Size(290, 22);
            this.oldDateTextBox.TabIndex = 68;
            // 
            // newDateTextBox
            // 
            this.newDateTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDateTextBox.Location = new System.Drawing.Point(11, 390);
            this.newDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newDateTextBox.Name = "newDateTextBox";
            this.newDateTextBox.ReadOnly = true;
            this.newDateTextBox.Size = new System.Drawing.Size(290, 22);
            this.newDateTextBox.TabIndex = 69;
            // 
            // CreateCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(312, 549);
            this.Controls.Add(this.newDateTextBox);
            this.Controls.Add(this.oldDateTextBox);
            this.Controls.Add(this.NumProtocolBox);
            this.Controls.Add(this.EmployeeBox);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.NameMeasuringInstrumentBox);
            this.Controls.Add(this.factoryLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.protocolLabel);
            this.Controls.Add(this.FactoryNumBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.InventoryNumBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.newdateLabel);
            this.Controls.Add(this.belongLabel);
            this.Controls.Add(this.dateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateCertificateForm";
            this.Text = "Метрология - создание аттестата";
            this.Load += new System.EventHandler(this.Attestat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label belongLabel;
        private System.Windows.Forms.Label newdateLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label factoryLabel;
        private System.Windows.Forms.TextBox InventoryNumBox;
        private System.Windows.Forms.Label protocolLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox FactoryNumBox;
        private System.Windows.Forms.TextBox NameMeasuringInstrumentBox;
        private System.Windows.Forms.TextBox DepartmentBox;
        private System.Windows.Forms.TextBox EmployeeBox;
        private System.Windows.Forms.TextBox NumProtocolBox;
        private System.Windows.Forms.TextBox oldDateTextBox;
        private System.Windows.Forms.TextBox newDateTextBox;
    }
}