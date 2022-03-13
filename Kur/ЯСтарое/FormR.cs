using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DriverSchoool
{
    public partial class FormR : Form
    {
        public FormR()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {


            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.driverSchoolConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        string GetSelectedFieldName()
        {
            return
           учебный_отделDataGridView.Columns[учебный_отделDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }

        private void учебный_отделBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учебный_отделBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);

        }

        private void FormR_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Учебный_отдел". При необходимости она может быть перемещена или удалена.
            this.учебный_отделTableAdapter.Fill(this.driverSchoolDataSet.Учебный_отдел);

        }
        private static FormR rb;
        public static FormR rdb
        {
            get
            {
                if (rb == null || rb.IsDisposed) rb = new FormR();
                return rb;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               учебный_отделBindingSource.Find(GetSelectedFieldName(),
               textBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                учебный_отделBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                учебный_отделBindingSource.Position = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        учебный_отделBindingSource.Filter =
                       GetSelectedFieldName() + "='" + textBox1.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                учебный_отделBindingSource.Filter = "";
            if (учебный_отделBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                учебный_отделBindingSource.Filter = "";
                checkBox1.Checked = false;
            }
        }
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            button2.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)учебный_отделBindingSource.Current)["Код_Работник"];
            else
                return -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void учебный_отделDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void учебный_отделDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
((учебный_отделDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value == null) ||
(учебный_отделDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"
].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (учебный_отделDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"
               ].Value.ToString() == "М")
                    e.CellStyle.BackColor = Color.SkyBlue;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }
    }
}
