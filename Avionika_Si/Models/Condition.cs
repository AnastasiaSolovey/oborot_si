using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Condition
    {
        public int ID { get; set; }
        public string ConditionName { get; set; }

        public Condition()
        {

        }

        public Condition(Condition input)
        {
            ID = input.ID;
            ConditionName = input.ConditionName;
        }

        public Condition(DataRow input)
        {
            ID = Convert.ToInt32(input["id_condition"]);
            ConditionName = DB.DataConverter.Convert<string>(input["condition"]);
        }
    }
}
