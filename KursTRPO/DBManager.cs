using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursTRPO
{
    internal class DBManager
    {
        public static void LoadData(string query, DataGridView dataGrid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, Form1.sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
        }
        public static void ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, Form1.sqlConnection);
            command.ExecuteNonQuery();
        }
    }
}
