using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avionika_Si;
using MySql.Data.MySqlClient;
using Oborot_SI;

namespace Avionika_Si
{
    public partial class SelectionScheduleMenu : Form
    {
        public SelectionScheduleMenu()
        {
            InitializeComponent();
        }
        private void OpenFormAsDialog(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void ShowFormScheduleCalibrationDGV_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new ScheduleCalibrationDGV());
        }

        private void ShowFormScheduleVerificationDGV_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new ScheduleVerificationDGV());
        }
    }
}
