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
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Avionika_Si.Models.Protocol AddProtocol = new Avionika_Si.Models.Protocol()
            {
            Note = Convert.ToString(NoteBox.Text),
            EmployeeReferenceID = Convert.ToInt32(employeeBox.SelectedValue),
             };

             if (AddProtocol.Create())
             {
                this.Hide();
             }
             else
             {
                MessageBox.Show("Ошибка. Проверьте корректность введеных данных");
             }
        }

        private void ProtocolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Закончите заполнение всех данных");
            e.Cancel = true;
        }
    }
}
