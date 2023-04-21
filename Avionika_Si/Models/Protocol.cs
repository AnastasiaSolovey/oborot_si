using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseAdapter;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Protocol
    {
        public int ID { get; set; }
        public int NumProtocol { get; set; }
        public int InstrumentNameReferenceID { get; set; }
        public string Description { get; set; }
        public int EmployeeReferenceID { get; set; }
        public InstrumentName InstrName { get; set; }
        public Employee Employee { get; set; }

        public Protocol()
        {

        }

        public Protocol(DataRow input)
        {
            ID = DB.DataConverter.Convert<int>(input["id_protocol"]);
            NumProtocol = DB.DataConverter.Convert<int>(input["num_protocol"]);
            InstrumentNameReferenceID = DB.DataConverter.Convert<int>(input["id_measuring_instrument"]);
            Description = DB.DataConverter.Convert<string>(input["description"]);
            EmployeeReferenceID = DB.DataConverter.Convert<int>(input["id_employee"]);

            Program.DbHelper.GetInstrumentNameById(InstrumentNameReferenceID);
            Program.DbHelper.GetEmployeeByID(EmployeeReferenceID);
        }
        public bool Create()
        {
            return Program.DbHelper.CreateProtocol(this);
        }
    }
   
}
