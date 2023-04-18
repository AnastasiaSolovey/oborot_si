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
            //Width = Screen.PrimaryScreen.Bounds.Width;
            //Height = Screen.PrimaryScreen.Bounds.Height;

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
            passportGridView.Rows.Clear();
            BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select naimenovanie, tip, firma, invent_nomer, zavod_nomer, prinadlejnost, data, zakluchenie, vid_rabot From si_card join journals on si_card.id_si=journals.id_si where invent_nomer=@invent_nomer and zavod_nomer=@zavod_nomer Order By data";
            MySqlCommand Nado1 = new MySqlCommand(request, ConnDB.getConnection());
            Nado1.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = inventoryBox.Text;
            Nado1.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = factoryBox.Text;
            MySqlDataReader reader = Nado1.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[12]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
      


                }
                reader.Close();
                ConnDB.CloseConnection();
                foreach (string[] s in data)
                    passportGridView.Rows.Add(s);

            
        }

        private void passport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }
    }
}
