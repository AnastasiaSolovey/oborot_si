using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oborot_SI.Extensions
{
    public class DGVExtension
    {
        public DataGridView BaseDGV { get; set; }
        public int SelectedRowIndex { get; set; }
        public int ScrollIndex { get; set; }
        private DataGridViewColumn SortedByColumn { get; set; }
        private ListSortDirection Direction { get; set; }


        public DGVExtension(DataGridView DGV)
        {
            BaseDGV = DGV;
        }

        public void SuspendLayout()
        {
            SelectedRowIndex = GetSelectedIndex(BaseDGV);
            ScrollIndex = GetDGVCurrentScrollIndex(BaseDGV);

            try
            {
                SortedByColumn = BaseDGV.SortedColumn;
                if(SortedByColumn!=null)
                {
                    if (BaseDGV.SortOrder == SortOrder.Descending)
                    {
                        Direction = ListSortDirection.Descending;
                    }
                    else
                    {
                        // Sort a new column and remove the old SortGlyph.
                        Direction = ListSortDirection.Ascending;
                    }
                }
            }
            catch
            {

            }

            BaseDGV.SuspendLayout();
        }

        public void ResumeLayout()
        {
            SelectDGVRowByIndex(BaseDGV, SelectedRowIndex, ScrollIndex);

            if (SortedByColumn != null)
            {
                BaseDGV.Sort(SortedByColumn, Direction);
            }
            
            BaseDGV.ResumeLayout();
        }


        public static void HideColumn(DataGridView DGV, int columnIndex)
        {
            try
            {
                DGV.Columns[columnIndex].Visible = false;
            }
            catch
            {

            }
        }

        public static void SelectRowByID(DataGridView DGV, int id)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(id.ToString()))
                {
                    DGV.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        public static void MakeDGVDobuleBuffered(DataGridView DGV)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            DGV, new object[] { true });
        }

        public static int GetDGVCurrentScrollIndex(DataGridView DGV)
        {
            return DGV.FirstDisplayedScrollingRowIndex;
        }

        public static int GetSelectedIndex(DataGridView DGV)
        {
            try
            {
                int Index = DGV.SelectedRows[0].Index;
                return Index;
            }
            catch
            {
                return -1;
            }
        }

        public static void SelectDGVRowByIndex(DataGridView DGV, int rowIndex, int scrollIndex)
        {
            DGV.SuspendLayout();
            if (rowIndex != -1)
            {
                if (DGV.Rows.Count > rowIndex)
                {
                    DGV.Rows[rowIndex].Selected = true;
                    DGV.FirstDisplayedScrollingRowIndex = scrollIndex;
                }
                else if (DGV.Rows.Count > 0)
                {
                    DGV.Rows[DGV.Rows.Count - 1].Selected = true;
                    DGV.FirstDisplayedScrollingRowIndex = DGV.Rows.Count - 1;
                }
                else
                {
                    DGV.ClearSelection();
                }
            }
            else
            {
                DGV.ClearSelection();
            }
            DGV.ResumeLayout();
        }
    }
}
