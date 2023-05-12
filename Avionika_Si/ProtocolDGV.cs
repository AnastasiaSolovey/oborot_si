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
namespace Avionika_Si
{
    public partial class ProtocolDGV : Form
    {
        public ProtocolDGV()
        {
            InitializeComponent();
            FillProtocolDataGrid();
        }

        private void FillProtocolDataGrid()
        {
            TableHelper.FillProtocolTable(Program.DbHelper.GetProtocolDGV(), ProtocolGridView);
        }

        private void ProtocolDGV_Load(object sender, EventArgs e)
        {

        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {

            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {

                TableHelper.FillProtocolTable(Program.DbHelper.GetProtocolDGVByInventoryFactoryNumbers(inventoryBox.Text, factoryBox.Text), ProtocolGridView);
            }
            else
            {
                TableHelper.FillProtocolTable(Program.DbHelper.GetProtocolDGV(), ProtocolGridView);
            }
        }

        private void factoryBox_TextChanged(object sender, EventArgs e)
        {
            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {

                TableHelper.FillProtocolTable(Program.DbHelper.GetProtocolDGVByInventoryFactoryNumbers(inventoryBox.Text, factoryBox.Text), ProtocolGridView);
            }
            else
            {
                TableHelper.FillProtocolTable(Program.DbHelper.GetProtocolDGV(), ProtocolGridView);
            }
        }
    }
}
