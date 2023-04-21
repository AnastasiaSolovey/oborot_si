using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{

     public class Department
     {
        public int ID { get; set; }
        public string Departments { get; set; }

        public Department()
        {

        }

        public Department(Department input)
        {
            ID = input.ID;
            Departments = input.Departments;
        }

        public Department(DataRow input)
        {
            ID = Convert.ToInt32(input["id_department"]);
            Departments = DB.DataConverter.Convert<string>(input["department"]);
        }
     }
}
