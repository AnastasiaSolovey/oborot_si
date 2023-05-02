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
        public string DepartmentName { get; set; }

        public Department()
        {

        }

        public Department(Department input)
        {
            ID = input.ID;
            DepartmentName = input.DepartmentName;
        }

        public Department(DataRow input)
        {
            ID = Convert.ToInt32(input["id_department"]);
            DepartmentName = DB.DataConverter.Convert<string>(input["department"]);
        }
     }
}
