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
    public class Journal
    {
        public int ID { get; set; }
        public int NumJournal { get; set; }
        public DateTime Date { get; set; }
        public int MeasuringInstrumentReferenceId { get; set; }
        public int ConclusionReferenceId { get; set; }
        public int TypeWorkReferenceID { get; set; }
        public string InventoryReference { get; set; }
        public string FactoryReference { get; set; }
        public MeasuringInstrument MeasureInst { get; set; }
        public Conclusion Conclus { get; set; }
        public TypeWork Type { get; set; }
        public MeasuringInstrument InventNumber { get; set; }
        public MeasuringInstrument FactorNumber { get; set; }

        public Journal()
        {

        }
        public Journal(DataRow input)
        {
            ID = DB.DataConverter.Convert<int>(input["id_journal"]);
            NumJournal = DB.DataConverter.Convert<int>(input["num_journal"]);
            Date = DB.DataConverter.Convert<DateTime>(input["date"]);
            MeasuringInstrumentReferenceId = DB.DataConverter.Convert<int>(input["id_measuring_instrument"]);
            ConclusionReferenceId = DB.DataConverter.Convert<int>(input["id_conclusion"]);
            TypeWorkReferenceID = DB.DataConverter.Convert<int>(input["id_type_work"]);
            InventoryReference = DB.DataConverter.Convert<string>(input["inventory_number"]);
            FactoryReference = DB.DataConverter.Convert<string>(input["factory_number"]);
            Program.DbHelper.GetConclusionById(ConclusionReferenceId);
            Program.DbHelper.GetTypeWorkById(TypeWorkReferenceID);
            Program.DbHelper.GetInventoryById(InventoryReference);
            Program.DbHelper.GetFactoryById(FactoryReference);
        }


        public bool Create()
        {
            return Program.DbHelper.CreateJournal(this);
        }
        public bool InstrNum()
        {
            return Program.DbHelper.GetInventoryFactoryQuery(this);
        }
    }

  
}

