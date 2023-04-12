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
        private string connectionString = "server=avitube;user id=OborotSiAdmin;password=siOborotPassword2023;charset=utf8;persistsecurityinfo=True;database=oborot_si;allowuservariables=True";
        private IDatabaseAdapter DatabaseAdapter;

        public DatabaseHelper()
        {
            DatabaseAdapter = new MySqlAdapter(connectionString);
        }

        public List<MeasuringInstrument> GetMeasuringInstrumentsList()
        {
            return DatabaseAdapter.GetListDataByQuery<MeasuringInstrument>
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

        public InstrumentName GetInstrumentNameById(int id)
        {
            return DatabaseAdapter.GetObjectDataByQuery<InstrumentName>
                ($"SELECT `name_instrument`.`id_name_instrument`," +
                $"`name_instrument`.`name_instrument` " +
                $"FROM `oborot_si`.`name_instrument` " +
                $"WHERE `name_instrument`.`id_name_instrument` = {id}; ");
        }

        public List<InstrumentName> GetInstrumentNames()
        {
            return DatabaseAdapter.GetListDataByQuery<InstrumentName>
                ($"SELECT `name_instrument`.`id_name_instrument`," +
                $"`name_instrument`.`name_instrument` " +
                $"FROM `oborot_si`.`name_instrument`;");
        }

        public MeasuringInstrument GetExampleClassById(int id)
        {
            return DatabaseAdapter.GetObjectDataByQuery<MeasuringInstrument>
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

        public bool CreateMeasuringInstrument(MeasuringInstrument instrument)
        {
            return DatabaseAdapter.ExecuteActionQuery
                ($"INSERT INTO `measuring_instrument` " +
                $"(`id_name_instrument`, `type`, `manufacturer`, `measuring_range`, `inventory_number`, `factory_number`,`etalon`," +
                $" `id_condition`, `equipment`, `description`, `id_belong_to`)" +
                $" VALUES ('{instrument.InstrumentNameReferenceID}', '{instrument.Type}', '{instrument.Manufacturer}', '{instrument.MeasuringRange}', '{instrument.InventoryNumber}'," +
                $" '{instrument.FactoryNumber}', {instrument.Etalon}, '{instrument.ConditionReferenceId}', '{instrument.Equipment}', '{instrument.Description}', '{instrument.BelongsToReferenceID}');");
        }

        public bool UpdateExampleClass(MeasuringInstrument exampleClass)
        {
            if (exampleClass.ID != 0)
            {
                return DatabaseAdapter.ExecuteActionQuery
                    ($"UPDATE `measuring_instrument` SET `id_name_instrument` = '{exampleClass.ID}', `type` = '{exampleClass.Type}', `manufacturer` = '{exampleClass.Manufacturer}'," +
                    $" `measuring_range` = '{exampleClass.MeasuringRange}', `inventory_number` = '{exampleClass.InventoryNumber}', `factory_number` = '{exampleClass.FactoryNumber}'," +
                    $" `etalon` = '{exampleClass.Etalon}', `id_condition` = '{exampleClass.ConditionReferenceId}', `equipment` = '{exampleClass.Equipment}', `description` = '{exampleClass.Description}'," +
                    $" `id_belong_to` = '{exampleClass.BelongsToReferenceID}' WHERE `measuring_instrument`.`id_measuring_instrument` = {exampleClass.ID};");
            }
            else
            {
                Console.WriteLine("Невозможно обновить запись с Id 0");
                return false;
            }
        }

    }
}
