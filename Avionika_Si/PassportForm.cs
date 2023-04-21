using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Avionika_Si;

namespace Oborot_SI
{
    public partial class passport : Form
    {
        public passport()
        {
            InitializeComponent();


        }

        private void Pasport_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pasport_Load(object sender, EventArgs e)
        {
          

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
   
                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

            
        }

        private void passport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }
    }
}
