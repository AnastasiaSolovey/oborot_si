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
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
            //Width = Screen.PrimaryScreen.Bounds.Width;
            //Height = Screen.PrimaryScreen.Bounds.Height;
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

          private void InitIdJournalBox()
         {
             var InstrId = Program.DbHelper.GetInventoryFactoryQuery();
         }


        private void Journal_Load(object sender, EventArgs e) //вывод на экран следующего номера в журнале
        {

            InitTypeWorkBox();
            InitConclusionBox();
           // InitIdJournalBox();


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            InventoryBox.Clear();
            FactoryBox.Clear();
            DateworkBox.Value = DateTime.Now;
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
           // int nextId = Program.DbHelper.GetLastIdJournalQuery() + 1;
            //idBox.Text = nextId.ToString();
            

            Avionika_Si.Models.Journal journal = new Avionika_Si.Models.Journal()
            {
                NumJournal = Convert.ToInt32(NumBox.Text),
                Date = DateworkBox.Value,
                //?MeasuringInstrumentReferenceId = Convert.ToInt32(NumBox.Text),
                ConclusionReferenceId = Convert.ToInt32(ConclusionBox.SelectedValue),
                TypeWorkReferenceID = Convert.ToInt32(TypeworkBox.SelectedValue),
            };

            if (journal.Create())
            {
                MessageBox.Show("Запись добавлена");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void journal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conclusionLabel_Click(object sender, EventArgs e)
        {

        }

        private void conclusionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeworkLabel_Click(object sender, EventArgs e)
        {

        }

        private void typeworkBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateworkBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void factoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void factoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
