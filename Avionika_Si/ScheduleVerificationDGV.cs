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
    public partial class ScheduleVerificationDGV : Form
    {
        private List<Schedule> schedules = null;
        public ScheduleVerificationDGV()
        {
            InitializeComponent();
            FillScheduleDataGrid();
        }

        private void FillScheduleDataGrid()
        {
           //schedules = Program.DbHelper.GetScheduleList();
           TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
        }
        

        private void Add_Button_Click(object sender, EventArgs e)
        {
            
        }


        private void ScheduleView_Load(object sender, EventArgs e)
        {
            InventoryFactoryNumbersFilterRadioButton.Checked = true;

        }

        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm form = new ScheduleForm();
            form.PreviousForm = "График поверки";
            form.Show();
        }

        private void InventoryBox_TextChanged(object sender, EventArgs e)
        {
            if (ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
                }
            }
            
            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleListByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
                }
            }
            
        }

        private void FactoryBox_TextChanged(object sender, EventArgs e)
        {
            if (ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
                }
            }

            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleListByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
                }
            }
        }

        private void InventoryFactoryNumbersFilterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InventoryFactoryNumbersFilterRadioButton.Checked)
            {
                DateFilterGroupBox.Enabled = false;
                InventoryFactoryNumbersFilterGroupBox.Enabled = true;
            }
        }

        private void DateFilterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DateFilterRadioButton.Checked)
            {
                DateFilterGroupBox.Enabled = true; 
                InventoryFactoryNumbersFilterGroupBox.Enabled = false;
            }
        }

        private void NextDateWorkBox_ValueChanged(object sender, EventArgs e)
        {
            if (ShowArchiveCheck.Checked)
            {
                TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleArchiveByData(NextDateWorkBox.Value), scheduleGridView);
            }
            else
            {
                TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleByNextDataFilter(NextDateWorkBox.Value), scheduleGridView);
            }
        }

        private void ShowArchiveCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowArchiveCheck.Checked)
            {
                TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleArchive(), scheduleGridView);
            }
            else
            {
                TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
            }
        }
    }
}
