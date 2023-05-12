using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avionika_Si.Models
{
    public class Certificate
    {
        public int ProtocolNumber { get; set; }
        public string MeasuringInstrumentName { get; set; }
        public string FactoryNumber { get; set; }
        public string InventoryNumber { get; set; }
        public string Department { get; set; }
        public DateTime OldDate { get; set; }
        public DateTime NewDate { get; set; }
        public string EmployeeName { get; set; }

        public Certificate(int protocolNumber, string measuringInstrumentName, string factoryNumber, string inventoryNumber, string department, DateTime oldDate, DateTime newDate, string employeeName)
        {
            ProtocolNumber = protocolNumber;
            MeasuringInstrumentName = measuringInstrumentName;
            FactoryNumber = factoryNumber;
            InventoryNumber = inventoryNumber;
            Department = department;
            OldDate = oldDate;
            NewDate = newDate;
            EmployeeName = employeeName;
        }

        public Dictionary<string, string> GetCertificatePropsDictionartForWord()
        {
            return new Dictionary<string, string>()
            {
                {"ProtocolNumber", ProtocolNumber.ToString()},
                {"MesInstrName", MeasuringInstrumentName},
                {"MesInsFactoryNum", FactoryNumber},
                {"MesInsInvNum", InventoryNumber},
                {"MesInsDepartment", Department},
                {"OldDate", OldDate.ToString("dd.MM.yyyy")},
                {"NewDate", NewDate.ToString("dd.MM.yyyy")},
                {"Employee", EmployeeName}
            };
        }
    }
}
