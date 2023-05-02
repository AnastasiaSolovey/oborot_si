using Oborot_SI.Extensions;
using Avionika_Si.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avionika_Si;
using System.Data;
using DB = DatabaseAdapter;

namespace DFLS.Adapters
{
    class TableHelper
    {
        // МЕТОД-ПРИМЕР! Если нинада - можно удалить.

        /*
        public static void FillProblemReConfirmationTable(Problem problem, DataGridView ConfirmationsDataGridView)
        {
            DGVExtension DGV = new DGVExtension(ConfirmationsDataGridView);
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);
                for (int i = 0; i < problem.AttachedUsers.Count; i++)
                {
                    int confIndex = problem.Confirmations.FindIndex(conf => conf.UserLogin == problem.AttachedUsers[i].Login && !problem.AttachedUsers[i].NeedToDelete);
                    if (confIndex!=-1)
                    {
                        int id = DGV.BaseDGV.Rows.Add(problem.AttachedUsers[i].Name, Program.ProblemRoleIdValuePairs[problem.AttachedUsers[i].Role.RoleID], false);
                        DGV.BaseDGV.Rows[id].Tag = confIndex;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }
        */

        public static void FillMeasuringInstrumentsTable(List<MeasuringInstrument> instruments, DataGridView measuringInstrumentsDGV)
        {
            DGVExtension DGV = new DGVExtension(measuringInstrumentsDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);
                for (int i = 0; i < instruments.Count; i++)
                {
                    int id = DGV.BaseDGV.Rows.Add(instruments[i].InstName.Name, instruments[i].Type, instruments[i].Manufacturer, instruments[i].MeasuringRange,
                        instruments[i].InventoryNumber, instruments[i].FactoryNumber, instruments[i].Etalon, instruments[i].Cond?.ConditionName, instruments[i].Equipment,
                        instruments[i].Description, instruments[i].Department?.DepartmentName);
                    DGV.BaseDGV.Rows[id].Tag = instruments[i].ID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        /*public static void FillScheduleTable(List<Schedule> schedule, DataGridView scheduleDGV)
        {
            DGVExtension DGV = new DGVExtension(scheduleDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);
                for (int i = 0; i < schedule.Count; i++)
                {
                    int id = DGV.BaseDGV.Rows.Add(schedule[i].InstName.Name, schedule[i].TypeInstr.Type, schedule[i].Inventory.InventoryNumber, schedule[i].Factory.FactoryNumber,
                        schedule[i].Frequency, schedule[i].WorkDate, schedule[i].OldVenue?.VenueName, schedule[i].NextDate, schedule[i].NewVenue?.VenueName,
                        schedule[i].Conclus.ConclusionName, schedule[i].Type?.Type); 
                    DGV.BaseDGV.Rows[id].Tag = schedule[i].ID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }*/

        public static void FillScheduleTable(DataTable scheduleDataTable, DataGridView scheduleDGV)
        {
            //scheduleDGV.AutoGenerateColumns = false;
            //scheduleDGV.DataSource = scheduleDataTable;


            DGVExtension DGV = new DGVExtension(scheduleDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);

                foreach(DataRow row in scheduleDataTable.Rows)
                {
                    int id = DGV.BaseDGV.Rows.Add(row["name_instrument"], row["type"], row["inventory_number"], row["factory_number"], row["frequency"], DB.DataConverter.Convert<DateTime>(row["old_date"]).ToString("dd.MM.yyyy"),
                        row["old_ven"], DB.DataConverter.Convert<DateTime>(row["next_date"]).ToString("dd.MM.yyyy"), row["new_ven"], row["conclusion"], row["type_of_work"]);
                    DGV.BaseDGV.Rows[id].Tag = row["id_schedule"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        public static void FillJournalTable(List<Passport> passport, DataGridView passportDGV)
        {
           /* DGVExtension DGV = new DGVExtension(passportDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);
                for (int i = 0; i < passport.Count; i++)
                {
                    int id = DGV.BaseDGV.Rows.Add(passport[i].InstName.Name, passport[i].Type.Type, passport[i].Manufacturer.Manufacturer, passport[i].Inventory.InventoryNumber,
                        passport[i].Factory.FactoryNumber, passport[i].Department?.Departments, passport[i].DateWork.DateWork, passport[i].Conclusion.ConclusionName,
                        passport[i].TypeWork?.Type);
                        DGV.BaseDGV.Rows[id].Tag = passport[i].ID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();*/
        }
    }
}
