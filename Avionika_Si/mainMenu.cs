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
    public partial class mainMenu : Form
    {
        private void MainMenu_Load(object sender, EventArgs e)
        {


        }
        public mainMenu()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Card_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            measuringInstrument F = new measuringInstrument();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void toPasp_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            passport F = new passport();
            F.Show();
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            schedule F = new schedule();
            F.Show();
        }

        private void Journal_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            journal F = new journal();
            F.Show();
        }

        private void Protocol_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            protocol F = new protocol();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            certificate F = new certificate();
            F.Show();
        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
