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
using Avionika_Si;
using MySql.Data.MySqlClient;
using Avionika_Si.Models;
using DFLS.Adapters;

namespace Oborot_SI
{
    public partial class MeasuringInstrumentForm : Form
    {
        /*public int id { get; private set; }
        public int name { get; set; }
        public string type { get; set; }
        public string manufacturer { get; set; }
        public string measuringRange { get; set; }
        public string inventoryNumber { get; set; }
        public string factoryNumber { get; set; }
        public int etallon { get; set; }
        public int idCondition { get; set; }
        public string equipment { get; set; }
        public string description { get; set; }
        public int idBelongTo { get; set; }*/

        MeasuringInstrument inputInstrument = null;

        /// <summary>
        /// false - добавление
        /// true - обновление
        /// </summary>
        private bool formType = false;


        private List<MeasuringInstrument> measuringInstruments = null;

        public MeasuringInstrumentForm()
        {
            InitializeComponent();
        }
        public MeasuringInstrumentForm(MeasuringInstrument instrument)
        {
            inputInstrument = new MeasuringInstrument(instrument);
            formType= true;
            InitializeComponent();
        }

        public static int isEtalon = 0;

        private void InitNameBox()
        {
            nameBox.DataSource = Program.DbHelper.GetInstrumentNames();
            nameBox.DisplayMember = "Name";
            nameBox.ValueMember = "ID";
        }

        private void InitConditionBox()
        {
            conditionBox.DataSource = Program.DbHelper.GetCondition();
            conditionBox.DisplayMember = "ConditionName";
            conditionBox.ValueMember = "ID";
        }

        private void InitBelongBox()
        {
            belongBox.DataSource = Program.DbHelper.GetBelongTo();
            belongBox.DisplayMember = "Departments";
            belongBox.ValueMember = "ID";
        }

        private void Card_si_Load(object sender, EventArgs e)
        {
            InitNameBox();
            InitConditionBox();
            InitBelongBox();


            if(inputInstrument != null)
            {
                nameBox.SelectedValue = inputInstrument.InstrumentNameReferenceID;
                typeBox.Text = inputInstrument.Type;
                manufacturerBox.Text = inputInstrument.Manufacturer;
                rangeBox.Text = inputInstrument.MeasuringRange;
                inventoryBox.Text = inputInstrument.InventoryNumber;
                factoryBox.Text = inputInstrument.FactoryNumber;
                EtalonStatusCheckBox.Checked = inputInstrument.Etalon;
                conditionBox.SelectedValue = inputInstrument.ConditionReferenceId;
                equipmentBox.Text = inputInstrument.Equipment;
                descriptionBox.Text = inputInstrument.Description;
                belongBox.SelectedValue = inputInstrument.DepartmentsToReferenceID;
            }

            if(formType)
            {
                addButton.Text = "Обновить СИ";
            }
            else
            {
                addButton.Text = "Добавить СИ";
            }
        
        }



        private void Add_Button_Click(object sender, EventArgs e)
        {
            if(!formType)
            {
                if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text) &&
                !string.IsNullOrEmpty(typeBox.Text) && !string.IsNullOrWhiteSpace(typeBox.Text)
                &&
                !string.IsNullOrEmpty(manufacturerBox.Text) && !string.IsNullOrWhiteSpace(manufacturerBox.Text)
                &&
                !string.IsNullOrEmpty(rangeBox.Text) && !string.IsNullOrWhiteSpace(rangeBox.Text)
                &&
                !string.IsNullOrEmpty(conditionBox.Text) && !string.IsNullOrWhiteSpace(conditionBox.Text)
                &&
                !string.IsNullOrEmpty(equipmentBox.Text) && !string.IsNullOrWhiteSpace(equipmentBox.Text)
                &&
                !string.IsNullOrEmpty(descriptionBox.Text) && !string.IsNullOrWhiteSpace(descriptionBox.Text)
                &&
                !string.IsNullOrEmpty(belongBox.Text) && !string.IsNullOrWhiteSpace(belongBox.Text))

                {
                    Avionika_Si.Models.MeasuringInstrument AddInstrument = new Avionika_Si.Models.MeasuringInstrument()
                    {

                        InstrumentNameReferenceID = Convert.ToInt32(nameBox.SelectedValue),
                        Type = typeBox.Text,
                        Manufacturer = manufacturerBox.Text,
                        MeasuringRange = rangeBox.Text,
                        InventoryNumber = inventoryBox.Text,
                        FactoryNumber = factoryBox.Text,
                        Etalon = EtalonStatusCheckBox.Checked,
                        ConditionReferenceId = Convert.ToInt32(conditionBox.SelectedValue),
                        Equipment = equipmentBox.Text,
                        Description = descriptionBox.Text,
                        DepartmentsToReferenceID = Convert.ToInt32(belongBox.SelectedValue)

                    };


                    if (AddInstrument.Create())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка. Проверьте корректность введеных данных. Возможно, СИ с такими инвентарным и заводским номером уже есть в базе данных ");
                    }
                }
                else
                    MessageBox.Show("Все обязательные поля должны быть заполнены!");
            }
            else
            {
                if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text) &&
                    !string.IsNullOrEmpty(typeBox.Text) && !string.IsNullOrWhiteSpace(typeBox.Text)
                    &&
                    !string.IsNullOrEmpty(manufacturerBox.Text) && !string.IsNullOrWhiteSpace(manufacturerBox.Text)
                    &&
                    !string.IsNullOrEmpty(rangeBox.Text) && !string.IsNullOrWhiteSpace(rangeBox.Text)
                    &&
                    !string.IsNullOrEmpty(conditionBox.Text) && !string.IsNullOrWhiteSpace(conditionBox.Text)
                    &&
                    !string.IsNullOrEmpty(equipmentBox.Text) && !string.IsNullOrWhiteSpace(equipmentBox.Text)
                    &&
                    !string.IsNullOrEmpty(descriptionBox.Text) && !string.IsNullOrWhiteSpace(descriptionBox.Text)
                    &&
                    !string.IsNullOrEmpty(belongBox.Text) && !string.IsNullOrWhiteSpace(belongBox.Text))
                {

                    inputInstrument.InstrumentNameReferenceID = Convert.ToInt32(nameBox.SelectedValue);
                    inputInstrument.Type = typeBox.Text;
                    inputInstrument.Manufacturer = manufacturerBox.Text;
                    inputInstrument.MeasuringRange = rangeBox.Text;
                    inputInstrument.InventoryNumber = inventoryBox.Text;
                    inputInstrument.FactoryNumber = factoryBox.Text;
                    inputInstrument.Etalon = EtalonStatusCheckBox.Checked;
                    inputInstrument.ConditionReferenceId = Convert.ToInt32(conditionBox.SelectedValue);
                    inputInstrument.Equipment = equipmentBox.Text;
                    inputInstrument.Description = descriptionBox.Text;
                    inputInstrument.DepartmentsToReferenceID = Convert.ToInt32(belongBox.SelectedValue);


                    if (inputInstrument.Update())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
                    }
                }
                else
                    MessageBox.Show("Все обязательные поля должны быть заполнены!");
            }
            

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
                    nameBox.Text = "Name";
                    typeBox.Text = "Type";
                    manufacturerBox.Text = "Manufacturer";
                    rangeBox.Text = "MeasuringRange";
                    inventoryBox.Text = "InventoryNumber";
                    factoryBox.Text = "FactoryNumber";
                    bool IsEtalon = Program.DbHelper.GetEtalon(inventoryBox.Text, factoryBox.Text);
                    if (IsEtalon == false)
                    {
                        EtalonStatusCheckBox.Checked = false;
                    }
                    else
                    {
                        EtalonStatusCheckBox.Checked = true;
                    }
                    conditionBox.Text = "Condition";
                    equipmentBox.Text = "Equipment";
                    descriptionBox.Text = "Description";
                    belongBox.Text = "Belongs";

                }
                else
                {
                    MessageBox.Show("Ошибка. СИ с таким инвентарным и/или заводским номером не найдено.");
                }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            typeBox.Clear();
            manufacturerBox.Clear();
            rangeBox.Clear();
            inventoryBox.Clear();
            factoryBox.Clear();
            EtalonStatusCheckBox.Checked = false;
            equipmentBox.Clear();
            descriptionBox.Clear();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            

        }

        private void DGWMeasureViewLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            MeasuringInstrumentDGV F = new MeasuringInstrumentDGV();
            F.ShowDialog();
            this.Show();

        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
