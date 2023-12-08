using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace KursTRPO
{
    internal class Methods
    {
        public static void SearchData(DataGridView dataGrid, TextBox searchBox)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                int count = 0;
                for (int j = 1; j < dataGrid.ColumnCount; j++)
                {
                    if (dataGrid[j, i].Value.ToString().IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        count++;
                }
                if (count > 0)
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                else
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            if (searchBox.Text == "")
                for (int i = 0; i < dataGrid.RowCount; i++)
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }
        public static void LoadComboBoxData(String query, ComboBox comboBox, string valueMember, string displayMember)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, Form1.sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = $"{displayMember}";
            comboBox.ValueMember = $"{valueMember}";

        }
        public static void ComboBoxLoadDataWithOutValue(String query, ComboBox comboBox)
        {
            SqlCommand command = new SqlCommand(query, Form1.sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox.Items.Add(dataReader.GetValue(0));
            }
            dataReader.Close();
        }
        public static void ExportExcel(DataGridView dataGrid, string listname)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            wsh.Cells.Range[wsh.Cells[1, 1], wsh.Cells[1, dataGrid.ColumnCount - 1]].Merge();
            wsh.Columns.Style.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            wsh.Cells[1, 1] = $"{listname}";
            wsh.Name = $"{listname}";

            for (int i = 1; i < dataGrid.ColumnCount; i++)
            {
                wsh.Cells[2, i] = dataGrid.Columns[i].HeaderText;
                wsh.Cells[2, i].Borders.Value = BorderStyle.FixedSingle;
            }
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 1; j < dataGrid.ColumnCount; j++)
                {
                    wsh.Cells[i + 3, j] = dataGrid[j, i].Value.ToString();
                    wsh.Cells[i + 3, j].Borders.Value = BorderStyle.FixedSingle;
                }
            }
            wsh.Cells.Range[wsh.Cells[dataGrid.RowCount + 3, 1], wsh.Cells[dataGrid.RowCount + 3, dataGrid.ColumnCount - 1]].Merge();
            wsh.Columns.Style.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            wsh.Cells[dataGrid.RowCount + 3, 1] = $"Составил:";
            wsh.Columns.AutoFit();
            exApp.Visible = true;
        }
    }
}
