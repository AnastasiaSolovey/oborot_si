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


namespace Oborot_SI
{
    public partial class ScheduleDGV : Form
    {
        private List<Schedule> schedules = null;
        public ScheduleDGV()
        {
            InitializeComponent();
            FillScheduleDataGrid();
        }

        private void FillScheduleDataGrid()
        {
           //schedules = Program.DbHelper.GetScheduleList();
           TableHelper.FillScheduleTable(Program.DbHelper.GetScheduleList(DateTime.Today.Date), scheduleGridView);
        }
        

        private void Add_Button_Click(object sender, EventArgs e)
        {
            
        }


        private void ScheduleView_Load(object sender, EventArgs e)
        {

        }

        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm form = new ScheduleForm();
            form.Show();
        }
    }
}
