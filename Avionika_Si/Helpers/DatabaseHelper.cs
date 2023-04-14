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
                $"`measuring_instrument`.`id_belong_to`" +
                $"FROM `oborot_si`.`measuring_instrument`;");
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

        public BelongTo GetBelongToById(int id_belongs)
        {
            return DatabaseAdapter.GetObjectDataByQuery<BelongTo>
                ($"SELECT `belong_to`.`id_belong_to`," +
                $"`belong_to`.`belong_to`" +
                $"FROM `oborot_si`.`belong_to` " +
                $"WHERE `belong_to`.`id_belong_to` = {id_belongs};");
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

        public List<BelongTo> GetBelongTo()
        {
            return DatabaseAdapter.GetListDataByQuery<BelongTo>
                ($"SELECT `belong_to`.`id_belong_to`," +
                $"`belong_to`.`belong_to`" +
                $"FROM `oborot_si`.`belong_to`");
        }

        public Models.MeasuringInstrument GetInstrumentById(int id)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Models.MeasuringInstrument>
            ($"SELECT " +
                    $"`measuring_instrument`.`id_measuring_instrument`, " +
                    $"`name_instrument`.`name_instrument`, " +
                    $"`measuring_instrument`.`type` " +
                    $"`measuring_instrument`.`manufacturer` " +
                    $"`measuring_instrument`.`measuring_range` " +
                    $"`measuring_instrument`.`inventory_number` " +
                    $"`measuring_instrument`.`factory_number` " +
                    $"`measuring_instrument`.`etalon` " +
                    $"`measuring_instrument`.`id_condition` " +
                    $"`measuring_instrument`.`equipment` " +
                    $"`measuring_instrument`.`description` " +
                    $"`measuring_instrument`.`id_belong_to` " +
                    $"FROM `measuring_instrument` JOIN `name_instrument` ON `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` " +
                $"WHERE `measuring_instrument`.`id_measuring_instrument` = {id};");
        }

        public bool CreateMeasuringInstrument(Models.MeasuringInstrument instrument)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `measuring_instrument` " +
                $"(`id_name_instrument`, `type`, `manufacturer`, `measuring_range`, `inventory_number`, `factory_number`,`etalon`," +
                $" `id_condition`, `equipment`, `description`, `id_belong_to`)" +
                $" VALUES ('{instrument.InstrumentNameReferenceID}', '{instrument.Type}', '{instrument.Manufacturer}', '{instrument.MeasuringRange}', '{instrument.InventoryNumber}'," +
                $" '{instrument.FactoryNumber}', {instrument.Etalon}, '{instrument.ConditionReferenceId}', '{instrument.Equipment}', '{instrument.Description}', " +
                $"'{instrument.BelongsToReferenceID}');");
        }



        public bool UpdateInstrument(Models.MeasuringInstrument MeasureInstrument)
        {
            if (MeasureInstrument.ID != 0)
            {
                return DatabaseAdapter.ExecuteActionQuery
                    ($"UPDATE `measuring_instrument` SET `id_name_instrument` = '{MeasureInstrument.ID}', `type` = '{MeasureInstrument.Type}', `manufacturer` = " +
                    $"'{MeasureInstrument.Manufacturer}',`measuring_range` = '{MeasureInstrument.MeasuringRange}', `inventory_number` = '{MeasureInstrument.InventoryNumber}', " +
                    $"`factory_number` = '{MeasureInstrument.FactoryNumber}',`etalon` = '{MeasureInstrument.Etalon}', `id_condition` = '{MeasureInstrument.ID}', " +
                    $"`equipment` = '{MeasureInstrument.Equipment}', `description` = '{MeasureInstrument.Description}',`id_belong_to` = '{MeasureInstrument.ID}' " +
                    $"WHERE `measuring_instrument`.`inventory_number` = {MeasureInstrument.InventoryNumber} " +
                    $"AND `measuring_instrument`.`factory_number` = {MeasureInstrument.FactoryNumber};");
            }
            else
            {
                Console.WriteLine("Невозможно обновить запись с Id 0");
                return false;
            }
        }

        public Models.MeasuringInstrument GetInventoryFactoryQuery(string inventory_number, string factory_number)
        {
                return DatabaseAdapter.GetObjectDataByQuery<Models.MeasuringInstrument>
                ($"SELECT `measuring_instrument`.`id_measuring_instrument` " +
                $"FROM `oborot_si`.`measuring_instrument` " +
                $"WHERE `measuring_instrument`.`inventory_number` = {inventory_number} " +
                $"AND `measuring_instrument`.`factory_number` = {factory_number} ");
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

        // Имеет смысл оставить ID как просто суррогатный ключ. А для внутреннего обнуляемого номера журнала ввести отдельное поле.
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
                $"(`date`,`id_measuring_instrument`,`id_conclusion`,`id_type_work`) " +
                $"VALUES ('{journal.Date}', '{journal.MeasuringInstrumentReferenceId}', '{journal.ConclusionReferenceId}', '{journal.TypeWorkReferenceID}'");
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
        public Employee GetEmployeeById(int id_employee)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Employee>
                ($"SELECT `name_instrument`.`id_name_instrument`," +
                $"`name_instrument`.`name_instrument` " +
                $"FROM `oborot_si`.`name_instrument` " +
                $"WHERE `name_instrument`.`id_name_instrument` = {id_employee};");
        }
        public Role GetRoleById(int id_role)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Role>
                ($"SELECT `role`.`id_role`," +
                $"FROM `oborot_si`.`condition`  " +
                $"WHERE `role`.`id_role` = {id_role};");
        }
        public Employee GetEmployeeByID(int id_employee)
        {
            return DatabaseAdapter.GetObjectDataByQuery<Employee>
                ($"SELECT `employee`.`id_employee`" +
                $"FROM `oborot_si`.`employee` " +
                $"WHERE `employee`.`id_employee` = {id_employee};");
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
                ($"INSERT INTO `oborot_si`.`protocol`(`id_measuring_instrument`,`description`,`id_employee`)" +
                 $"VALUES('{protocol.InstrumentNameReferenceID}', '{protocol.Description}', '{protocol.EmployeeReferenceID}';");
        }

    }
}
