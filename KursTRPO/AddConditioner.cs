using System;
using System.Collections;
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
    public partial class AddConditioner : Form
    {
        public AddConditioner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query;
            switch (buttonAplly.Text)
            {
                case "Добавить":
                    if(textBoxMaker.Text != "" && textBoxModel.Text != "" && textBoxPrice.Text != "" && textBoxTypeConditioner.Text != "" && textBoxCoolingPower.Text != "" &&
                        textBoxCount.Text != "")
                    {
                        if (int.TryParse(textBoxCount.Text, out int a) && double.TryParse(textBoxCoolingPower.Text,out double b) &&
                            double.TryParse(textBoxPrice.Text,out double c))
                        {
                            query = "Insert into Conditioner(Maker,Model,Date,Price,Count,TypeConditioner,CoolingPower)" +
                                $"Values(N'{textBoxMaker.Text}', N'{textBoxModel.Text}', '{dateTimePicker1.Value.ToString("yyyy/MM/dd")}', " +
                                $"'{textBoxPrice.Text.Replace(',', '.')}', '{textBoxCount.Text}', N'{textBoxTypeConditioner.Text}', '{textBoxCoolingPower.Text.Replace(",",".")}')";
                            DBManager.ExecuteQuery(query);
                            Hide();
                        }
                    }
                    break;
                case "Изменить":
                    Form1 form1 = this.Owner as Form1;
                    query = $"Update Conditioner Set Maker = N'{textBoxMaker.Text}', Model=N'{textBoxModel.Text}', " +
                        $"Date='{dateTimePicker1.Value.ToString("yyyy/MM/dd")}', Price='{textBoxPrice.Text.Replace(',','.')}', Count='{textBoxCount.Text}', " +
                        $"TypeConditioner=N'{textBoxTypeConditioner.Text}', CoolingPower='{textBoxCoolingPower.Text.Replace(',', '.')}' " +
                        $"Where IdItem={form1.dataGridConditioner.CurrentRow.Cells[0].Value}";
                    DBManager.ExecuteQuery(query);
                    Hide();
                    break;
            }
        }

        private void AddConditioner_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            if(buttonAplly.Text == "Изменить")
            {
                Form1 form1 = this.Owner as Form1;
                textBoxMaker.Text = form1.dataGridConditioner.CurrentRow.Cells["Производитель"].Value.ToString();
                textBoxModel.Text = form1.dataGridConditioner.CurrentRow.Cells["Модель"].Value.ToString();
                textBoxTypeConditioner.Text = form1.dataGridConditioner.CurrentRow.Cells["Тип кондиционера"].Value.ToString();
                textBoxCoolingPower.Text = form1.dataGridConditioner.CurrentRow.Cells["Мощность"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(form1.dataGridConditioner.CurrentRow.Cells["Дата выпуска"].Value);
                textBoxCount.Text = form1.dataGridConditioner.CurrentRow.Cells["Кол-во"].Value.ToString();
                textBoxPrice.Text = form1.dataGridConditioner.CurrentRow.Cells["Цена"].Value.ToString();
            }
        }
    }
}
