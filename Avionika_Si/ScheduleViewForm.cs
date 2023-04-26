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
using Oborot_SI;


namespace Oborot_SI
{
    public partial class ScheduleView : Form
    {
        private List<Schedule> schedules = null;
        private Schedule SelectedInstrument = null;
        public ScheduleView()
        {
            InitializeComponent();
            FillScheduleDataGrid();
        }

        private void FillScheduleDataGrid()
        {
           //schedules = Program.DbHelper.GetScheduleList();
           //TableHelper.FillScheduleTable(schedules, scheduleGridView);
        }
        

        private void Add_Button_Click(object sender, EventArgs e)
        {
            
        }


        private void ScheduleView_Load(object sender, EventArgs e)
        {

        }
    }
}
