using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public Employee()
        {

        }

        public Employee(DataRow input)
        {
            ID = Convert.ToInt32(input["id_employee"]);
        }
    }
}
