using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB = DatabaseAdapter;

namespace Avionika_Si.Models
{
    public class EmployeeData
    {
        public int ID { get; set; }
        public int EmployeeReferenceID { get; set; }
        public DateTime DateCertification { get; set; }
        public string Login { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }
        public int RoleReferenceID { get; set; }
        public int IsActive { get; set; }

        public EmployeeData()
        {

        }

        public EmployeeData(DataRow input)
        {
            ID = DB.DataConverter.Convert<int>(input["id_employee_data"]);
            EmployeeReferenceID = DB.DataConverter.Convert<int>(input["id_employee"]);
            DateCertification = DB.DataConverter.Convert<DateTime>(input["id_employee"]);
            Login = DB.DataConverter.Convert<string>(input["login"]);
            Salt = DB.DataConverter.Convert<string>(input["salt"]);
            PasswordHash = DB.DataConverter.Convert<string>(input["password_hash"]);
            RoleReferenceID = DB.DataConverter.Convert<int>(input["id_role"]);
            IsActive = DB.DataConverter.Convert<int>(input["is_active"]);
           

            Program.DbHelper.GetEmployeeByID(EmployeeReferenceID);
            Program.DbHelper.GetRoleById(RoleReferenceID);
        }
    }
}
