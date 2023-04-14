using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Conclusion
    {
        public int ID { get; set; }
        public string ConclusionName { get; set; }

        public Conclusion()
        {

        }

        public Conclusion(DataRow input)
        {
            ID = Convert.ToInt32(input["id_conclusion"]);
            ConclusionName = DB.DataConverter.Convert<string>(input["conclusion"]);
        }
    }
}
