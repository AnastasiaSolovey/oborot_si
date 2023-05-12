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
    public partial class CreatingCertificate : Form
    {
        public CreatingCertificate()
        {
            InitializeComponent();
            FillCerificatelDataGrid();
        }

        private void FillCerificatelDataGrid()
        {
            TableHelper.FillCertificateTable(Program.DbHelper.GetCertificateDGV(), CertificateGridView);
        }
        private void CreatingCertificate_Load(object sender, EventArgs e)
        {

        }

        private void factoryBox_TextChanged(object sender, EventArgs e)
        {
            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {

                TableHelper.FillCertificateTable(Program.DbHelper.GetCertificateByInventoryFactoryNumbers(inventoryBox.Text, factoryBox.Text), CertificateGridView);
            }
            else
            {
                TableHelper.FillCertificateTable(Program.DbHelper.GetCertificateDGV(), CertificateGridView);
            }
        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {
            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
            if (refMeasuringInstrumentId != 0)
            {

                TableHelper.FillCertificateTable(Program.DbHelper.GetCertificateByInventoryFactoryNumbers(inventoryBox.Text, factoryBox.Text), CertificateGridView);
            }
            else
            {
                TableHelper.FillCertificateTable(Program.DbHelper.GetCertificateDGV(), CertificateGridView);
            }
        }
    }
 }

