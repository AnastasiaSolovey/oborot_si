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
    public class Passport
    {
        public MeasuringInstrument ID { get; set; }
        public InstrumentName InstName { get; set; }
        public MeasuringInstrument Type { get; set; }
        public MeasuringInstrument Manufacturer { get; set; }
        public MeasuringInstrument Inventory { get; set; }
        public MeasuringInstrument Factory { get; set; }
        public Department Department { get; set; }
        public Journal DateWork { get; set; }
        public Conclusion Conclusion { get; set; }
        public TypeWork TypeWork { get; set; }
    }
}
