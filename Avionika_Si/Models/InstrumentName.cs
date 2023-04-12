using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class InstrumentName
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public InstrumentName()
        {

        }

        public InstrumentName(DataRow input)
        {
            ID = Convert.ToInt32(input["id_name_instrument"]);
            Name = DB.DataConverter.Convert<string>(input["name_instrument"]);
        }
    }
}
