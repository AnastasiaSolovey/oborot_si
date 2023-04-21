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

namespace Oborot_SI
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
        }

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


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            int refMeasuringInstrumentId = Program.DbHelper.GetInventoryFactoryQuery(InventoryBox.Text, FactoryBox.Text);

            if (refMeasuringInstrumentId!=0)
            {
                Avionika_Si.Models.Journal journal = new Avionika_Si.Models.Journal()
                {
                    NumJournal = Convert.ToInt32(NumBox.Text),
                    Date = DateworkBox.Value,
                    MeasuringInstrumentReferenceId = refMeasuringInstrumentId,
                    ConclusionReferenceId = Convert.ToInt32(ConclusionBox.SelectedValue),
                    TypeWorkReferenceID = Convert.ToInt32(TypeworkBox.SelectedValue),
                };

                if (journal.Create())
                {
                    MessageBox.Show("Запись добавлена");
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

     
    }
}
