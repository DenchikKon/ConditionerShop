using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace KursTRPO
{
    public partial class Form1 : Form
    {
        public static string mainSellsQuery = "Select s.IdSell, Concat(c.Maker, ' ', c.Model) as 'Товар' ,Concat(b.Name, ' ', b.Surname, ' ', b.Lastname) as 'Покупатель', s.DateSell as 'Дата'  From Sell s\r\nleft join Buyer b on b.IdBuyer = s.IdBuyer\r\nleft join Conditioner c on c.IdItem = s.IdItem";
        public static string mainConditionerQuery = "Select c.IdItem, c.Maker as 'Производитель', c.Model as 'Модель', c.TypeConditioner as 'Тип кондиционера', c.CoolingPower as 'Мощность' ,c.Date as 'Дата выпуска', c.Price as 'Цена',c.Count as 'Кол-во' From Conditioner c";
        public static string mainBuyerQuery = "Select b.IdBuyer, b.Name as 'Имя', b.Surname as 'Фамилия', b.Lastname as 'Отчество', b.Phone as 'Номер телефона', b.Address as 'Адрес' From Buyer b";
        public static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DateBase"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            DBManager.LoadData(mainBuyerQuery, dataGridClients);
            dataGridClients.Columns[0].Visible = false;
            DBManager.LoadData(mainConditionerQuery, dataGridConditioner);
            dataGridConditioner.Columns[0].Visible = false;
            DBManager.LoadData(mainSellsQuery,dataGridSells);
            dataGridSells.Columns[0].Visible = false;
            string query = "Select distinct Concat(c.Maker, ' ', c.Model) From Conditioner c";
            Methods.ComboBoxLoadDataWithOutValue(query,comboBoxFilterConditionerName);
            query = "Select distinct Concat(b.Name, ' ', b.Surname, ' ', b.Lastname) From Buyer b";
            Methods.ComboBoxLoadDataWithOutValue(query, comboBoxFilterBuyer);
            dateTimePickerFilterMax.Enabled = false;
            dateTimePickerFilterMin.Enabled = false;
            comboBoxFilterBuyer.SelectedValue = null;
            comboBoxFilterConditionerName.SelectedValue = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxSearchSells_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridSells, textBoxSearchSells);
        }

        private void textBoxSearchClients_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridClients,textBoxSearchClients);
        }

        private void textBoxSearchConditioner_TextChanged(object sender, EventArgs e)
        {
            Methods.SearchData(dataGridConditioner, textBoxSearchConditioner);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dataGridSells?.CurrentRow?.Index ?? -1) != -1 || (dataGridSells?.CurrentRow?.Index ?? 0) != 0)
                {
                    string query = $"Delete Sell Where IdSell = {dataGridSells.CurrentRow.Cells[0].Value}";
                    DBManager.ExecuteQuery(query);
                    dataGridSells.Rows.RemoveAt(dataGridSells.CurrentRow.Index);
                }
                else
                    MessageBox.Show("Невозможно удалить данную строку", "Ошибка", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Не возможно удалить данную запись");
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dataGridConditioner?.CurrentRow?.Index ?? -1) != -1 || (dataGridConditioner?.CurrentRow?.Index ?? 0) != 0)
                {
                    string query = $"Delete Conditioner Where IdItem = {dataGridConditioner.CurrentRow.Cells[0].Value}";
                    DBManager.ExecuteQuery(query);
                    dataGridConditioner.Rows.RemoveAt(dataGridConditioner.CurrentRow.Index);
                }
                else
                    MessageBox.Show("Невозможно удалить данную строку", "Ошибка", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Не возможно удалить данную запись");
            }
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dataGridClients?.CurrentRow?.Index ?? -1) != -1 || (dataGridClients?.CurrentRow?.Index ?? 0) != 0)
                {
                    string query = $"Delete Buyer Where IdBuyer = {dataGridClients.CurrentRow.Cells[0].Value}";
                    DBManager.ExecuteQuery(query);
                    dataGridClients.Rows.RemoveAt(dataGridClients.CurrentRow.Index);
                }
                else
                    MessageBox.Show("Невозможно удалить данную строку", "Ошибка", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Не возможно удалить данную запись");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddClients addClients = new AddClients();
            addClients.Owner = this;
            addClients.buttonAplly.Text = "Добавить";
            addClients.ShowDialog();
            DBManager.LoadData(mainBuyerQuery, dataGridClients);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddConditioner addConditioner = new AddConditioner();
            addConditioner.Owner = this;
            addConditioner.buttonAplly.Text = "Добавить";
            addConditioner.ShowDialog();
            DBManager.LoadData(mainConditionerQuery, dataGridConditioner);
        }

        private void buttonAddSells_Click(object sender, EventArgs e)
        {
            addSells addSells = new addSells();
            addSells.Owner = this;
            addSells.ShowDialog();
            DBManager.LoadData(mainSellsQuery, dataGridSells);
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddConditioner addConditioner = new AddConditioner();
            addConditioner.Owner = this;
            addConditioner.buttonAplly.Text = "Изменить";
            addConditioner.ShowDialog();
            DBManager.LoadData(mainConditionerQuery, dataGridConditioner);
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddClients addClients = new AddClients();
            addClients.Owner = this;
            addClients.buttonAplly.Text = "Изменить";
            addClients.ShowDialog();
            DBManager.LoadData(mainBuyerQuery, dataGridClients);
        }

        private void dataGridSells_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridSells.ClearSelection();
                    dataGridSells[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridConditioner_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridConditioner.ClearSelection();
                    dataGridConditioner[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridClients_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridClients.ClearSelection();
                    dataGridClients[e.ColumnIndex, e.RowIndex].Selected = true;
                }
            }
        }

        private void ButtonCancelFilterSells_Click(object sender, EventArgs e)
        {
            comboBoxFilterBuyer.SelectedValue = null;
            comboBoxFilterBuyer.SelectedIndex = -1;
            comboBoxFilterConditionerName.SelectedValue = null;
            comboBoxFilterConditionerName.SelectedIndex = -1;
            dateTimePickerFilterMax.Enabled = false;
            checkBoxMaxDate.Checked= false;
            dateTimePickerFilterMin.Enabled= false;
            checkBoxMinDate.Checked= false;
            DBManager.LoadData(mainSellsQuery, dataGridSells);

        }

        private void checkBoxMinDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinDate.Checked)
            {
                dateTimePickerFilterMin.Enabled = true;
            }
            else
                dateTimePickerFilterMin.Enabled = false;
        }

        private void checkBoxMaxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaxDate.Checked)
            {
                dateTimePickerFilterMax.Enabled = true;
            }else
                dateTimePickerFilterMax.Enabled = false;
        }

        private void buttonApplyFilterSells_Click(object sender, EventArgs e)
        {
            string mindate = dateTimePickerFilterMin.Enabled ? dateTimePickerFilterMin.Value.ToString("yyyy/MM/dd") : DateTime.MinValue.ToString("yyyy/MM/dd");
            string maxdate = dateTimePickerFilterMax.Enabled ? dateTimePickerFilterMax.Value.ToString("yyyy/MM/dd") : DateTime.MaxValue.ToString("yyyy/MM/dd");
            string query = mainSellsQuery + $" Where (Concat(c.Maker, ' ', c.Model)) = N'Zanussi ZACS/I-09 HPF' AND (Concat(b.Name, ' ', b.Surname, ' ', b.Lastname))  = N'Максим Половинкин Александрович' AND s.DateSell between '{mindate}' and '{maxdate}'";
            DBManager.LoadData(query, dataGridSells);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string headertext = "Продажи";
            Methods.ExportExcel(dataGridSells, headertext);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo;
            string fileName = "Чек.docx";
            if (File.Exists(fileName))
            {
                fileInfo = new FileInfo(fileName);

                string query = $"Select Price From Conditioner Where IdItem = {dataGridSells.CurrentRow.Cells[0].Value}";
                SqlCommand command = new SqlCommand(query,sqlConnection);
                int price = Convert.ToInt32(command.ExecuteScalar());

                var items = new Dictionary<string, string>
                {
                {"<DATE>",  Convert.ToDateTime(dataGridSells.CurrentRow.Cells["Дата"].Value.ToString()).ToString("dd/MM/yyyy") },
                {"<ItemName>", dataGridSells.CurrentRow.Cells["Товар"].Value.ToString()},
                {"<Price>", price.ToString() },
                };

                try
                {
                    Word.Application app = new Word.Application();
                    Object file = fileInfo.FullName;

                    Object missing = Type.Missing;

                    app.Documents.Open(@"D:\KursTRPO\KursTRPO\Чек.docx");
                    app.Visible = false;
                    foreach (var item in items)
                    {
                        Word.Find find = app.Selection.Find;
                        find.Text = item.Key.ToString();
                        find.Replacement.Text = item.Value.ToString();

                        object wrap = Word.WdFindWrap.wdFindContinue;
                        object replace = Word.WdReplace.wdReplaceAll;

                        find.Execute(FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace);
                    }
                    app.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Требуется выбрать строку");
            }
        }
    }
}
