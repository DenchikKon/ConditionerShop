using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursTRPO
{
    public partial class AddClients : Form
    {
        public AddClients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count;
            SqlCommand command = null;
            string query;
            Regex Isnumber = new Regex(@"^(80|375)\((44|29|33|25)\)[0-9]{7}$");
            switch (buttonAplly.Text)
            {
                case "Добавить":
                    if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxLastname.Text != "" && textBoxPhone.Text != "" && textBoxAddress.Text != "")
                    {
                        if (Isnumber.IsMatch(textBoxPhone.Text))
                        {
                             query = $"if (Select count(Phone) From Buyer Where Phone = '{textBoxPhone.Text}')=0 " +
                                $"Insert Into Buyer(Name,Surname,Lastname,Phone,Address) Values(N'{textBoxName.Text}',N'{textBoxSurname.Text}',N'{textBoxLastname.Text}'," +
                                $"N'{textBoxPhone.Text}', N'{textBoxAddress.Text}')";
                             command = new SqlCommand(query, Form1.sqlConnection);
                            count = command.ExecuteNonQuery();
                            if (count == -1)
                                MessageBox.Show("Данный номер телефона уже имеется в бае");
                            else
                                Hide();
                        }
                        else
                            MessageBox.Show("Неверно набран номер (80(00)0000000)");
                    }
                    else
                        MessageBox.Show("Заполните все поля");
                    break;
                case "Изменить":
                    break;
            }
            
           
           
        }

        private void AddClients_Load(object sender, EventArgs e)
        {
            if(buttonAplly.Text == "Изменить")
            {
                Form1 form1 = this.Owner as Form1;
                textBoxName.Text = form1.dataGridClients.CurrentRow.Cells["Имя"].Value.ToString();
                textBoxSurname.Text = form1.dataGridClients.CurrentRow.Cells["Фамилия"].Value.ToString();
                textBoxLastname.Text = form1.dataGridClients.CurrentRow.Cells["Отчество"].Value.ToString();
                textBoxPhone.Text = form1.dataGridClients.CurrentRow.Cells["Номер телефона"].Value.ToString();
                textBoxAddress.Text = form1.dataGridClients.CurrentRow.Cells["Адрес"].Value.ToString();
            }
        }
    }
}
