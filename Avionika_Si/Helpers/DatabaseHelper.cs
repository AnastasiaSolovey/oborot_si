using DatabaseAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Avionika_Si.Models;
using Oborot_SI;
using System.Windows.Forms;

namespace Avionika_Si.Helpers
{
    public class DatabaseHelper
    {
        private string connectionString = "server=avitube;user id=OborotSiAdmin;password=siOborotPassword2023;charset=utf8;persistsecurityinfo=True;" +
            "database=oborot_si;allowuservariables=True";
        private IDatabaseAdapter DatabaseAdapter;

        public DatabaseHelper()
        {
            DatabaseAdapter = new MySqlAdapter(connectionString);
        }

        public List<Models.MeasuringInstrument> GetMeasuringInstrumentsList()
        {
            return DatabaseAdapter.GetListDataByQuery<Models.MeasuringInstrument>
                ($"SELECT `measuring_instrument`.`id_measuring_instrument`," +
                $"`measuring_instrument`.`id_name_instrument`," +
                $"`measuring_instrument`.`type`," +
                $"`measuring_instrument`.`manufacturer`," +
                $"`measuring_instrument`.`measuring_range`," +
                $"`measuring_instrument`.`inventory_number`," +
                $"`measuring_instrument`.`factory_number`," +
                $"`measuring_instrument`.`etalon`," +
                $"`measuring_instrument`.`id_condition`," +
                $"`measuring_instrument`.`equipment`," +
                $"`measuring_instrument`.`description`," +
                $"`measuring_instrument`.`id_department`" +
                $"FROM `oborot_si`.`measuring_instrument` ORDER BY `measuring_instrument`.`id_name_instrument`;");
        }
        public List<Models.Journal> GetJournalList()
        {
            return DatabaseAdapter.GetListDataByQuery<Models.Journal>
                ($"SELECT `journal`.`id_journal`, " +
                $"`journal`.`num_journal`," +
                $"`name_instrument`.`name_instrument`," +
                $"`measuring_instrument`.`type`," +
                $"`measuring_instrument`.`inventory_number`," +
                $"`measuring_instrument`.`factory_number`," +
                $" `conclusion`.`conclusion`," +
                $" `type_of_work`.`type_of_work`  " +
                $" FROM `oborot_si`.`journal` " +
                $"JOIN `oborot_si`.`schedule` " +
                $" on  `schedule`.`id_schedule` = `journal`.`schedule_reference` " +
                $" JOIN `oborot_si`.`measuring_instrument`" +
                $"on `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` " +
                $"JOIN `oborot_si`.`conclusion` " +
                $"on `conclusion`.`id_conclusion` = `journal`.`id_conclusion` " +
                $"JOIN `oborot_si`.`name_instrument`" +
                $"on `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` " +
                $"JOIN `oborot_si`.`type_of_work`  " +
                $"on `type_of_work`.`id_type_work` = `schedule`.`id_type_work` " +
                $" ORDER BY `journal`.`num_journal`; ");
        }

        public DataTable GetScheduleList(DateTime nextDate)//поверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleVerificationByData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleCalibrationCheckList(DateTime nextDate)//калибровка и проверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleCalibrationCheckByData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleListByInventoryFactoryNumbers(DateTime nextDate, string inventory_num, string factory_num)//поверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleVerificationDataByInventoryFactoryNumbers`('{nextDate.ToString("yyyy-MM-dd")}', '{inventory_num}', '{factory_num}');");
        }

        public DataTable GetJournalByInventoryFactoryNumbers(string inventory_num, string factory_num)
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetJournalDGVByInventoryFactory`('{inventory_num}', '{factory_num}');");
        }
        public DataTable GetProtocolDGVByInventoryFactoryNumbers(string inventory_num, string factory_num)
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetProtocolDGVByInventoryFactoryNumbers`('{inventory_num}', '{factory_num}');");
        }
        public DataTable GetCertificateByInventoryFactoryNumbers(string inventory_num, string factory_num)
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetCertificateByInventoryFactoryNumbers`('{inventory_num}', '{factory_num}');");
        }
        public DataTable GetScheduleArchiveByInventoryFactory(string inventory_num, string factory_num)//поверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleVerificationArchiveByInventoryFactory`('{inventory_num}', '{factory_num}');");
        }
        public DataTable GetJournalDGV()
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetJournalDGV`;");
        }
        public DataTable GetCertificateDGV()
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetCertificateDGV`;");
        }
        public DataTable GetProtocolDGV()
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetProtocolDGV`;");
        }
        public DataTable GetScheduleArchive()//поверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleVerificationArchive`;");
        }
        public DataTable GetScheduleByNextDataFilter(DateTime nextDate)//поверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleVerificationByNextDataFilter`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleArchiveByData(DateTime nextDate)//поверка
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleVerificationArchiveByData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleCalibrationCheckDataByInventoryFactoryNumbers(DateTime nextDate, string inventory_num, string factory_num)//поиск калибровки и проверки по инвентарному и заводскому номеру
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleCalibrationCheckDataByInventoryFactoryNumbers`('{nextDate.ToString("yyyy-MM-dd")}', '{inventory_num}', '{factory_num}');");
        }
        public DataTable GetScheduleCalibrationByNextData(DateTime nextDate)//поиск калибровки и проверки по дате
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleCalibrationByNextData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleCalibrationCheckArchive()//поиск архива калибровки и проверки
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleCalibrationCheckArchive`();");
        }
        public DataTable GetScheduleCalibrationCheckArchiveByInventoryFactory(string inventory_num, string factory_num)//поиск архива калибровки и проверки по инвентарному и заводскому номеру
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleCalibrationCheckArchiveByInventoryFactory`('{inventory_num}', '{factory_num}');");
        }
        public DataTable GetScheduleCalibrationCheckArchiveByData(DateTime nextDate)//поиск архива калибровки и проверки по дате
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleCalibrationCheckArchiveByData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleOnlyCalibrationByData(DateTime nextDate)//поиск калибровок
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCalibrationByData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers(DateTime nextDate, string inventory_num, string factory_num)//поиск калибровки по номерам
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers`('{nextDate.ToString("yyyy-MM-dd")}', '{inventory_num}', '{factory_num}');");
        }
        public DataTable GetScheduleOnlyCalibrationByNextData(DateTime nextDate)//поиск калибровок по дате
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCalibrationByNextData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleOnlyCalibrationArchive()//поиск архива калибровок
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCalibrationArchive`();");
        }
        public DataTable GetScheduleOnlyCalibrationArchiveByInventoryFactory(string inventory_num, string factory_num)//поиск архива калибровок по номерам
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCalibrationArchiveByInventoryFactory`('{inventory_num}', '{factory_num}');");
        }
        public DataTable GetScheduleOnlyCheckByData(DateTime nextDate)//поиск проверки
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCheckByData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleOnlyCheckDataByInventoryFactoryNumbers(DateTime nextDate, string inventory_num, string factory_num)//поиск проверки по номерам 
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCheckDataByInventoryFactoryNumbers`('{nextDate.ToString("yyyy-MM-dd")}', '{inventory_num}', '{factory_num}');");
        }
        public DataTable GetScheduleOnlyCheckByNextData(DateTime nextDate)//поиск проверок по дате
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCheckByNextData`('{nextDate.ToString("yyyy-MM-dd")}');");
        }
        public DataTable GetScheduleOnlyCheckArchive()//поиск архива проверок
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCheckArchive`();");
        }
        public DataTable GetScheduleOnlyCheckArchiveByInventoryFactory(string inventory_num, string factory_num)//поиск архива проверок по номерам
        {
            return DatabaseAdapter.GetDataTableQuery
                ($"CALL `oborot_si`.`GetScheduleOnlyCheckArchiveByInventoryFactory`('{inventory_num}', '{factory_num}');");
        }

        public InstrumentName GetInstrumentNameById(int id_name)
        {
            return DatabaseAdapter.GetObjectDataByQuery<InstrumentName>
                ($"SELECT `name_instrument`.`id_name_instrument`," +
                $"`name_instrument`.`name_instrument` " +
                $"FROM `oborot_si`.`name_instrument` " +
                $"WHERE `name_instrument`.`id_name_instrument` = {id_name};");
        }

        public Condition GetConditionById(int id_cond)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Condition>
                ($"SELECT `condition`.`id_condition`," +
                $"`condition`.`condition` " +
                $"FROM `oborot_si`.`condition`  " +
                $"WHERE `condition`.`id_condition` = {id_cond};");
        }

        public Department GetBelongToById(int id_belongs)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Department>
                ($"SELECT `department`.`id_department`," +
                $"`department`.`department`" +
                $"FROM `oborot_si`.`department` " +
                $"WHERE `department`.`id_department` = {id_belongs};");
        }


        public List<InstrumentName> GetInstrumentNames()
        {
            return DatabaseAdapter.GetListDataByQuery<InstrumentName>
                ($"SELECT `name_instrument`.`id_name_instrument`," +
                $"`name_instrument`.`name_instrument` " +
                $"FROM `oborot_si`.`name_instrument`;");
        }
        public List<Venue> GetVenue()
        {
            return DatabaseAdapter.GetListDataByQuery<Venue>
                ($"SELECT `venue`.`id_venue`," +
                $"`venue`.`venue` " +
                $"FROM `oborot_si`.`venue`;");
        }

        public List<Condition> GetConditions()
        {
            return DatabaseAdapter.GetListDataByQuery<Condition>
                ($"SELECT `condition`.`id_condition`," +
                $"`condition`.`condition` " +
                $"FROM `oborot_si`.`condition`");
        }

        public List<Department> GetDepartment()
        {
            return DatabaseAdapter.GetListDataByQuery<Department>
                ($"SELECT `department`.`id_department`," +
                $"`department`.`department`" +
                $"FROM `oborot_si`.`department`");
        }

        public List<MeasuringInstrument>GetInstrumentByFactoryInventory(string inventoryNumber, string factoryNumber)
        {
            return DatabaseAdapter.GetListDataByQuery<Models.MeasuringInstrument>
               ($"SELECT `measuring_instrument`.`id_measuring_instrument`," +
                $"`measuring_instrument`.`id_name_instrument`," +
                $"`measuring_instrument`.`type`," +
                $"`measuring_instrument`.`manufacturer`," +
                $"`measuring_instrument`.`measuring_range`," +
                $"`measuring_instrument`.`inventory_number`," +
                $"`measuring_instrument`.`factory_number`," +
                $"`measuring_instrument`.`etalon`," +
                $"`measuring_instrument`.`id_condition`," +
                $"`measuring_instrument`.`equipment`," +
                $"`measuring_instrument`.`description`," +
                $"`measuring_instrument`.`id_department`" +
                $"FROM `oborot_si`.`measuring_instrument`" +
                $"WHERE `measuring_instrument`.`inventory_number` like '%{inventoryNumber}%' " +
                $"AND `measuring_instrument`.`factory_number` like '%{factoryNumber}%' ");
        }

        public bool CreateMeasuringInstrument(Models.MeasuringInstrument instrument)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `measuring_instrument` " +
                $"(`id_name_instrument`, `type`, `manufacturer`, `measuring_range`, `inventory_number`, `factory_number`,`etalon`," +
                $" `id_condition`, `equipment`, `description`, `id_department`)" +
                $" VALUES ('{instrument.InstrumentNameReferenceID}', '{instrument.Type}', '{instrument.Manufacturer}', '{instrument.MeasuringRange}',"+
                $"'{instrument.InventoryNumber}','{instrument.FactoryNumber}', {instrument.Etalon}, '{instrument.ConditionReferenceId}', " +
                $"'{instrument.Equipment}', '{instrument.Description}','{instrument.DepartmentToReferenceID}');");
        }
        public bool CreateSchedule (Models.Schedule schedule)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `oborot_si`.`schedule`(`id_measuring_instrument`,`old_date`,`frequency`," +
                $"`old_venue`,`next_date`,`new_venue`, `id_type_work`)" +
                $" VALUES ({schedule.MeasuringInstrumentReferenceId}, '{schedule.OldWorkDate.ToString("yyyy-MM-dd")}', {schedule.Frequency}, {schedule.OldVenueReferenceID}," +
                $" '{schedule.NextWorkDate.ToString("yyyy-MM-dd")}',{schedule.NewVenueReferenceID}, {schedule.TypeWorkReferenceID});");
        }

        public bool UpdateInstrument(Models.MeasuringInstrument UpdateInstrument)
        {
            if (UpdateInstrument.ID != 0)
            {
                return DatabaseAdapter.ExecuteActionQuery
                    ($"UPDATE `measuring_instrument` SET `id_name_instrument` = {UpdateInstrument.InstrumentNameReferenceID}, `type` = '{UpdateInstrument.Type}', `manufacturer` = " +
                    $"'{UpdateInstrument.Manufacturer}',`measuring_range` = '{UpdateInstrument.MeasuringRange}', `inventory_number` = '{UpdateInstrument.InventoryNumber}', " +
                    $"`factory_number` = '{UpdateInstrument.FactoryNumber}',`etalon` = {UpdateInstrument.Etalon}, `id_condition` = {UpdateInstrument.ConditionReferenceId}, " +
                    $"`equipment` = '{UpdateInstrument.Equipment}', `description` = '{UpdateInstrument.Description}',`id_department` = {UpdateInstrument.DepartmentToReferenceID} " +
                    $"WHERE `measuring_instrument`.`inventory_number` = '{UpdateInstrument.InventoryNumber}' " +
                    $"AND `measuring_instrument`.`factory_number` = '{UpdateInstrument.FactoryNumber}';");
            }
            else
            {
                Console.WriteLine("Невозможно обновить запись с Id 0");
                return false;
            }
        }

        public int GetInventoryFactoryQuery(string inventoryNumber, string factoryNumber)
        {
            return DatabaseAdapter.GetScalarQuery<int>
                ($"SELECT `measuring_instrument`.id_measuring_instrument " +
                $"FROM `oborot_si`.`measuring_instrument` " +
                $"WHERE `measuring_instrument`.`inventory_number` like '%{inventoryNumber}%' " +
                $"AND `measuring_instrument`.`factory_number` like '%{factoryNumber}%' ");
        }
        public int GetOnlyYear()
        {
            return DatabaseAdapter.GetScalarQuery<int>
                ($"Select Year(`schedule`.`old_date`) " +
                $"From `schedule` " +
                $"Where `schedule`.`id_schedule` = " +
                $"(Select Max(`schedule`.`id_schedule`) " +
                $"from `schedule`);");
        }
        public int GetLastScheduleID()
        {
            return DatabaseAdapter.GetScalarQuery<int>
                ($"Select `schedule`.`id_schedule`  " +
                $"From `schedule` " +
                $"Where `schedule`.`id_schedule` = " +
                $"(Select Max(`schedule`.`id_schedule`) " +
                $"from `schedule`)");
        }
        public int GetLastJournalNum()
        {
            return DatabaseAdapter.GetScalarQuery<int>
                ($"Select `journal`.`num_journal`  " +
                $"From `journal`" +
                $" Where `journal`.`num_journal` = " +
                $"(Select Max(`journal`.`num_journal`) " +
                $"from `journal`)");
        }
        public int GetLastJournalID()
        {
            return DatabaseAdapter.GetScalarQuery<int>
                ($"Select `journal`.`id_journal`  " +
                $"From `journal`" +
                $" Where `journal`.`id_journal` = " +
                $"(Select Max(`journal`.`id_journal`) " +
                $"from `journal`)");
        }
        public int GetLastNumJournalQuery()
        {
            return DatabaseAdapter.GetScalarQuery<int>
            ($"SELECT `journal`.`num_journal` " +
            $"FROM `journal` " +
            $"ORDER BY `id_journal` DESC LIMIT 1");
        }
        public int GetLastNumProtocolQuery()
        {
            return DatabaseAdapter.GetScalarQuery<int>
            ($"SELECT `protocol`.`num_protocol` " +
            $"FROM `protocol` " +
            $"ORDER BY `id_protocol` DESC LIMIT 1");
        }
        public TypeWork GetTypeWorkByNum(int num_protocol)
        {
            return DatabaseAdapter.GetObjectDataByQuery<TypeWork>
                ($"    Select `type_of_work`.`type_of_work` From `type_of_work` " +
                $"Join `schedule` On `schedule`.`id_type_work` = `type_of_work`.`id_type_work `" +
                $"Join `journal` On `journal`.`schedule_reference` = `schedule`.`id_schedule`" +
                $"Join `protocol` On `protocol`.`id_journal` = `journal`.`id_journal`" +
                $"Where `protocol`.`num_protocol` =  {num_protocol};");
        }

        public Conclusion GetConclusionById(int id_conclusion)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Conclusion>
                ($"SELECT `conclusion`.`id_conclusion`," +
                $"`conclusion`.`conclusion` " +
                $"FROM `oborot_si`.`conclusion` " +
                $"WHERE `conclusion`.`id_conclusion` = {id_conclusion};");
        }
        public List<TypeWork> GetTypeWork()
        {
            return DatabaseAdapter.GetListDataByQuery<TypeWork>
                ($"SELECT `type_of_work`.`id_type_work`, " +
                $"`type_of_work`.`type_of_work` " +
                $"FROM `oborot_si`.`type_of_work`");
        }

        public List<Conclusion> GetConclusion()
        {
            return DatabaseAdapter.GetListDataByQuery<Conclusion>
                ($"SELECT `conclusion`.`id_conclusion`," +
                $"`conclusion`.`conclusion` " +
                $"FROM `oborot_si`.`conclusion`");
        }

        public bool CreateJournal(Models.Journal journal)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `oborot_si`.`journal`" +
                $"(num_journal,schedule_reference,id_conclusion,year) " +
                $"VALUES ({journal.NumJournal},{journal.ScheduleReferenceId}, {journal.ConclusionReferenceId},{journal.Year});");
        }

        public List<Models.EmployeeData> GetEmployeeDataList()
        {
            return DatabaseAdapter.GetListDataByQuery<Models.EmployeeData>
                ($"SELECT `employee_data`.`id_employee_data`," +
                $"`employee_data`.`id_employee`," +
                $"`employee_data`.`login`," +
                $"`employee_data`.`salt`," +
                $"`employee_data`.`password_hash`," +
                $"`employee_data`.`id_role`," +
                $"`employee_data`.`is_active` " +
                $"FROM `oborot_si`.`employee_data`;");
        }

        public Role GetRoleById(int id_role)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Role>
                ($"SELECT `role`.`id_role`," +
                $"FROM `oborot_si`.`condition`  " +
                $"WHERE `role`.`id_role` = {id_role};");
        }
        public Employee GetEmployeeByID(int id_employee)//
        {
            return DatabaseAdapter.GetObjectDataByQuery<Employee>
                ($"SELECT `employee`.`surname`" +
                $"`employee`.`name` " +
                $"`employee`.`patronymic` " +
                $"FROM `oborot_si`.`employee` " +
                $"WHERE `employee`.`id_employee` = {id_employee};");
        }
        public Employee GetEmployeeAbbreviationByID(int id_employee)//
        {
            return DatabaseAdapter.GetObjectDataByQuery<Employee>
                ($"SELECT CONCAT (`employee`.`surname`,' '," +
                $"(SELECT LEFT(`employee`.`name`,1)),'.'," +
                $"(SELECT LEFT(`employee`.`patronymic`,1)),'.') " +
                $"FROM `employee` where `employee`.`id_employee`{id_employee};");
        }
        public List<Models.Employee> GetEmployee()
        {
            return DatabaseAdapter.GetListDataByQuery < Models.Employee >
                ($"SELECT `employee`.`id_employee`," +
                $"`employee`.`surname`," +
                $"`employee`.`name`, " +
                $"`employee`.`patronymic` " +
                $"FROM `oborot_si`.`employee`;");
        }
        public Role GetEmployeeDataByLoginPassword(int id_role)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Role>
                ($"SELECT `role`.`id_role`," +
                $"FROM `oborot_si`.`role`  " +
                $"WHERE `role`.`id_role` = {id_role};");
        }
        public List<Role> GetRole()
        {
            return DatabaseAdapter.GetListDataByQuery<Role>
                ($"SELECT `role`.`id_role`,`role`.`role`" +
                $"FROM `oborot_si`.`role`;");
        }

        public EmployeeData GetDateCertificationDifference(string login, string password)
        {
            return DatabaseAdapter.GetObjectDataByQuery<EmployeeData>
                ($"SELECT(YEAR(CURDATE()) - (SELECT YEAR(`employee_data`.`date_of_certification`) " +
                $"FROM `employee_data` " +
                $"WHERE `employee_data`.`login`= {login} and `employee_data`.`password_hash`= {password}))");
        }

        public bool CreateProtocol(Models.Protocol protocol)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `oborot_si`.`protocol`(`num_protocol`,`id_journal`,`note`,`id_employee`)" +
                 $"VALUES({protocol.NumProtocol},{protocol.JournalReferenceId}, '{protocol.Note}', {protocol.EmployeeReferenceID});");
        }

        public int GetEmployeeConcatQuery(int id)
        {
            return DatabaseAdapter.GetScalarQuery<int>
                ($"SELECT `employee`.`id_employee` " +
                $"FROM `oborot_si`.`employee` " +
                $"WHERE CONCAT(`employee`.`surname`,' ', `employee`.`name`, ' ', `employee`.`patronymic) = {id}`");
        }

        public bool GetEtalon(string inventoryNumber, string factoryNumber)
        {
            return DatabaseAdapter.GetScalarQuery<bool>
                ($"SELECT `measuring_instrument`.`etalon`, " +
                $"FROM `oborot_si`.`measuring_instrument` " +
                $"WHERE `measuring_instrument`.`inventory_number` = '{inventoryNumber}' " +
                $"AND `measuring_instrument`.`factory_number` = '{factoryNumber}'");
        }

        public bool CheckUserActivity(string login)
        {
            return DatabaseAdapter.GetScalarQuery<bool>($"SELECT `oborot_si`.`CheckIfUserIsActive`('{login}')");
        }

        public bool CheckUserCredentials(string login, string password)
        {
            return DatabaseAdapter.GetScalarQuery<bool>($"SELECT `oborot_si`.`CheckUserPassword`('{login}', '{password}')");
        }
    }
}
