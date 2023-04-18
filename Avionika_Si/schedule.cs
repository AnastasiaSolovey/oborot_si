using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Avionika_Si;

namespace Oborot_SI
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            //Width = Screen.PrimaryScreen.Bounds.Width;
            //Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Grafic_Load(object sender, EventArgs e)
        {

            DataTable old = new DataTable();
            BD ConnDB2 = new BD();
            ConnDB2.openConnection();
            string request2 = "Select mesto_provedenia from mesto_provedenia Order by mesto_provedenia";
            MySqlCommand Nado2 = new MySqlCommand(request2, ConnDB2.getConnection());
            ConnDB2.getConnection();
            MySqlDataAdapter sqlData2 = new MySqlDataAdapter(Nado2);
            sqlData2.Fill(old);
            for (int i = 0; i < old.Rows.Count; i++)
            {
                oldVenueBox.Items.Add(old.Rows[i]["mesto_provedenia"].ToString());

            }


            DataTable neew = new DataTable();
            BD ConnDB3 = new BD();
            ConnDB3.openConnection();
            string request3 = "Select mesto_provedenia from mesto_provedenia Order by mesto_provedenia";
            MySqlCommand Nado3 = new MySqlCommand(request3, ConnDB3.getConnection());
            ConnDB3.getConnection();
            MySqlDataAdapter sqlData3 = new MySqlDataAdapter(Nado3);
            sqlData3.Fill(neew);
            for (int i = 0; i < neew.Rows.Count; i++)
            {
                newVenueBox.Items.Add(neew.Rows[i]["mesto_provedenia"].ToString());

            }

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text) &&
  !string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text))

            {
                BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select data from journals join si_card on journals.id_si=si_card.id_si where zavod_nomer='" + factoryBox.Text + "' and invent_nomer= '" + inventoryBox.Text + "' order by data DESC LIMIT 1";
                MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    var newdata = DateTime.Parse(sqlDataReader[0].ToString());
                    if (!string.IsNullOrEmpty(frequencyBox.Text) && !string.IsNullOrWhiteSpace(frequencyBox.Text))
                    {
                        Authorization.periodichnost = Convert.ToInt32(frequencyBox.Text);
                        newdata= newdata.AddMonths(Authorization.periodichnost);
                        newdata = newdata.AddDays(-1);
                        newDateBox.Text = newdata.ToString();
                        oldVenueBox.Visible = true;
                        newVenueBox.Visible = true;
                    }
                    
                }

                else

                    MessageBox.Show("Такого средства измерения нет. Проверьте, есть ли запись о данном СИ в журнале", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnDB.CloseConnection();
            }


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text) &&
                  !string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text)
                  &&
                  !string.IsNullOrEmpty(oldVenueBox.Text) && !string.IsNullOrWhiteSpace(oldVenueBox.Text)
                   &&
                  !string.IsNullOrEmpty(newVenueBox.Text) && !string.IsNullOrWhiteSpace(newVenueBox.Text))
            {


                BD bb = new BD();
                MySqlCommand Komand = new MySqlCommand("INSERT INTO graphic VALUES (0, @id_si, @periodichnost, (SELECT mesto_provedenia_id FROM mesto_provedenia where mesto_provedenia=@mesto_proved_old), @data, (SELECT mesto_provedenia_id FROM mesto_provedenia where mesto_provedenia=@mest_proved_new))", bb.getConnection());
                BD ConnDB1 = new BD();
                ConnDB1.openConnection();
                string request1 = "Select id_si from si_card where invent_nomer= '" + inventoryBox.Text + "' and zavod_nomer='" + factoryBox.Text + "'";
                MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
                Nado1.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = factoryBox.Text;
                Nado1.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = inventoryBox.Text;
                MySqlDataReader sqlData1 = Nado1.ExecuteReader();
                sqlData1.Read();
                if (sqlData1.HasRows)
                {
                    Authorization.ID_SI = Convert.ToInt32(sqlData1[0].ToString());
                }
                else MessageBox.Show("Такого СИ нет в базе данных");
                Komand.Parameters.Add("@id_si", MySqlDbType.Int64).Value = Authorization.ID_SI;
                Komand.Parameters.Add("@periodichnost", MySqlDbType.VarChar).Value = frequencyBox.Text;
                Komand.Parameters.Add("@mesto_proved_old", MySqlDbType.VarChar).Value = oldVenueBox.Text;
                Komand.Parameters.Add("@data", MySqlDbType.Date).Value = newDateBox.Value.Date;
                Komand.Parameters.Add("@mest_proved_new", MySqlDbType.VarChar).Value = newVenueBox.Text;
                bb.openConnection();
                if (Komand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");

                }
                else MessageBox.Show("Запись не добавлена");
                bb.CloseConnection();
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            inventoryBox.Text = "0";
            factoryBox.Text = "0";
            newDateBox.Value = DateTime.Now;
            newVenueBox.Items.Clear();
            oldVenueBox.Items.Clear();

            oldVenueBox.Visible = false;
            newVenueBox.Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Не забудьте сохранить данные. Вы хотите перейти к просмотру графика?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                ScheduleView F = new ScheduleView();
                F.Show();
            }
        }

        private void schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }
    }
}
