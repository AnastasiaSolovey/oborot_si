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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using Avionika_Si;
using System.Globalization;

namespace Oborot_SI
{
    public partial class JournalForm : Form
    {
        public string SelectedInventoryNumJournal { get; set; }
        public string SelectedFactoryNumJournal { get; set; }
        public JournalForm()
        {
            InitializeComponent();
        }
        private JournalForm LastNum = null;

        private void InitConclusionBox()
        {
            ConclusionBox.DataSource = Program.DbHelper.GetConclusion();
            ConclusionBox.DisplayMember = "ConclusionName";
            ConclusionBox.ValueMember = "ID";
        }


        private void Journal_Load(object sender, EventArgs e) 
        {

            InitConclusionBox();

            LastNumLabel.Text = "Последний номер в журнале " + Program.DbHelper.GetLastNumJournalQuery();

        }



        private void Add_Button_Click(object sender, EventArgs e)
        {

            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);

            if (refMeasuringInstrumentId!=0)
            {
              
                    Avionika_Si.Models.Journal journal = new Avionika_Si.Models.Journal()
                    {
                        NumJournal = Convert.ToInt32(JournalNumberUpDown.Value),
                        MeasuringInstrumentReferenceId = refMeasuringInstrumentId,
                        ConclusionReferenceId = Convert.ToInt32(ConclusionBox.SelectedValue),
                    };

                    if (journal.Create())
                    {
                        this.Hide();
                        ProtocolForm form = new ProtocolForm();
                        form.SelectedInventoryNumProtocol = InventoryBox.Text;
                        form.SelectedFactoryNumProtocol = FactoryBox.Text;
                        form.Show();
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
        private void JournalForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ChoseMeasuringInstrumentButton_Click(object sender, EventArgs e)
        {
            SelectedInventoryNumJournal = null;
            SelectedFactoryNumJournal = null;
            MeasuringInstrumentDGV form = new MeasuringInstrumentDGV(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                InventoryBox.Text = form.PickedMeasuringInstrument.InventoryNumber;
                FactoryBox.Text = form.PickedMeasuringInstrument.FactoryNumber;
                SelectedInventoryNumJournal = InventoryBox.Text;
                SelectedFactoryNumJournal = FactoryBox.Text;
            }
        }
    }
}
