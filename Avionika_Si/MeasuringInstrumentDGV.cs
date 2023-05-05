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
using Oborot_SI;

namespace Avionika_Si
{
    public partial class MeasuringInstrumentDGV : Form
    {
        private List<MeasuringInstrument> measuringInstruments = null;
        private MeasuringInstrument SelectedInstrument = null;
        private bool _pickingMode = false;
        public MeasuringInstrument PickedMeasuringInstrument { get; private set; }
        public MeasuringInstrumentDGV(bool pickingMode = false)
        {
            InitializeComponent();
            _pickingMode = pickingMode;
        }

        private void FillMesInstrumentsDataGrid()
        {
            measuringInstruments = Program.DbHelper.GetMeasuringInstrumentsList();
            TableHelper.FillMeasuringInstrumentsTable(measuringInstruments, measuringsGridView);
        }

        private void MeasuringInstrumentDGV_Load(object sender, EventArgs e)
        {
            if(_pickingMode)
            {
                groupBox2.Enabled=false;
                groupBox2.Visible=false;

                measuringsGridView.CellDoubleClick -= measuringsGridView_CellDoubleClick;
                measuringsGridView.CellDoubleClick += measuringsGridView_CellDoubleClick_PickingMode;
            }

            FillMesInstrumentsDataGrid();
        }

        private void createMeasuringInstrumentButton_Click(object sender, EventArgs e)
        {
            MeasuringInstrumentForm form = new MeasuringInstrumentForm();

            if(form.ShowDialog() == DialogResult.OK)
            {
                FillMesInstrumentsDataGrid();
            }
        }

        private void updateMeasuringIstrumentButton_Click(object sender, EventArgs e)
        {
            if(SelectedInstrument!=null)
            {
                MeasuringInstrumentForm form = new MeasuringInstrumentForm(SelectedInstrument);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    FillMesInstrumentsDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Средство измерения не выбрано");
            }
        }

        private void measuringsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (measuringsGridView.RowCount > 0)
            {
                if (measuringsGridView.SelectedRows.Count > 0)
                {
                    if (measuringsGridView.SelectedRows[0].Index >= 0)
                    {
                        try
                        {
                            updateMeasuringIstrumentButton.Enabled = true;
                            int selectedId = Convert.ToInt32(measuringsGridView.SelectedRows[0].Tag);
                            SelectedInstrument = measuringInstruments.Find(inst => inst.ID == selectedId);

                            if(SelectedInstrument!= null)
                            {
                                mesInstrInvNumbLabel.Text = $"Выбранно СИ" +
                                $"{Environment.NewLine}" +
                                $"Инв. №:" +
                                $"{Environment.NewLine}{SelectedInstrument.InventoryNumber}" +
                                $"{Environment.NewLine}Зав. №:" +
                                $"{Environment.NewLine}{SelectedInstrument.FactoryNumber}";
                            }

                        }
                        catch
                        {
                            updateMeasuringIstrumentButton.Enabled = false;
                            mesInstrInvNumbLabel.Text = "";
                            SelectedInstrument = null;
                        }

                    }
                    else
                    {
                        updateMeasuringIstrumentButton.Enabled = false;
                        mesInstrInvNumbLabel.Text = "";
                        SelectedInstrument = null;
                    }
                }
                else
                {
                    updateMeasuringIstrumentButton.Enabled = false;
                    mesInstrInvNumbLabel.Text = "";
                    SelectedInstrument = null;
                }
            }
            else
            {
                updateMeasuringIstrumentButton.Enabled = false;
                mesInstrInvNumbLabel.Text = "";
                SelectedInstrument = null;
            }
        }

        private void measuringsGridView_CellDoubleClick_PickingMode(object sender, DataGridViewCellEventArgs e)
        {
            if(SelectedInstrument!=null)
            {
                PickedMeasuringInstrument = SelectedInstrument;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void measuringsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(SelectedInstrument!= null)
            {
                updateMeasuringIstrumentButton_Click(null, null);
            }

        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
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
                measuringInstruments = Program.DbHelper.GetMeasuringInstrumentsList();
                TableHelper.FillMeasuringInstrumentsTable(measuringInstruments, measuringsGridView);
            }
        }

        private void factoryBox_TextChanged(object sender, EventArgs e)
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
                measuringInstruments = Program.DbHelper.GetMeasuringInstrumentsList();
                TableHelper.FillMeasuringInstrumentsTable(measuringInstruments, measuringsGridView);
            }
        }
    }
}
