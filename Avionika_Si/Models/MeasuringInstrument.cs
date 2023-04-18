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

    public class MeasuringInstrument
    {
        public int ID { get; set; }
        public int InstrumentNameReferenceID { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string MeasuringRange { get; set; }
        public string InventoryNumber { get; set; }
        public string FactoryNumber { get; set; }
        public bool Etalon { get; set; }
        public int ConditionReferenceId { get; set; }
        public string Equipment { get; set; }
        public string Description { get; set; }
        public int BelongsToReferenceID { get; set; }
        public InstrumentName InstName { get; set; }
        public Condition Cond { get; set; }
        public BelongTo Belongs { get; set; }
        public List<MeasuringInstrument> InstrumentList { get; set; }


        public MeasuringInstrument()
        {
            InstrumentList = new List<MeasuringInstrument>();
        }

        public MeasuringInstrument(DataRow input)
        {
            ID = DB.DataConverter.Convert<int>(input["id_measuring_instrument"]);
            InstrumentNameReferenceID = DB.DataConverter.Convert<int>(input["id_name_instrument"]);
            Type = DB.DataConverter.Convert<string>(input["type"]);
            Manufacturer = DB.DataConverter.Convert<string>(input["manufacturer"]);
            MeasuringRange = DB.DataConverter.Convert<string>(input["measuring_range"]);
            InventoryNumber = DB.DataConverter.Convert<string>(input["inventory_number"]);
            FactoryNumber = DB.DataConverter.Convert<string>(input["factory_number"]);
            Etalon = DB.DataConverter.Convert<bool>(input["etalon"]);
            ConditionReferenceId = DB.DataConverter.Convert<int>(input["id_condition"]);
            Equipment = DB.DataConverter.Convert<string>(input["equipment"]);
            Description = DB.DataConverter.Convert<string>(input["description"]);
            BelongsToReferenceID = DB.DataConverter.Convert<int>(input["id_belong_to"]);

            Program.DbHelper.GetInstrumentNameById(InstrumentNameReferenceID);
            Program.DbHelper.GetConditionById(ConditionReferenceId);
            Program.DbHelper.GetBelongToById(BelongsToReferenceID);
        }

        public MeasuringInstrument(string login, DateTime date, DateTime startTime, DateTime endTime, string comment, int ownerProblemID, bool lunchBreakFlag)
        {
          
        }

        public bool Create()
        {
            return Program.DbHelper.CreateMeasuringInstrument(this);
        }

    
        public bool Update()
        {
            return Program.DbHelper.UpdateInstrument(this);
        }


    }
}
