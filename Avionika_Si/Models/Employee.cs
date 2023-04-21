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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }



        public Employee()
        {

        }

        public Employee(DataRow input)
        {
            ID = Convert.ToInt32(input["id_employee"]);
            Name = DB.DataConverter.Convert<string>(input["name"]);
            Surname = DB.DataConverter.Convert<string>(input["surname"]);
            Patronymic = DB.DataConverter.Convert<string>(input["patronymic"]);
        }
    }
}
