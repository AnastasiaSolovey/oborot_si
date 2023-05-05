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

namespace Oborot_SI
{
    public partial class ProtocolForm : Form
    {
        public string SelectedInventoryNumProtocol { get; set; }
        public string SelectedFactoryNumProtocol { get; set; }
        public ProtocolForm()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();

        }
        private void InitEmployeeBox()
        {
            employeeBox.DataSource = Program.DbHelper.GetEmployee();
            employeeBox.DisplayMember = "FullName";
            employeeBox.ValueMember = "ID";
        }

        private void Protocol_Load(object sender, EventArgs e)
        {
            InitEmployeeBox();
            LastNumLabel.Text = "Последний номер в протоколе " + Program.DbHelper.GetLastNumProtocolQuery();
            inventoryBox.Text = SelectedInventoryNumProtocol;
            factoryBox.Text = SelectedFactoryNumProtocol;

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inventoryBox.Text) && !string.IsNullOrWhiteSpace(inventoryBox.Text) &&
                !string.IsNullOrEmpty(factoryBox.Text) && !string.IsNullOrWhiteSpace(factoryBox.Text))
            {
                int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(inventoryBox.Text, factoryBox.Text);
                if (refMeasuringInstrumentId != 0)
                {
                    Avionika_Si.Models.Protocol AddProtocol = new Avionika_Si.Models.Protocol()
                    {
                        NumProtocol = Convert.ToInt32(ProtocolNumberUpDown.Value),
                        InstrumentNameReferenceID = refMeasuringInstrumentId,
                        Note = Convert.ToString(NoteBox.Text),
                        EmployeeReferenceID = Convert.ToInt32(employeeBox.SelectedValue),
                    };

                    if (AddProtocol.Create())
                    {
                        this.Hide();
                        ScheduleForm form = new ScheduleForm();
                        form.SelectedInventoryNumSchedule = inventoryBox.Text;
                        form.SelectedFactoryNumSchedule = factoryBox.Text;
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
                    }
                }

            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");

        }

        private void ChoseMeasuringInstrumentButton_Click(object sender, EventArgs e)
        {
            MeasuringInstrumentDGV form = new MeasuringInstrumentDGV(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                inventoryBox.Text = form.PickedMeasuringInstrument.InventoryNumber;
                factoryBox.Text = form.PickedMeasuringInstrument.FactoryNumber;
            }
        }

        private void ProtocolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Закончите заполнение всех данных");
            e.Cancel = true;
        }
    }
}
