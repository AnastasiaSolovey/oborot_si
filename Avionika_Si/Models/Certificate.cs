using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB = DatabaseAdapter;

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

        public Certificate(DataRow input)
        {
            ProtocolNumber = DB.DataConverter.Convert<int>(input["num_protocol"]);
            MeasuringInstrumentName = DB.DataConverter.Convert<string>(input["name_instrument"]);
            FactoryNumber = DB.DataConverter.Convert<string>(input["factory_number"]);
            InventoryNumber = DB.DataConverter.Convert<string>(input["inventory_number"]);
            Department = DB.DataConverter.Convert<string>(input["department"]);
            OldDate = DB.DataConverter.Convert<DateTime>(input["old_date"]);
            NewDate = DB.DataConverter.Convert<DateTime>(input["next_date"]);
            EmployeeName = DB.DataConverter.Convert<string>(input["employee_name"]);
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
        public Certificate(Certificate input)
        {

            ProtocolNumber = input.ProtocolNumber;
            MeasuringInstrumentName = input.MeasuringInstrumentName;
            FactoryNumber = input.FactoryNumber;
            InventoryNumber = input.InventoryNumber;
            Department = input.Department;
            OldDate = input.OldDate;
            NewDate = input.NewDate;
            EmployeeName = input.EmployeeName;


        }
    }
}
