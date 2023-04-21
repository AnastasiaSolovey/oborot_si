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
using Avionika_Si;

namespace Oborot_SI
{
    public partial class ScheduleView : Form
    {
        private List<Schedule> schedule = null;
        public ScheduleView()
        {
            InitializeComponent();
            FillMesInstrumentsDataGrid();
        }

        private void FillMesInstrumentsDataGrid()
        {
            schedule = Program.DbHelper.GetMeasuringInstrumentsList();
            TableHelper.FillMeasuringInstrumentsTable(schedule, scheduleGridView);
        }
        

        private void Add_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void scheduleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainMenu F = new MainMenu();
            F.Show();
        }

 
    }
}
