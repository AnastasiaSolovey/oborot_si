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
            DGV.SuspendLayout();
            try
            {
                DGV.BaseDGV.Rows.Clear();
                DGV.BaseDGV.Columns[0].ValueType = typeof(string);
                for (int i = 0; i < instruments.Count; i++)
                {
                    int id = DGV.BaseDGV.Rows.Add(instruments[i].InstName.Name, instruments[i].Type, instruments[i].Manufacturer, instruments[i].MeasuringRange,
                        instruments[i].InventoryNumber, instruments[i].FactoryNumber, instruments[i].Etalon, instruments[i].Cond?.ConditionName, instruments[i].Equipment,
                        instruments[i].Description, instruments[i].Belongs?.Belongs);
                    DGV.BaseDGV.Rows[id].Tag = instruments[i].ID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сформировать таблицу согласований. {ex.Message}");
            }
            DGV.ResumeLayout();
        }
    }
}
