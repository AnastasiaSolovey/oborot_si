using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Venue
    {
            public int ID { get; set; }
            public string VenueName { get; set; }

            public Venue()
            {

            }

            public Venue(DataRow input)
            {
                ID = Convert.ToInt32(input["id_venue"]);
                VenueName = DB.DataConverter.Convert<string>(input["venue"]);
            }
    }
}
