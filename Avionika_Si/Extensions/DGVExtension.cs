using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        public int SelectedColumnIndex { get; set; }

        private int ContextColIndex { get; set; }
        private int ContextRowIndex { get; set; }

        public int ScrollIndex { get; set; }
        private DataGridViewColumn SortedByColumn { get; set; }
        private ListSortDirection Direction { get; set; }

        private ContextMenu context = null;

        void CopyMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(BaseDGV.Rows[ContextRowIndex].Cells[ContextColIndex].Value.ToString());
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BaseDGV.SuspendLayout();
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    ContextColIndex = e.ColumnIndex;
                    ContextRowIndex = e.RowIndex;
                    var coordinates = BaseDGV.PointToClient(Cursor.Position);
                    context.Show(BaseDGV, new Point(coordinates.X, coordinates.Y));
                }
            }
            BaseDGV.ResumeLayout();
        }

        public void InitCopyCellContextMenu()
        {
            context = new ContextMenu();
            context.MenuItems.Add(new MenuItem("Копировать содержимое", CopyMenuItem_Click));

            BaseDGV.CellMouseClick += DGV_CellMouseClick;
        }

        public DGVExtension(DataGridView DGV)
        {
            BaseDGV = DGV;
        }

        public void SuspendLayout()
        {
            SelectedRowIndex = GetSelectedIndex(BaseDGV);
            SelectedColumnIndex = GetSelectedColumn(BaseDGV);
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
            if (BaseDGV.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                SelectDGVRowByIndex(BaseDGV, SelectedRowIndex, ScrollIndex);

                if (SortedByColumn != null)
                {
                    BaseDGV.Sort(SortedByColumn, Direction);
                }

                BaseDGV.ResumeLayout();
            }
            /*else if (BaseDGV.SelectionMode == DataGridViewSelectionMode.CellSelect || BaseDGV.SelectionMode == DataGridViewSelectionMode.RowHeaderSelect)
            {
                SelectDGVCellByIndex(BaseDGV, SelectedRowIndex, SelectedColumnIndex, ScrollIndex);

                if (SortedByColumn != null)
                {
                    BaseDGV.Sort(SortedByColumn, Direction);
                }

                BaseDGV.ResumeLayout();

            }*/
            else
            {
                BaseDGV.ResumeLayout();
            }
            
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

        public static void SelectRowByIDInTag(DataGridView DGV, int id)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                if (row.Tag.Equals(id.ToString()))
                {
                    DGV.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        public static void SelectCellByID(DataGridView DGV, int id, int columnIndex)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                if (row.Tag.ToString().Equals(id.ToString()))
                {
                    DGV.CurrentCell = DGV.Rows[row.Index].Cells[columnIndex];
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

        public static int GetSelectedColumn(DataGridView DGV)
        {
            try
            {
                int Index = DGV.SelectedCells[0].ColumnIndex;
                return Index;
            }
            catch
            {
                return -1;
            }
        }

        public static void SelectDGVCellByIndex(DataGridView DGV, int rowIndex, int columnIndex, int scrollIndex)
        {
            DGV.SuspendLayout();
            if (rowIndex != -1)
            {
                if (DGV.Rows.Count > rowIndex)
                {
                    DGV.Rows[rowIndex].Cells[columnIndex].Selected=true;
                    //DGV.Rows[rowIndex].Selected = true;
                    DGV.FirstDisplayedScrollingRowIndex = scrollIndex;
                }
                else if (DGV.Rows.Count > 0)
                {
                    DGV.Rows[rowIndex-1].Cells[columnIndex].Selected = true;

                    //DGV.Rows[DGV.Rows.Count - 1].Selected = true;
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
