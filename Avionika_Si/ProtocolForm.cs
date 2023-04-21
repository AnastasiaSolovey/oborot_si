﻿using System;
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
    public partial class protocol : Form
    {
        public protocol()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();

        }
        private void InitEmployeeBox()
        {
            employeeBox.DataSource = Program.DbHelper.GetEmployee();
            employeeBox.DisplayMember = "name" + "surname" + "patronymic";
            employeeBox.ValueMember = "ID";
        }
        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text) &&
  !string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text))

            {
              /*  BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select id_raboti from journals join si_card on journals.id_si=si_card.id_si where zavod_nomer='" + factoryBox.Text + "' and invent_nomer= '" + inventoryBox.Text + "' Order by id_raboti DESC";
                MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    idProtocolBox.Text = sqlDataReader[0].ToString();

                }

                else

                    MessageBox.Show("Такого средства измерения нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnDB.CloseConnection();*/
            }
        }

        private void Protocol_Load(object sender, EventArgs e)
        {
            InitEmployeeBox();

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text) &&
                   !string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text)
                   &&
                   !string.IsNullOrEmpty(idProtocolBox.Text) && !string.IsNullOrWhiteSpace(idProtocolBox.Text))
            {
                 /*   BD bb = new BD();
                MySqlCommand Komand = new MySqlCommand("INSERT INTO protocol VALUES (@id_protocol, @id_si, @primechanie, (Select sotrudnik.id_sotrudnik from sotrudnik where CONCAT(surname, ' ',name, ' ',  patronymic) = @id_sotrudnik))", bb.getConnection());
                    Komand.Parameters.Add("@id_protocol", MySqlDbType.Int64).Value = idProtocolBox.Text;
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
                    Komand.Parameters.Add("@primechanie", MySqlDbType.VarChar).Value = descriptionBox.Text;
                    Komand.Parameters.Add("@id_sotrudnik", MySqlDbType.VarChar).Value = employeeBox.Text;

                    bb.openConnection();
                try 
                {
                    if (Komand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись добавлена");

                    }

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Запись не добавлена. В базу данных уже внесены данные об этом устройстве", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bb.CloseConnection();
                }
                 */   
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            inventoryBox.Text = "0";
            factoryBox.Text = "0";
            idProtocolBox.Text = "0";
            descriptionBox.Clear();
        }

        private void protocol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}