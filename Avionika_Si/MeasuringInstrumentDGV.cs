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

namespace Avionika_Si
{
    public partial class MeasuringInstrumentDGV : Form
    {
        private List<MeasuringInstrument> measuringInstruments = null;
        public MeasuringInstrumentDGV()
        {
            InitializeComponent();
            FillMesInstrumentsDataGrid();
        }

        private void FillMesInstrumentsDataGrid()
        {
            measuringInstruments = Program.DbHelper.GetMeasuringInstrumentsList();
            TableHelper.FillMeasuringInstrumentsTable(measuringInstruments, measuringsGridView);
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {

            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {
                Avionika_Si.Models.MeasuringInstrument measuring = new Avionika_Si.Models.MeasuringInstrument()
                {

                };
                measuringInstruments = Program.DbHelper.GetInstrumentByFactoryInventory(inventoryBox.Text, factoryBox.Text);
                TableHelper.FillMeasuringInstrumentsTable(measuringInstruments, measuringsGridView);


            }
            else
            {
                MessageBox.Show("Ошибка. СИ с таким инвентарным и заводским номером не найдено.");
            }
        }

        private void MeasuringInstrumentDGV_Load(object sender, EventArgs e)
        {

        }
    }
}
