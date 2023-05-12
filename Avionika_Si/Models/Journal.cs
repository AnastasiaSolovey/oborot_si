using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseAdapter;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using System.Globalization;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class Journal
    {
        public int ID { get; set; }
        public int NumJournal { get; set; }
        public int ScheduleReferenceId { get; set; }
        public int ConclusionReferenceId { get; set; }
        public int TypeWorkReferenceID { get; set; }
        public MeasuringInstrument InventoryNumber { get; set; }
        public MeasuringInstrument FactoryNumber { get; set; }
        public int Year { get; set; }
        


        public Journal()
        {

        }
        public Journal(DataRow input)
        {
            ID = DB.DataConverter.Convert<int>(input["id_journal"]);
            NumJournal = DB.DataConverter.Convert<int>(input["num_journal"]);
            ScheduleReferenceId = DB.DataConverter.Convert<int>(input["schedule_reference"]);
            ConclusionReferenceId = DB.DataConverter.Convert<int>(input["id_conclusion"]);
            Year = DB.DataConverter.Convert<int>(input["year"]);
            Program.DbHelper.GetConclusionById(ConclusionReferenceId);
        }


        public bool Create()
        {
            return Program.DbHelper.CreateJournal(this);
        }
    }

  
}

