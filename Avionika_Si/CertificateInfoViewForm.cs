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
using Oborot_SI;
using MySql.Data.MySqlClient;
using Avionika_Si.Models;
using DFLS.Adapters;

namespace Avionika_Si
{
    public partial class CertificateInfoViewForm : Form
    {
        private Certificate SelectedSertificateData = null;
        public CertificateInfoViewForm()
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

        private void CertificateGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedSertificateData != null)
            {

                    CreateCertificateForm form = new CreateCertificateForm(SelectedSertificateData);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        FillCerificatelDataGrid();
                    }
            }
            else
            {
                MessageBox.Show("Средство измерения не выбрано");
            }

        }

        private void CertificateGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CertificateGridView.RowCount > 0)
            {
                if (CertificateGridView.SelectedRows.Count > 0)
                {
                    if (CertificateGridView.SelectedRows[0].Index >= 0)
                    {
                        try
                        {
                            int selectedId = Convert.ToInt32(CertificateGridView.SelectedRows[0].Tag);

                            //BindingSource bs = CertificateGridView.DataSource as BindingSource;
                            //DataTable table = bs.DataSource as DataTable;
                            int protocolNumber = Convert.ToInt32(CertificateGridView.SelectedRows[0].Cells[0].Value);
                            string mesInstrName = CertificateGridView.SelectedRows[0].Cells[1].Value.ToString();
                            string facNumber = CertificateGridView.SelectedRows[0].Cells[2].Value.ToString();
                            string invNumber = CertificateGridView.SelectedRows[0].Cells[3].Value.ToString();
                            string department = CertificateGridView.SelectedRows[0].Cells[4].Value.ToString();
                            DateTime oldDate = DateTime.Parse(CertificateGridView.SelectedRows[0].Cells[5].Value.ToString());
                            DateTime newDate = DateTime.Parse(CertificateGridView.SelectedRows[0].Cells[6].Value.ToString());
                            string respEmployee = CertificateGridView.SelectedRows[0].Cells[7].Value.ToString();
                            //table.Select("")

                            SelectedSertificateData = new Certificate(protocolNumber, mesInstrName, facNumber, invNumber, department, oldDate, newDate, respEmployee);

                        }
                        catch
                        {
                            SelectedSertificateData = null;
                        }

                    }
                    else
                    {
                        SelectedSertificateData = null;
                    }
                }
                else
                {
                    SelectedSertificateData = null;
                }
            }
            else
            {
                SelectedSertificateData = null;
            }
        }
    }
 }

