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
using Avionika_Si;
using MySql.Data.MySqlClient;
using Avionika_Si.Models;


namespace Oborot_SI
{
    public partial class MeasuringInstrument : Form
    {
        public int id { get; private set; }
        public int name { get; set; }
        public string type { get; set; }
        public string manufacturer { get; set; }
        public string measuringRange { get; set; }
        public string inventoryNumber { get; set; }
        public string factoryNumber { get; set; }
        public int etallon { get; set; }
        public int idCondition { get; set; }
        public string equipment { get; set; }
        public string description { get; set; }
        public int idBelongTo { get; set; }
      
    
        public MeasuringInstrument()
        {
            InitializeComponent();
            LoadDateGridView();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
        public MeasuringInstrument(DataRow input)
        {
         
        }
        public static int isEtalon = 0;


        private void LoadDateGridView()
        {
            /* BD ConnDB = new BD();
             ConnDB.openConnection();
             string request = "Select id_si, naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer,etalon,sostoyanie,komplectacia,opisanie,prinadlejnost From si_card Order By naimenovanie";
             MySqlCommand Reader = new MySqlCommand(request, ConnDB.getConnection());
             MySqlDataReader reader = Reader.ExecuteReader();
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
                 data[data.Count - 1][9] = reader[9].ToString();
                 data[data.Count - 1][10] = reader[10].ToString();
                 data[data.Count - 1][11] = reader[11].ToString();


             }
             reader.Close();
             ConnDB.CloseConnection();
             foreach (string[] s in data)
                 measuringsGridView.Rows.Add(s);*/

            

        }

        private void InitNameBox()
        {
            nameBox.DataSource = Program.DbHelper.GetInstrumentNames();
            nameBox.DisplayMember = "Name";
            nameBox.ValueMember = "ID";
        }

        private void InitConditionBox()
        {
            conditionBox.DataSource = Program.DbHelper.GetCondition();
            conditionBox.DisplayMember = "ConditionName";
            conditionBox.ValueMember = "ID";
        }

        private void InitBelongBox()
        {
            belongBox.DataSource = Program.DbHelper.GetBelongTo();
            belongBox.DisplayMember = "Belongs";
            belongBox.ValueMember = "ID";
        }

        private void Card_si_Load(object sender, EventArgs e)
        {
            //DataTable Naimen = new DataTable();
           // BD ConnDB1 = new BD();
           // ConnDB1.openConnection();
            //string request1 = "Select naimenovanie from naimenovanie_si Order by naimenovanie";
            //MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
           // ConnDB1.getConnection();
            //MySqlDataAdapter sqlData = new MySqlDataAdapter(Nado1);
            //sqlData.Fill(Naimen);
            /*for (int i = 0; i < Naimen.Rows.Count; i++)
            {
                nameBox.Items.Add(Naimen.Rows[i]["naimenovanie"].ToString());

            }*/

            InitNameBox();
            InitConditionBox();
            InitBelongBox();


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
  
                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text) &&
!string.IsNullOrEmpty(typeBox.Text) && !string.IsNullOrWhiteSpace(typeBox.Text)
&&
!string.IsNullOrEmpty(manufacturerBox.Text) && !string.IsNullOrWhiteSpace(manufacturerBox.Text)
&&
!string.IsNullOrEmpty(rangeBox.Text) && !string.IsNullOrWhiteSpace(rangeBox.Text)
&&
!string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text)
&&
!string.IsNullOrEmpty(conditionBox.Text) && !string.IsNullOrWhiteSpace(conditionBox.Text)
&&
!string.IsNullOrEmpty(equipmentBox.Text) && !string.IsNullOrWhiteSpace(equipmentBox.Text)
&&
!string.IsNullOrEmpty(descriptionBox.Text) && !string.IsNullOrWhiteSpace(descriptionBox.Text)
&&
!string.IsNullOrEmpty(belongBox.Text) && !string.IsNullOrWhiteSpace(belongBox.Text))

            {

               /* BD ConnDB = new BD();
                using (MySqlCommand Komand = new MySqlCommand("INSERT INTO si_card VALUES (0, @naimenovanie, @tip,@firma,@diapazon,@invent_nomer,@zavod_nomer,@etalon,@sostoyanie,@komplectacia,@opisanie,@prinadlejnost)", ConnDB.getConnection()))
                {

                    Komand.Parameters.Add("@naimenovanie", MySqlDbType.VarChar).Value = nameBox.Text;
                    Komand.Parameters.Add("@tip", MySqlDbType.VarChar).Value = typeBox.Text;
                    Komand.Parameters.Add("@firma", MySqlDbType.VarChar).Value = manufacturerBox.Text;
                    Komand.Parameters.Add("@diapazon", MySqlDbType.VarChar).Value = rangeBox.Text;
                    Komand.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = inventoryBox.Text;
                    Komand.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = factoryBox.Text;
                    Komand.Parameters.Add("@etalon", MySqlDbType.Bit).Value = isEtalon;
                    Komand.Parameters.Add("@sostoyanie", MySqlDbType.VarChar).Value = conditionBox.Text;
                    Komand.Parameters.Add("@komplectacia", MySqlDbType.Text).Value = equipmentBox.Text;
                    Komand.Parameters.Add("@opisanie", MySqlDbType.Text).Value = descriptionBox.Text;
                    Komand.Parameters.Add("@prinadlejnost", MySqlDbType.VarChar).Value = belongBox.Text;

                    ConnDB.openConnection();

                    Komand.ExecuteNonQuery();
                    MessageBox.Show("Средство измерения было добавлено в Базу данных");
                    try
                    {
                        measuringsGridView.Rows.Clear();
                        BD ConnDB1 = new BD();
                        ConnDB1.openConnection();
                        string request1 = "Select id_si, naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer,etalon,sostoyanie,komplectacia,opisanie,prinadlejnost From si_card Order By naimenovanie";
                        MySqlCommand Reader = new MySqlCommand(request1, ConnDB1.getConnection());
                        MySqlDataReader reader = Reader.ExecuteReader();
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
                            data[data.Count - 1][9] = reader[9].ToString();
                            data[data.Count - 1][10] = reader[10].ToString();
                            data[data.Count - 1][11] = reader[11].ToString();


                        }
                        reader.Close();
                        ConnDB1.CloseConnection();
                        foreach (string[] s in data)
                            measuringsGridView.Rows.Add(s);
                    }
                    catch (MySqlException isq)
                    {
                        MessageBox.Show(isq.Message);
                    }


                }
                ConnDB.CloseConnection();
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");*/

            //MeasuringInstrument MeasuringInstrument = new MeasuringInstrument
            //    (nameBox.Text, typeBox.Text, manufacturerBox.Text, rangeBox.Text, inventoryBox.Text, factoryBox.Text, isEtalon, conditionBox.Text, equipmentBox.Text, belongBox.Text);
            //int id_measuring_instrument = MeasuringInstrument.CreateExampleClass
            //(nameBox.Text, typeBox.Text, manufacturerBox.Text, rangeBox.Text, inventoryBox.Text, factoryBox.Text, isEtalon, conditionBox.Text, equipmentBox.Text, belongBox.Text);

            Avionika_Si.Models.MeasuringInstrument instrument = new Avionika_Si.Models.MeasuringInstrument()
            {
               
                InstrumentNameReferenceID = Convert.ToInt32(nameBox.SelectedValue),
                Type = typeBox.Text,
                Manufacturer = manufacturerBox.Text,
                MeasuringRange = rangeBox.Text,
                InventoryNumber = inventoryBox.Text,
                FactoryNumber = factoryBox.Text,
                Etalon = EtalonStatusCheckBox.Checked,
                ConditionReferenceId = Convert.ToInt32(conditionBox.SelectedValue),
                Equipment = equipmentBox.Text,
                BelongsToReferenceID = Convert.ToInt32(belongBox.SelectedValue)


            };

               
            if (instrument.Create())
            {
                MessageBox.Show("Средство измерения было добавлено в Базу данных");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
                this.DialogResult = DialogResult.OK;
            }
                 }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");
            /*if (id_measuring_instrument != 0)
            {
                
            }*/
            }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            BD ConnDB = new BD();
            MySqlCommand Izmenenie = new MySqlCommand("UPDATE si_card SET naimenovanie=@naimenovanie, tip=@tip,firma=@firma,diapazon=@diapazon,invent_nomer=@invent_nomer,zavod_nomer=@zavod_nomer,etalon=@etalon,sostoyanie=@sostoyanie,komplectacia=@komplectacia,opisanie=@opisanie,prinadlejnost=@prinadlejnost Where invent_nomer=@invent_nomer and zavod_nomer=@zavod_nomer", ConnDB.getConnection());
            Izmenenie.Parameters.Add("@naimenovanie", MySqlDbType.VarChar).Value = nameBox.Text;
            Izmenenie.Parameters.Add("@tip", MySqlDbType.VarChar).Value = typeBox.Text;
            Izmenenie.Parameters.Add("@firma", MySqlDbType.VarChar).Value = manufacturerBox.Text;
            Izmenenie.Parameters.Add("@diapazon", MySqlDbType.VarChar).Value = rangeBox.Text;
            Izmenenie.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = inventoryBox.Text;
            Izmenenie.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = factoryBox.Text;
            Izmenenie.Parameters.Add("@etalon", MySqlDbType.Bit).Value = isEtalon;
            Izmenenie.Parameters.Add("@sostoyanie", MySqlDbType.VarChar).Value = conditionBox.Text;
            Izmenenie.Parameters.Add("@komplectacia", MySqlDbType.Text).Value = equipmentBox.Text;
            Izmenenie.Parameters.Add("@opisanie", MySqlDbType.Text).Value = descriptionBox.Text;
            Izmenenie.Parameters.Add("@prinadlejnost", MySqlDbType.VarChar).Value = belongBox.Text;

            ConnDB.openConnection();

            if (Izmenenie.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменения сохранены");
                try
                {
                    measuringsGridView.Rows.Clear();
                    BD ConnDB1 = new BD();
                    ConnDB1.openConnection();
                    string request1 = "Select id_si, naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer,etalon,sostoyanie,komplectacia,opisanie,prinadlejnost From si_card Order By naimenovanie";
                    MySqlCommand Reader = new MySqlCommand(request1, ConnDB1.getConnection());
                    MySqlDataReader reader = Reader.ExecuteReader();
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
                        data[data.Count - 1][9] = reader[9].ToString();
                        data[data.Count - 1][10] = reader[10].ToString();
                        data[data.Count - 1][11] = reader[11].ToString();


                    }
                    reader.Close();
                    ConnDB1.CloseConnection();
                    foreach (string[] s in data)
                        measuringsGridView.Rows.Add(s);
                }
                catch (MySqlException isq)
                {
                    MessageBox.Show(isq.Message);
                }

            }
            else MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConnDB.CloseConnection();


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(Search_Button, "Введите заводской и/или инвентарный номер чтобы найти прибор");
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text) &&
   !string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text))

            {
                /* BD ConnDB = new BD();
                 ConnDB.openConnection();
                 string request = "Select naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer, sostoyanie,komplectacia,opisanie,prinadlejnost From si_card where zavod_nomer='" + factoryBox.Text + "' and invent_nomer= '" + inventoryBox.Text + "'";
                 MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                 MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                 sqlDataReader.Read();
                 if (sqlDataReader.HasRows)
                 {
                     nameBox.Text = sqlDataReader[0].ToString();
                     typeBox.Text = sqlDataReader[1].ToString();
                     manufacturerBox.Text = sqlDataReader[2].ToString();
                     rangeBox.Text = sqlDataReader[3].ToString();
                     inventoryBox.Text = sqlDataReader[4].ToString();
                     factoryBox.Text = sqlDataReader[5].ToString();
                     BD ConnDB1 = new BD();
                     ConnDB1.openConnection();
                     string request1 = "Select si_card.etalon from si_card where zavod_nomer=@zavod_nomer and invent_nomer=@invent_nomer";
                     MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
                     Nado1.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = factoryBox.Text;
                     Nado1.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = inventoryBox.Text;
                     MySqlDataReader sqlData1 = Nado1.ExecuteReader();
                     sqlData1.Read();
                     if (sqlData1.HasRows)
                     {

                         if (sqlData1[0].ToString() == "True")
                         {
                             EtalonStatusCheckBox.Checked = true;
                         }
                         else EtalonStatusCheckBox.Checked = false;
                     }
                     conditionBox.Text = sqlDataReader[6].ToString();
                     equipmentBox.Text = sqlDataReader[7].ToString();
                     descriptionBox.Text = sqlDataReader[8].ToString();
                     belongBox.Text = sqlDataReader[9].ToString();

                 }

                 else

                     MessageBox.Show("Такого средства измерения нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ConnDB.CloseConnection();*/

               
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            typeBox.Clear();
            manufacturerBox.Clear();
            rangeBox.Clear();
            inventoryBox.Text = "0";
            factoryBox.Text = "0";
            EtalonStatusCheckBox.Checked = false;
            equipmentBox.Clear();
            descriptionBox.Clear();

        }

        private void measuringInstrument_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.ShowDialog();
            this.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text) &&
!string.IsNullOrEmpty(typeBox.Text) && !string.IsNullOrWhiteSpace(typeBox.Text)
&&
!string.IsNullOrEmpty(manufacturerBox.Text) && !string.IsNullOrWhiteSpace(manufacturerBox.Text)
&&
!string.IsNullOrEmpty(rangeBox.Text) && !string.IsNullOrWhiteSpace(rangeBox.Text)
&&
!string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text)
&&
!string.IsNullOrEmpty(conditionBox.Text) && !string.IsNullOrWhiteSpace(conditionBox.Text)
&&
!string.IsNullOrEmpty(equipmentBox.Text) && !string.IsNullOrWhiteSpace(equipmentBox.Text)
&&
!string.IsNullOrEmpty(descriptionBox.Text) && !string.IsNullOrWhiteSpace(descriptionBox.Text)
&&
!string.IsNullOrEmpty(belongBox.Text) && !string.IsNullOrWhiteSpace(belongBox.Text))

            {
                Avionika_Si.Models.MeasuringInstrument instrument = new Avionika_Si.Models.MeasuringInstrument()
                {

                    InstrumentNameReferenceID = Convert.ToInt32(nameBox.SelectedValue),
                    Type = typeBox.Text,
                    Manufacturer = manufacturerBox.Text,
                    MeasuringRange = rangeBox.Text,
                    InventoryNumber = inventoryBox.Text,
                    FactoryNumber = factoryBox.Text,
                    Etalon = EtalonStatusCheckBox.Checked,
                    ConditionReferenceId = Convert.ToInt32(conditionBox.SelectedValue),
                    Equipment = equipmentBox.Text,
                    BelongsToReferenceID = Convert.ToInt32(belongBox.SelectedValue)


                };


                if (instrument.Update())
                {
                    MessageBox.Show("Средство измерения было изменено");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");

        }
    }
}
