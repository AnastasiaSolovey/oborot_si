using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{

        public class TypeWork
        {
            public int ID { get; set; }
            public string Type { get; set; }

            public TypeWork()
            {

            }

            public TypeWork(DataRow input)
            {
                ID = Convert.ToInt32(input["id_type_work"]);
                Type = DB.DataConverter.Convert<string>(input["type_of_work"]);
            }
        }
}
