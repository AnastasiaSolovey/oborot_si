using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Role
    {
            public int ID { get; set; }
            public string RoleName { get; set; }

            public Role()
            {

            }

            public Role(DataRow input)
            {
                ID = Convert.ToInt32(input["id_role"]);
                RoleName = DB.DataConverter.Convert<string>(input["role"]);
            }
        
    }
}
