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
using Avionika_Si.Helpers;

namespace Avionika_Si.Dummy
{
    public partial class DummyCertForm : Form
    {
        public DummyCertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Certificate certificate = new Certificate(1, "TEST_Name", "TEST_fac_num", "test_inv_num", "DummyDep", DateTime.Today, DateTime.Today.AddDays(3), "Pupkin V.V.");

            WordHelper.CreateCertificateDoc(certificate);
        }
    }
}
