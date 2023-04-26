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
        public Dictionary<int, Department> Departments { get; set; }

        public static ReferenceData InitReferenceData()
        {
            return new ReferenceData
            {
                InstrumentNames = Program.DbHelper.GetInstrumentNames().ToDictionary(x => x.ID, x => x),
                Conditions = Program.DbHelper.GetConditions().ToDictionary(x => x.ID, x => x),
                Departments = Program.DbHelper.GetDepartments().ToDictionary(x=>x.ID, x => x)
            };
            
        }
    }
}
