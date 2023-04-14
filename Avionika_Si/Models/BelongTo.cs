using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{

     public class BelongTo
     {
            public int ID { get; set; }
            public string Belongs { get; set; }

            public BelongTo()
            {

            }

            public BelongTo(DataRow input)
            {
                ID = Convert.ToInt32(input["id_belong_to"]);
                Belongs = DB.DataConverter.Convert<string>(input["belong_to"]);
            }
     }
}
