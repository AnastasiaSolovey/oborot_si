using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Avionika_Si.Models
{
    public class ReferenceData
    {
        public Dictionary<int, InstrumentName> InstrumentNames { get; set; }
        public Dictionary<int, Condition> Conditions { get; set; }
        public Dictionary<int, Department> Department { get; set; }
        public Dictionary<int, Venue> Venues { get; set; }

        public static ReferenceData InitReferenceData()
        {
            return new ReferenceData
            {
                InstrumentNames = Program.DbHelper.GetInstrumentNames().ToDictionary(x => x.ID, x => x),
                Conditions = Program.DbHelper.GetConditions().ToDictionary(x => x.ID, x => x),
                Department = Program.DbHelper.GetDepartment().ToDictionary(x=>x.ID, x => x),
                Venues = Program.DbHelper.GetVenue().ToDictionary(x => x.ID, x => x)
            };
            
        }
    }
}
