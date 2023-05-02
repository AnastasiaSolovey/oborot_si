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
    public class Schedule
    {
        public int ID { get; set; }
        public int MeasuringInstrumentReferenceId { get; set; }
        public int InstrumentNameReferenceID { get; set; }
        public string TypeReference { get; set; }
        public string InventoryNumberReference { get; set; }
        public string FactoryNumberReference { get; set; }
        public int Frequency { get; set; }
        public DateTime OldWorkDate { get; set; }
        public int OldVenueReferenceID { get; set; }
        public DateTime NextWorkDate { get; set; }
        public int NewVenueReferenceID { get; set; }
        public int ConclusionReferenceID { get; set; }
        public int TypeWorkReferenceID { get; set; }
        public InstrumentName InstName { get; set; }
        public Venue VenueOldName { get; set; }
        public Venue VenueNewName { get; set; }

        public Schedule()
        {

        }

        public Schedule(DataRow input)
        {
            ID = DB.DataConverter.Convert<int>(input["id_schedule"]);
            MeasuringInstrumentReferenceId = DB.DataConverter.Convert<int>(input["id_measuring_instrument"]);
            InstrumentNameReferenceID = DB.DataConverter.Convert<int>(input["id_name_instrument"]);
            TypeReference = DB.DataConverter.Convert<string>(input["type"]);
            InventoryNumberReference = DB.DataConverter.Convert<string>(input["inventory_number"]);
            FactoryNumberReference = DB.DataConverter.Convert<string>(input["factory_number"]);
            Frequency = DB.DataConverter.Convert<int>(input["frequency"]);
            OldWorkDate = DB.DataConverter.Convert<DateTime>(input["old_date"]);
            OldVenueReferenceID = DB.DataConverter.Convert<int>(input["id_venue"]);
            NextWorkDate = DB.DataConverter.Convert<DateTime>(input["next_date"]);
            NewVenueReferenceID = DB.DataConverter.Convert<int>(input["id_venue"]);
            ConclusionReferenceID = DB.DataConverter.Convert<int>(input["id_conclusion"]);
            TypeWorkReferenceID = DB.DataConverter.Convert<int>(input["id_type_work"]);

            InstName = Program.References.InstrumentNames[InstrumentNameReferenceID];
            VenueOldName = Program.References.Venues[OldVenueReferenceID];
            VenueNewName = Program.References.Venues[NewVenueReferenceID];
        }
        public Schedule(Schedule input)
        {
           /* ID = input.ID;
            InstrumentNameReferenceID = input.InstrumentNameReferenceID;
            TypeReference = input.TypeReference;
            InventoryNumberReference = input.InventoryNumberReference;
            FactoryNumberReference = input.FactoryNumberReference;
            Frequency = input.Frequency;
            OldWorkDate = input.OldWorkDate;
            OldVenueReferenceID = input.OldVenueReferenceID;
            NextWorkDate = input.NextWorkDate;
            NewVenueReferenceID = input.NewVenueReferenceID;
            ConclusionReferenceID = input.ConclusionReferenceID;
            TypeWorkReferenceID = input.TypeWorkReferenceID;

            InstName = new InstrumentName(input.InstName);
            VenueOldName = new Venue(input.VenueOldName);
            VenueNewName = new Venue(input.VenueNewName);*/
        }
        public bool Create()
        {
            return Program.DbHelper.CreateSchedule(this);
        }
    }
}
