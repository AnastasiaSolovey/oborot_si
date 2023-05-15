using Avionika_Si.Models;
using DFLS.Adapters;
using Oborot_SI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avionika_Si
{
    public partial class ScheduleCalibrationDGV : Form
    {
        private List<Schedule> schedules = null;
        public ScheduleCalibrationDGV()
        {
            InitializeComponent();
            FillScheduleDataGrid();
        }

        private void FillScheduleDataGrid()
        {
            TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
        }


        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm form = new ScheduleForm();
            form.PreviousForm = "График калибровки и проверки";
            form.Show();
            TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
        }

        private void FactoryBox_TextChanged(object sender, EventArgs e)
        {
            if (ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
                }
            }

            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleListByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
                }
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

        private void ScheduleCalibrationDGV_Load(object sender, EventArgs e)
        {
            InventoryFactoryNumbersFilterRadioButton.Checked = true;
        }

        private void ShowCalibrationMeasuringInstruments_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowCalibrationMeasuringInstruments.Checked)
            {
                ShowCheckSchedule.Checked = false;
                if (DateFilterRadioButton.Checked && ShowCalibrationMeasuringInstruments.Checked)
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(NextDateWorkBox.Value), scheduleGridView);
                }
                if (ShowCalibrationMeasuringInstruments.Checked && ShowArchiveCheck.Checked)
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationArchive(), scheduleGridView);
                }
                else 
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else 
            {
                TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
            }

        }
        private void ShowCheckSchedule_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheckSchedule.Checked)
            {
                ShowCalibrationMeasuringInstruments.Checked = false;
                if (DateFilterRadioButton.Checked && ShowCheckSchedule.Checked)
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(NextDateWorkBox.Value), scheduleGridView);
                }
                if (ShowCheckSchedule.Checked && ShowArchiveCheck.Checked)
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckArchive(), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else
            {
                TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
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

        private void InventoryFactoryNumbersFilterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InventoryFactoryNumbersFilterRadioButton.Checked)
            {
                DateFilterGroupBox.Enabled = false;
                InventoryFactoryNumbersFilterGroupBox.Enabled = true;
            }
        }

        private void InventoryBox_TextChanged(object sender, EventArgs e)
        {
                if (ShowCalibrationMeasuringInstruments.Checked && ShowArchiveCheck.Checked)
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                    }
                    else
                    {
                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(DateTime.Today.Date), scheduleGridView);
                    }
                }
                else if (ShowCalibrationMeasuringInstruments.Checked)
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                    }
                    else
                    {
                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(DateTime.Today.Date), scheduleGridView);
                    }
                }
                else if (ShowCheckSchedule.Checked && ShowArchiveCheck.Checked)
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                    }
                    else
                    {
                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(DateTime.Today.Date), scheduleGridView);
                    }
                }
                else if (ShowCheckSchedule.Checked)
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                    }
                    else
                    {
                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(DateTime.Today.Date), scheduleGridView);
                    }
                }
                else if (ShowArchiveCheck.Checked)
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                    }
                    else
                    {
                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
                    }
                }
                else
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                    }
                    else
                    {
                        TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
                    }
                }

        }

        private void FactoryBox_TextChanged_1(object sender, EventArgs e)
        {
            if (ShowCalibrationMeasuringInstruments.Checked && ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowCalibrationMeasuringInstruments.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowCheckSchedule.Checked && ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowCheckSchedule.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
                }
            }
            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
                }
            }
        }

        private void ShowArchiveCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowCalibrationMeasuringInstruments.Checked && ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowCalibrationMeasuringInstruments.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowCheckSchedule.Checked && ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowCheckSchedule.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(DateTime.Today.Date), scheduleGridView);
                }
            }
            else if (ShowArchiveCheck.Checked)
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckArchiveByInventoryFactory(InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
                }
            }
            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {

                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckDataByInventoryFactoryNumbers(DateTime.Today.Date, InventoryBox.Text, FactoryBox.Text), scheduleGridView);
                }
                else
                {
                    TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationCheckList(DateTime.Today.Date), scheduleGridView);
                }
            }
        }

        private void NextDateWorkBox_ValueChanged_1(object sender, EventArgs e)
        {
            TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleCalibrationByNextData(NextDateWorkBox.Value), scheduleGridView);

            if (ShowCalibrationMeasuringInstruments.Checked)
            {
                TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCalibrationByNextData(NextDateWorkBox.Value), scheduleGridView);
            }
            else if (ShowCheckSchedule.Checked)
            {
                TableHelper.FillScheduleCalibrationCheckTable(Program.DbHelper.GetScheduleOnlyCheckByNextData(NextDateWorkBox.Value), scheduleGridView);
            }

        }
    }
}
