﻿using System;
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
        public int InstrumentNameReferenceID { get; set; }
        public string Frequency { get; set; }
        public string OldVenueReferenceID { get; set; }
        public string NextDate { get; set; }
        public string NewVenueReferenceID { get; set; }
        public DateTime WorkDate { get; set; }
        public InstrumentName InstName { get; set; }
        public Venue OldVenue { get; set; }
        public Venue NewVenue { get; set; }
        public int ConclusionReferenceId { get; set; }
        public int TypeWorkReferenceID { get; set; }
        public MeasuringInstrument TypeInstr { get; set; }
        public Conclusion Conclus { get; set; }
        public string TypeMeasuringInstrument { get; set; }
        public string InventoryNumber { get; set; }
        public MeasuringInstrument Inventory { get; set; }
        public string FactoryNumber { get; set; }
        public MeasuringInstrument Factory { get; set; }
        public TypeWork Type { get; set; }
    }
}
