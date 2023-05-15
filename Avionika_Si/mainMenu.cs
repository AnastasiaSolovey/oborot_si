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

namespace Oborot_SI
{
    public partial class MainMenu : Form
    {

        private void MainMenu_Load(object sender, EventArgs e)
        {   
            
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OpenFormAsDialog(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void MeasuringInstrumentDGV_Button_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new MeasuringInstrumentDGV());
        }


        private void JournalDGV_Button_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new JournalDGV());
        }

     
        private void ScheduleDGV_Button_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new SelectionScheduleMenu());
        }


        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShowFormProtocolDGV_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new ProtocolDGV());
        }

        private void ShowFormCreatingCertificate_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new CertificateInfoViewForm());
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
