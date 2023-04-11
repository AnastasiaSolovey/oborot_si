using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseAdapter;
using System.Threading.Tasks;


namespace Avionika_Si.Models
{

    internal class measuring_instrument
    {
        private string connectionString = "server=avitube;login=OborotSiAdmin;password=siOborotPassword2023;charset=utf8;persistsecurityinfo=True;database=oborot_si;allowuservariables=True";
        private IDatabaseAdapter DatabaseAdapter;

        public measuring_instrument()
        {
            DatabaseAdapter = new MySqlAdapter(connectionString);
        }

        public int id_measuring_instrument { get; set; }
        public int id_name_instrument { get; set; }
        public string type { get; set; }
        public string manufacturer { get; set; }
        public string measuring_range { get; set; }
        public string inventory_number { get; set; }
        public string factory_number { get; set; }
        public int etalon { get; set; }
        public int id_condition { get; set; }
        public string equipment { get; set; }
        public string description { get; set; }
        public string id_belong_to { get; set; }

        public List<measuring_instrument> GetExampleClassesList()
        {
            return DatabaseAdapter.GetListDataByQuery<measuring_instrument>
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
                $"FROM `employee` JOIN name_instrument ON name_instrument.id_name_instrument = measuring_instrument.id_name_instrument;");
        }

        public measuring_instrument GetExampleClassById(int id)
        {
            return DatabaseAdapter.GetObjectDataByQuery<measuring_instrument>
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
                    $"FROM `employee` JOIN `name_instrument` ON `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` " +
                $"WHERE `employee`.`id_measuring_instrument` = {id};");
        }

        public bool CreateExampleClass(measuring_instrument exampleClass)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `measuring_instrument` (`id_name_instrument`, `type`, `manufacturer`, `measuring_range`, `inventory_number`, `factory_number`,`etalon`, `id_condition`, `equipment`, `description`, `id_belong_to`) VALUES ('{exampleClass.id_name_instrument}', '{exampleClass.type}', '{exampleClass.manufacturer}', '{exampleClass.measuring_range}', '{exampleClass.inventory_number}', '{exampleClass.factory_number}', '{exampleClass.etalon}', '{exampleClass.id_condition}', '{exampleClass.equipment}', '{exampleClass.description}', '{exampleClass.id_belong_to}');");
        }

        public bool UpdateExampleClass(measuring_instrument exampleClass)
        {
            if (exampleClass.id_measuring_instrument != 0)
            {
                return DatabaseAdapter.ExecuteActionQuery
                    ($"UPDATE `measuring_instrument` SET `id_name_instrument` = '{exampleClass.id_name_instrument}', `type` = '{exampleClass.type}', `manufacturer` = '{exampleClass.manufacturer}', `measuring_range` = '{exampleClass.measuring_range}', `inventory_number` = '{exampleClass.inventory_number}', `factory_number` = '{exampleClass.factory_number}', `etalon` = '{exampleClass.etalon}', `id_condition` = '{exampleClass.id_condition}', `equipment` = '{exampleClass.equipment}', `description` = '{exampleClass.description}', `id_belong_to` = '{exampleClass.id_belong_to}' WHERE `measuring_instrument`.`id_measuring_instrument` = {exampleClass.id_measuring_instrument};");
            }
            else
            {
                Console.WriteLine("Невозможно обновить запись с Id 0");
                return false;
            }
        }
        public measuring_instrument(string login, DateTime date, DateTime startTime, DateTime endTime, string comment, int ownerProblemID, bool lunchBreakFlag)
        {
          
        }


    }
}
