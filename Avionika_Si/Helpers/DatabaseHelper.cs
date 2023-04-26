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

        public List<Models.Schedule> GetScheduleList()
        {
            return DatabaseAdapter.GetListDataByQuery<Models.Schedule>
                ($"SELECT `schedule`.`id_schedule`," +
                $"`name_instrument`.`name_instrument`," +
                $"`measuring_instrument`.`type`," +
                $"`measuring_instrument`.`inventory_number`," +
                $"`measuring_instrument`.`factory_number`," +
                $"`schedule`.`frequency`," +
                $"`journal`.`date`," +
                $"`schedule`.`old_venue`," +
                $"`schedule`.`next_date`," +
                $"`schedule`.`new_venue`," +
                $"`conclusion`.`conclusion`," +
                $"`type_of_work`.`type_of_work`" +
                $"FROM `oborot_si`.`measuring_instrument` " +
                $"JOIN `oborot_si`.`name_instrument` " +
                $"ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument`" +
                $"JOIN `oborot_si`.`schedule`" +
                $"ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument`" +
                $"JOIN `oborot_si`.`journal`" +
                $"ON `measuring_instrument`.`id_measuring_instrument` = `journal`.`id_measuring_instrument`" +
                $"JOIN `oborot_si`.`conclusion`" +
                $"ON `journal`.`id_conclusion` = `conclusion`.`id_conclusion`" +
                $"JOIN  `oborot_si`.`type_of_work`" +
                $"ON `journal`.`id_type_work` = `type_of_work`.`id_type_work`" +
                $"WHERE `schedule`.`next_date`>= '"+DateTime.Now+"' ORDER BY `schedule`.`next_date`;");
        }

        public List<Models.Passport> GetPassportList(string inventoryNumber, string factoryNumber)
        {
            return DatabaseAdapter.GetListDataByQuery<Models.Passport>
                ($"SELECT `name_instrument`.`name_instrument`," +
                $"`measuring_instrument`.`type`," +
                $"`measuring_instrument`.`manufacturer`," +
                $"`measuring_instrument`.`inventory_number`," +
                $"`measuring_instrument`.`factory_number`," +
                $"`department`.`department`," +
                $"`journal`.`date`," +
                $"`conclusion`.`conclusion`," +
                $"`type_of_work`.`type_of_work`" +
                $"FROM `oborot_si`.`measuring_instrument` " +
                $"JOIN `oborot_si`.`name_instrument` " +
                $"ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument`" +
                $"JOIN `oborot_si`.`department`" +
                $"ON `measuring_instrument`.`id_department` = `department`.`id_department`" +
                $"JOIN `oborot_si`.`journal`" +
                $"ON `measuring_instrument`.`id_measuring_instrument` = `journal`.`id_measuring_instrument`" +
                $"JOIN `oborot_si`.`conclusion`" +
                $"ON `journal`.`id_conclusion` = `conclusion`.`id_conclusion`" +
                $"JOIN  `oborot_si`.`type_of_work`" +
                $"ON `journal`.`id_type_work` = `type_of_work`.`id_type_work`" +
                $"WHERE `measuring_instrument`.`inventory_number` like '%{inventoryNumber}%' " +
                $"AND `measuring_instrument`.`factory_number` like '%{factoryNumber}%' ");
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

        public List<Condition> GetCondition()
        {
            return DatabaseAdapter.GetListDataByQuery<Condition>
                ($"SELECT `condition`.`id_condition`," +
                $"`condition`.`condition` " +
                $"FROM `oborot_si`.`condition`");
        }

        public List<Department> GetBelongTo()
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

        public string GetDateWorkByFactoryInventory(string inventoryNumber, string factoryNumber)
        {
            return DatabaseAdapter.GetScalarQuery<string>
               ($"SELECT `journal`.`date`" +
                $"FROM `oborot_si`.`journal`" +
                $"JOIN `measuring_instrument`" +
                $"ON `journal`.id_measuring_instrument=`measuring_instrument`.id_measuring_instrument" +
                $"WHERE `measuring_instrument`.`inventory_number` = '{inventoryNumber}' " +
                $"AND `measuring_instrument`.`factory_number` = '{factoryNumber}' " +
                $"ORDER BY `journal`.`date` DESC LIMIT 1 ");
        }
        public bool CreateMeasuringInstrument(Models.MeasuringInstrument instrument)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `measuring_instrument` " +
                $"(`id_name_instrument`, `type`, `manufacturer`, `measuring_range`, `inventory_number`, `factory_number`,`etalon`," +
                $" `id_condition`, `equipment`, `description`, `id_department`)" +
                $" VALUES ('{instrument.InstrumentNameReferenceID}', '{instrument.Type}', '{instrument.Manufacturer}', '{instrument.MeasuringRange}', '{instrument.InventoryNumber}'," +
                $" '{instrument.FactoryNumber}', {instrument.Etalon}, '{instrument.ConditionReferenceId}', '{instrument.Equipment}', '{instrument.Description}', " +
                $"'{instrument.DepartmentsToReferenceID}');");
        }



        public bool UpdateInstrument(Models.MeasuringInstrument UpdateInstrument)
        {
            if (UpdateInstrument.ID != 0)
            {
                return DatabaseAdapter.ExecuteActionQuery
                    ($"UPDATE `measuring_instrument` SET `id_name_instrument` = {UpdateInstrument.InstrumentNameReferenceID}, `type` = '{UpdateInstrument.Type}', `manufacturer` = " +
                    $"'{UpdateInstrument.Manufacturer}',`measuring_range` = '{UpdateInstrument.MeasuringRange}', `inventory_number` = '{UpdateInstrument.InventoryNumber}', " +
                    $"`factory_number` = '{UpdateInstrument.FactoryNumber}',`etalon` = {UpdateInstrument.Etalon}, `id_condition` = {UpdateInstrument.ConditionReferenceId}, " +
                    $"`equipment` = '{UpdateInstrument.Equipment}', `description` = '{UpdateInstrument.Description}',`id_department` = {UpdateInstrument.DepartmentsToReferenceID} " +
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

        public List<Models.Journal> GetJournalList()
        {
            return DatabaseAdapter.GetListDataByQuery<Models.Journal>
                ($"SELECT `journal`.`id_journal`," +
                $"`journal`.`date`," +
                $"`journal`.`id_measuring_instrument`," +
                $"`journal`.`id_conclusion`," +
                $"`journal`.`id_type_work " +
                $"FROM `oborot_si`.`journal`; ");
        }

        public int GetLastIdJournalQuery()
        {
            return DatabaseAdapter.GetScalarQuery<int>
            ($"SELECT `journal`.`id_journal` " +
            $"FROM `journal` " +
            $"ORDER BY `id_journal` DESC LIMIT 1");
        }

        public TypeWork GetTypeWorkById(int id_type_work)
        {
            return DatabaseAdapter.GetObjectDataByQuery<TypeWork>
                ($"SELECT `type_of_work`.`id_type_work`, " +
                $"`type_of_work`.`type_of_work` " +
                $"FROM `oborot_si`.`type_of_work` " +
                $"WHERE `type_of_work`.`id_type_work` = {id_type_work};");
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
                $"( num_journal,`date`,id_measuring_instrument,id_conclusion,id_type_work) " +
                $"VALUES ({journal.NumJournal},(DATE_FORMAT('{journal.DateWork}', '%Y-%m-%d')), {journal.MeasuringInstrumentReferenceId}, {journal.ConclusionReferenceId}, {journal.TypeWorkReferenceID});");
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
                $"FROM `oborot_si`.`condition`  " +
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
                ($"INSERT INTO `oborot_si`.`protocol`(`num_protocol`,`id_measuring_instrument`,`note`,`id_employee`)" +
                 $"VALUES({protocol.NumProtocol},{protocol.InstrumentNameReferenceID}, '{protocol.Note}', {protocol.EmployeeReferenceID});");
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
    }
}
