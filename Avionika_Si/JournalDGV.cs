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
using Avionika_Si.Models;
using DFLS.Adapters;

namespace Oborot_SI
{
    public partial class JournalDGV : Form
    {
        public JournalDGV()
        {
            InitializeComponent();
            FillJournalDataGrid();
        }

        private void FillJournalDataGrid()
        {
            //schedules = Program.DbHelper.GetScheduleList();
            TableHelper.FillJournalTable(Program.DbHelper.GetJournalDGV(), JournalGridView);
        }
        private void Pasport_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JournalDGV_Load(object sender, EventArgs e)
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

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {
            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {

                TableHelper.FillJournalTable(Program.DbHelper.GetJournalByInventoryFactoryNumbers(inventoryBox.Text, factoryBox.Text), JournalGridView);
            }
            else
            {
                TableHelper.FillJournalTable(Program.DbHelper.GetJournalDGV(), JournalGridView);
            }
        }

        private void factoryBox_TextChanged(object sender, EventArgs e)
        {
            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {

                TableHelper.FillJournalTable(Program.DbHelper.GetJournalByInventoryFactoryNumbers(inventoryBox.Text, factoryBox.Text), JournalGridView);
            }
            else
            {
                TableHelper.FillJournalTable(Program.DbHelper.GetJournalDGV(), JournalGridView);
            }
        }
    }
}
