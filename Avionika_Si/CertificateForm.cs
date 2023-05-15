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
    Certificate inputProtocol = null;
    public partial class CertificateForm : Form
    {
        public CertificateForm()
        {
            InitializeComponent();
        }
        public CertificateForm(Certificate cerificate)
        {
            inputProtocol = new Certificate(cerificate);
            InitializeComponent();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {

            Certificate certificate = new Certificate
                (int.Parse(NumProtocolBox.Text), NameMeasuringInstrumentBox.Text, FactoryNumBox.Text, InventoryNumBox.Text, DepartmentBox.Text, 
                DateWorkBox.Value, NextDateWorkBox.Value, EmployeeBox.Text);

            WordHelper.CreateCertificateDoc(certificate);

        }

        private void Attestat_Load(object sender, EventArgs e)
        {
            if (inputProtocol != null)
            {
                NumProtocolBox.Text = inputProtocol.ProtocolNumber;
                NameMeasuringInstrumentBox.Text = inputProtocol.MeasuringInstrumentName;
                FactoryNumBox.Text = inputProtocol.FactoryNumber;
                InventoryNumBox.Text = inputProtocol.InventoryNumber;
                DepartmentBox.Text = inputProtocol.Department;
                DateWorkBox.Text = inputProtocol.OldDate;
                NextDateWorkBox.Text = inputProtocol.NewDate;
                EmployeeBox.Text = inputProtocol.EmployeeName;
            }
        }
    }
}
