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
using MySql.Data.MySqlClient;
using Avionika_Si;
using System.Globalization;

namespace Oborot_SI
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }
        private void InitOldVenueBox()
        {
            oldVenueBox.DataSource = Program.DbHelper.GetVenue();
            oldVenueBox.DisplayMember = "VenueName";
            oldVenueBox.ValueMember = "ID";
        }
        private void InitNewVenueBox()
        {
            newVenueBox.DataSource = Program.DbHelper.GetVenue();
            newVenueBox.DisplayMember = "VenueName";
            newVenueBox.ValueMember = "ID";
        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            InitOldVenueBox();
            InitNewVenueBox();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text) &&
                   !string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text)
                   &&
                    !string.IsNullOrEmpty(frequencyBox.Text) && !string.IsNullOrWhiteSpace(frequencyBox.Text)
                    &&
                   !string.IsNullOrEmpty(oldVenueBox.Text) && !string.IsNullOrWhiteSpace(oldVenueBox.Text)
                    &&
                   !string.IsNullOrEmpty(newVenueBox.Text) && !string.IsNullOrWhiteSpace(newVenueBox.Text))
             {
                if (newDateBox.Value > DateTime.Now)
                {
                    int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
                    if (refMeasuringInstrumentId != 0)
                    {

                        Avionika_Si.Models.Schedule schedule = new Avionika_Si.Models.Schedule()
                        {
                            MeasuringInstrumentReferenceId = refMeasuringInstrumentId,
                            OldWorkDate = oldDateBox.Value,
                            Frequency = Convert.ToInt32(frequencyBox.Text),
                            OldVenueReferenceID = Convert.ToInt32(oldVenueBox.SelectedValue),
                            NextWorkDate = newDateBox.Value,
                            NewVenueReferenceID = Convert.ToInt32(newVenueBox.SelectedValue),
                        };

                        if (schedule.Create())
                        {
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка. СИ с таким инвентарным и заводским номером не найдено.");
                    }
                }
                else 
                {
                    MessageBox.Show("Ошибка");
                }
            
             }
             else
                 MessageBox.Show("Все обязательные поля должны быть заполнены!");
        }

        private void oldDateBox_ValueChanged(object sender, EventArgs e)
        {
            if (oldDateBox.Value > DateTime.Now)
            {
                MessageBox.Show("Выберите другую дату работы");
                oldDateBox.Value = DateTime.Now;
            }
            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {
                    Avionika_Si.Models.Schedule schedule = new Avionika_Si.Models.Schedule()
                    {


                    };
                    var GetDate = oldDateBox.Value.ToString();
                    if (GetDate != null)
                    {
                        var NewDate = DateTime.Parse(GetDate);
                        if (!string.IsNullOrEmpty(frequencyBox.Text) && !string.IsNullOrWhiteSpace(frequencyBox.Text))
                        {
                            int frequency = Convert.ToInt32(frequencyBox.Text);
                            NewDate = NewDate.AddMonths(frequency);
                            NewDate = NewDate.AddDays(-1);
                            newDateBox.Value = NewDate;

                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Ошибка. СИ с таким инвентарным и заводским номером не найдено.");
                }
            }
        }

        private void frequencyBox_TextChanged(object sender, EventArgs e)
        {
            if (oldDateBox.Value > DateTime.Now)
            {
                MessageBox.Show("Выберите другую дату работы");
            }
            else
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {
                    Avionika_Si.Models.Schedule schedule = new Avionika_Si.Models.Schedule()
                    {


                    };
                    var GetDate = oldDateBox.Value.ToString();
                    if (GetDate != null)
                    {
                        var NewDate = DateTime.Parse(GetDate);
                        if (!string.IsNullOrEmpty(frequencyBox.Text) && !string.IsNullOrWhiteSpace(frequencyBox.Text))
                        {
                            int frequency = Convert.ToInt32(frequencyBox.Text);
                            NewDate = NewDate.AddMonths(frequency);
                            NewDate = NewDate.AddDays(-1);
                            newDateBox.Value = NewDate;

                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Ошибка. СИ с таким инвентарным и заводским номером не найдено.");
                }
            }
        }

        private void PickMesInstrButton_Click(object sender, EventArgs e)
        {
            MeasuringInstrumentDGV form = new MeasuringInstrumentDGV(true);
            if(form.ShowDialog() == DialogResult.OK)
            {
                inventoryBox.Text = form.PickedMeasuringInstrument.InventoryNumber;
                factoryBox.Text = form.PickedMeasuringInstrument.FactoryNumber;
            }
        }
    }
}
