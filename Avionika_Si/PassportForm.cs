using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avionika_Si.Models;
using DFLS.Adapters;
using Avionika_Si;

namespace Oborot_SI
{
    public partial class PassportForm : Form
    {

        private List<PassportForm> passports = null;
        public PassportForm()
        {
            InitializeComponent();
            FillPassportDataGrid();
        }

        private void FillPassportDataGrid()
        {
            //passports = Program.DbHelper.GetPassportList(inventoryBox.Text, factoryBox.Text);
            //TableHelper.FillMeasuringInstrumentsTable(passports, PassportGridView);
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

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {
           /* int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {
                Avionika_Si.Models.MeasuringInstrument measuring = new Avionika_Si.Models.MeasuringInstrument()
                {

                };
                passports = Program.DbHelper.GetInstrumentByFactoryInventory(inventoryBox.Text, factoryBox.Text);
                TableHelper.FillMeasuringInstrumentsTable(passports, PassportGridView);
            }
            else
            {
                passports = Program.DbHelper.GetPassportList();
                TableHelper.FillMeasuringInstrumentsTable(passports, PassportGridView);
            }*/
        }
    }
}
