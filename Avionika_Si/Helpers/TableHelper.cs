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
                    int id = DGV.BaseDGV.Rows.Add(row["name_instrument"], row["type"], row["factory_number"], 
                        row["inventory_number"], row["department"], DB.DataConverter.Convert<DateTime>(row["old_date"]).ToString("dd.MM.yyyy"),
                        row["frequency"], row["old_ven"], DB.DataConverter.Convert<DateTime>(row["next_date"]).ToString("dd.MM.yyyy"), row["new_ven"]);
                    DGV.BaseDGV.Rows[id].Tag = row["id_schedule"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        public static void FillScheduleCalibrationCheckTable(DataTable scheduleDataTable, DataGridView scheduleDGV)
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

                foreach (DataRow row in scheduleDataTable.Rows)
                {
                    int id = DGV.BaseDGV.Rows.Add(row["name_instrument"], row["type"], row["factory_number"],
                        row["inventory_number"], row["department"], DB.DataConverter.Convert<DateTime>(row["old_date"]).ToString("dd.MM.yyyy"),
                        row["frequency"], DB.DataConverter.Convert<DateTime>(row["next_date"]).ToString("dd.MM.yyyy"), row["type_of_work"]);
                    DGV.BaseDGV.Rows[id].Tag = row["id_schedule"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        public static void FillJournalTable(DataTable journalDataTable, DataGridView journalDGV)
        {
            //scheduleDGV.AutoGenerateColumns = false;
            //scheduleDGV.DataSource = scheduleDataTable;


            DGVExtension DGV = new DGVExtension(journalDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);

                foreach (DataRow row in journalDataTable.Rows)
                {
                    int id = DGV.BaseDGV.Rows.Add(row["num_journal"], row["name_instrument"], row["type"], row["inventory_number"],
                        row["factory_number"],row["conclusion"],row["type_of_work"]);
                    DGV.BaseDGV.Rows[id].Tag = row["id_journal"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        public static void FillProtocolTable(DataTable protocolDataTable, DataGridView protocolDGV)
        {
            //scheduleDGV.AutoGenerateColumns = false;
            //scheduleDGV.DataSource = scheduleDataTable;


            DGVExtension DGV = new DGVExtension(protocolDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);

                foreach (DataRow row in protocolDataTable.Rows)
                {
                    int id = DGV.BaseDGV.Rows.Add(row["num_protocol"], row["name_instrument"], row["type"], row["inventory_number"],
                        row["factory_number"], row["type_of_work"], row["note"], row["conclusion"], row["employee_name"]);
                    DGV.BaseDGV.Rows[id].Tag = row["id_protocol"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        public static void FillCertificateTable(DataTable certificateDataTable, DataGridView certificateDGV)
        {
            //scheduleDGV.AutoGenerateColumns = false;
            //scheduleDGV.DataSource = scheduleDataTable;


            DGVExtension DGV = new DGVExtension(certificateDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);

                foreach (DataRow row in certificateDataTable.Rows)
                {
                    int id = DGV.BaseDGV.Rows.Add(row["num_protocol"], row["name_instrument"], row["factory_number"], row["inventory_number"],
                        row["department"], DB.DataConverter.Convert<DateTime>(row["old_date"]).ToString("dd.MM.yyyy"), DB.DataConverter.Convert<DateTime>(row["next_date"]).ToString("dd.MM.yyyy"), row["employee_name"]);
                    DGV.BaseDGV.Rows[id].Tag = row["id_protocol"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }

        /*public static void FillCertificateTable(DataTable certificateDataTable, DataGridView certificateDGV)
        {

            
            DGVExtension DGV = new DGVExtension(certificateDGV);
            DGV.InitCopyCellContextMenu();
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);

                //BindingSource bs = new BindingSource();
               // bs.DataSource = certificateDataTable;
                certificateDGV.DataSource = certificateDataTable;
                certificateDGV. = certificateDataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }*/
    }
}
