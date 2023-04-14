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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using Avionika_Si;


namespace Oborot_SI
{
    public partial class Certificate : Form
    {

        public Word.Application wordApp = new Word.Application();
        Word.Document document2;
        Object typeTrue = true;

        public Certificate()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
        string name = "";
        private void Replace(string zam, string text, Word.Document word)
        {
            var range = word.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: zam, ReplaceWith: text);
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text) &&
   !string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text))

            {
                BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select id_protocol, naimenovanie, invent_nomer, zavod_nomer, prinadlejnost, journals.data, graphic.data, surname From si_card join journals on journals.id_si=si_card.id_si join graphic on graphic.id_si=si_card.id_si join protocol on protocol.id_si=si_card.id_si join sotrudnik on sotrudnik.id_sotrudnik=protocol.id_sotrudnik where id_protocol="+protocolNum.Text+ " Limit 1";
                MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    protocolNum.Text = sqlDataReader[0].ToString();
                    measuringBox.Text = sqlDataReader[1].ToString();
                    inventoryBox.Text = sqlDataReader[2].ToString();
                    factoryBox.Text = sqlDataReader[3].ToString();
                    belongBox.Text = sqlDataReader[4].ToString();
                    dateWork.Text = sqlDataReader[5].ToString();
                    newDate.Text = sqlDataReader[6].ToString();
                    employeeBox.Text = sqlDataReader[7].ToString();
                

                }

                else

                    MessageBox.Show("Такого средства измерения нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnDB.CloseConnection();

            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();

        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            BD ConnDB1 = new BD();
            ConnDB1.openConnection();
            string request1 = "Select vid_rabot from journals join si_card on journals.id_si=si_card.id_si join protocol on protocol.id_si=si_card.id_si where id_protocol=@id_protocol";
            MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
            Nado1.Parameters.Add("@id_protocol", MySqlDbType.VarChar).Value = protocolNum.Text;
            MySqlDataReader sqlData1 = Nado1.ExecuteReader();
            sqlData1.Read();
            if (sqlData1.HasRows)
            {
                if (sqlData1[0].ToString() == "Калибровка")
                {
                    wordApp.Visible = true;
                    document2 = wordApp.Documents.OpenNoRepairDialog("E:\\Практика на предприятии Авионика\\3 практика\\Аттестат калибровки.docx");
                    Replace("{id_protocol}", protocolNum.Text, document2);
                    Replace("{naimenovanie}", measuringBox.Text, document2);
                    Replace("{zavod_nomer}", inventoryBox.Text, document2);
                    Replace("{invent_nomer}", factoryBox.Text, document2);
                    Replace("{prinadl}", belongBox.Text, document2);
                    Replace("{data}", dateWork.Text, document2);
                    Replace("{new_data}", newDate.Text, document2);
                    Replace("{surname}", employeeBox.Text, document2);

                    document2.SaveAs2("E:\\Практика на предприятии Авионика\\3 практика\\Новый Аттестат калибровки.docx");
                    document2 = wordApp.Documents.OpenNoRepairDialog("E:\\Практика на предприятии Авионика\\3 практика\\Новый Аттестат калибровки.docx");
                    document2.Activate();
                }
                if (sqlData1[0].ToString() == "Поверка")
                {
                    wordApp.Visible = true;
                    document2 = wordApp.Documents.OpenNoRepairDialog("E:\\Практика на предприятии Авионика\\3 практика\\Аттестат поверки.docx");
                    Replace("{id_protocol}", protocolNum.Text, document2);
                    Replace("{naimenovanie}", measuringBox.Text, document2);
                    Replace("{zavod_nomer}", inventoryBox.Text, document2);
                    Replace("{invent_nomer}", factoryBox.Text, document2);
                    Replace("{prinadl}", belongBox.Text, document2);
                    Replace("{data}", dateWork.Text, document2);
                    Replace("{new_data}", newDate.Text, document2);
                    Replace("{surname}", employeeBox.Text, document2);

                    document2.SaveAs2("E:\\Практика на предприятии Авионика\\3 практика\\Новый Аттестат поверки.docx");
                    document2 = wordApp.Documents.OpenNoRepairDialog("E:\\Практика на предприятии Авионика\\3 практика\\Новый Аттестат поверки.docx");
                    document2.Activate();
                }
                if (sqlData1[0].ToString() == "Проверка")
                {
                    wordApp.Visible = true;
                    document2 = wordApp.Documents.OpenNoRepairDialog("E:\\Практика на предприятии Авионика\\3 практика\\Аттестат проверки.docx");
                    Replace("{id_protocol}", protocolNum.Text, document2);
                    Replace("{naimenovanie}", measuringBox.Text, document2);
                    Replace("{zavod_nomer}", inventoryBox.Text, document2);
                    Replace("{invent_nomer}", factoryBox.Text, document2);
                    Replace("{prinadl}", belongBox.Text, document2);
                    Replace("{data}", dateWork.Text, document2);
                    Replace("{new_data}", newDate.Text, document2);
                    Replace("{surname}", employeeBox.Text, document2);

                    document2.SaveAs2("E:\\Практика на предприятии Авионика\\3 практика\\Новый Аттестат проверки.docx");
                    document2 = wordApp.Documents.OpenNoRepairDialog("E:\\Практика на предприятии Авионика\\3 практика\\Новый Аттестат проверки.docx");
                    document2.Activate();
                }
            }
            
        }

        private void Attestat_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void zavod_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void invent_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void prinadl_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void new_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sotrudnik_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void naimen_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void protocol_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void certificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }
    }
}
