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

        private void Card_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeasuringInstrumentDGV F = new MeasuringInstrumentDGV();
            F.ShowDialog();
            this.Show();
        }


        private void toPasp_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassportForm F = new PassportForm();
            F.Show();
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleView F = new ScheduleView();
            F.ShowDialog();
            this.Show();
        }

        private void Journal_Button_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            JournalForm F = new JournalForm();
            F.ShowDialog();
            this.Show();*/
            OpenFormAsDialog(new JournalForm());
        }

        private void Protocol_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProtocolForm F = new ProtocolForm();
            F.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Certificate F = new Certificate();
            F.Show();
        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
