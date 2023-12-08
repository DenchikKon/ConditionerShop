using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursTRPO
{
    public partial class addSells : Form
    {
        public addSells()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedIndex != -1 && comboBoxItems.SelectedIndex != -1)
            {
                string query = $"Insert Into Sell(IdItem,IdBuyer,DateSell) Values('{comboBoxItems.SelectedValue}'," +
                    $"'{comboBoxClients.SelectedValue}','{DateTime.Now.ToString("yyyy/MM/dd")}')";
                DBManager.ExecuteQuery(query);
                Hide();
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void addSells_Load(object sender, EventArgs e)
        {
            string query = "Select IdBuyer as 'Id', CONCAT(b.Surname,' ',b.Name,' ',b.Lastname) as 'Клиенты' From Buyer b";
            Methods.LoadComboBoxData(query, comboBoxClients, "Id", "Клиенты");
            query = "Select c.IdItem as 'Id',CONCAT(c.Maker,' ',c.Model) as 'Товар' From Conditioner c";
            Methods.LoadComboBoxData(query,comboBoxItems,"Id","Товар");
        }
    }
}
