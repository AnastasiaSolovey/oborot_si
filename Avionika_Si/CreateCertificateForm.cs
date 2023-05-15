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
using Word = Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using Avionika_Si;
using Avionika_Si.Models;
using Avionika_Si.Helpers;
using Oborot_SI;


namespace Oborot_SI
{
    public partial class CreateCertificateForm : Form
    {
        Certificate inputProtocol = null;

        public CreateCertificateForm()
        {
            InitializeComponent();
        }
        public CreateCertificateForm(Certificate cerificate)
        {
            inputProtocol = new Certificate(cerificate);
            InitializeComponent();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {

            Certificate certificate = new Certificate
                (int.Parse(NumProtocolBox.Text), NameMeasuringInstrumentBox.Text, FactoryNumBox.Text, InventoryNumBox.Text, DepartmentBox.Text, 
                DateTime.Parse(oldDateTextBox.Text), DateTime.Parse(newDateTextBox.Text), EmployeeBox.Text);

            WordHelper.CreateCertificateDoc(certificate);

        }

        private void Attestat_Load(object sender, EventArgs e)
        {
            if (inputProtocol != null)
            {
                NumProtocolBox.Text = inputProtocol.ProtocolNumber.ToString();
                NameMeasuringInstrumentBox.Text = inputProtocol.MeasuringInstrumentName;
                FactoryNumBox.Text = inputProtocol.FactoryNumber;
                InventoryNumBox.Text = inputProtocol.InventoryNumber;
                DepartmentBox.Text = inputProtocol.Department;
                oldDateTextBox.Text = inputProtocol.OldDate.ToString("dd    MMMM     yyyy");
                newDateTextBox.Text = inputProtocol.NewDate.ToString("dd    MMMM    yyyy");
                EmployeeBox.Text = inputProtocol.EmployeeName;
            }
        }
    }
}
