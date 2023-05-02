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
        public JournalForm()
        {
            InitializeComponent();
        }
        private JournalForm LastNum = null;
        private void InitTypeWorkBox()
        {
            TypeworkBox.DataSource = Program.DbHelper.GetTypeWork();
            TypeworkBox.DisplayMember = "Type";
            TypeworkBox.ValueMember = "ID";
        }

        private void InitConclusionBox()
        {
            ConclusionBox.DataSource = Program.DbHelper.GetConclusion();
            ConclusionBox.DisplayMember = "ConclusionName";
            ConclusionBox.ValueMember = "ID";
        }


        private void Journal_Load(object sender, EventArgs e) 
        {

            InitTypeWorkBox();
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
                        TypeWorkReferenceID = Convert.ToInt32(TypeworkBox.SelectedValue),
                    };

                    if (journal.Create())
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
        private void JournalForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
