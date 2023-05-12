namespace Avionika_Si
{
    partial class SelectionScheduleMenu
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
            this.ShowFormScheduleCalibrationDGV = new System.Windows.Forms.Button();
            this.ShowFormScheduleVerificationDGV = new System.Windows.Forms.Button();
            this.mainmenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowFormScheduleCalibrationDGV
            // 
            this.ShowFormScheduleCalibrationDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowFormScheduleCalibrationDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFormScheduleCalibrationDGV.Location = new System.Drawing.Point(38, 84);
            this.ShowFormScheduleCalibrationDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ShowFormScheduleCalibrationDGV.Name = "ShowFormScheduleCalibrationDGV";
            this.ShowFormScheduleCalibrationDGV.Size = new System.Drawing.Size(170, 53);
            this.ShowFormScheduleCalibrationDGV.TabIndex = 8;
            this.ShowFormScheduleCalibrationDGV.Text = "Просмотр графика калибровки/проверки";
            this.ShowFormScheduleCalibrationDGV.UseVisualStyleBackColor = true;
            this.ShowFormScheduleCalibrationDGV.Click += new System.EventHandler(this.ShowFormScheduleCalibrationDGV_Click);
            // 
            // ShowFormScheduleVerificationDGV
            // 
            this.ShowFormScheduleVerificationDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowFormScheduleVerificationDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFormScheduleVerificationDGV.Location = new System.Drawing.Point(253, 84);
            this.ShowFormScheduleVerificationDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ShowFormScheduleVerificationDGV.Name = "ShowFormScheduleVerificationDGV";
            this.ShowFormScheduleVerificationDGV.Size = new System.Drawing.Size(170, 53);
            this.ShowFormScheduleVerificationDGV.TabIndex = 9;
            this.ShowFormScheduleVerificationDGV.Text = "Просмотр графика поверки";
            this.ShowFormScheduleVerificationDGV.UseVisualStyleBackColor = true;
            this.ShowFormScheduleVerificationDGV.Click += new System.EventHandler(this.ShowFormScheduleVerificationDGV_Click);
            // 
            // mainmenuLabel
            // 
            this.mainmenuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainmenuLabel.AutoSize = true;
            this.mainmenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainmenuLabel.Location = new System.Drawing.Point(84, 38);
            this.mainmenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainmenuLabel.Name = "mainmenuLabel";
            this.mainmenuLabel.Size = new System.Drawing.Size(279, 29);
            this.mainmenuLabel.TabIndex = 11;
            this.mainmenuLabel.Text = "Выберите вид графика";
            // 
            // SelectionScheduleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 174);
            this.Controls.Add(this.mainmenuLabel);
            this.Controls.Add(this.ShowFormScheduleVerificationDGV);
            this.Controls.Add(this.ShowFormScheduleCalibrationDGV);
            this.Name = "SelectionScheduleMenu";
            this.Text = "Метрология - выбор графика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowFormScheduleCalibrationDGV;
        private System.Windows.Forms.Button ShowFormScheduleVerificationDGV;
        private System.Windows.Forms.Label mainmenuLabel;
    }
}