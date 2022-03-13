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
    public partial class FormGroup : Form
    {
        public FormGroup()
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
        private static FormGroup g;
        public static FormGroup gd
        {
            get
            {
                if (g == null || g.IsDisposed) g = new FormGroup();
                return g;
            }
        }
        private void FormGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Учебный_отдел". При необходимости она может быть перемещена или удалена.
            this.учебный_отделTableAdapter.Fill(this.driverSchoolDataSet.Учебный_отдел);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            this.ученикTableAdapter.Fill(this.driverSchoolDataSet.Ученик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.driverSchoolDataSet.Группа);

        }

        private void группаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.группаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении данных", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.ученикBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении данных", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
           (((DataRowView)группаBindingSource.Current)["Код_Работник"].ToString() !=
           "")
            {
                id =
               (int)(((DataRowView)группаBindingSource.Current)["Код_Работник"]);
            }
            id = FormR.rdb.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)группаBindingSource.Current)["Код_Работник"]
               = id;
                группаBindingSource.EndEdit();
                учебный_отделTableAdapter.Fill(this.driverSchoolDataSet.Учебный_отдел);
            }

        }

        private void ученикDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
((ученикDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value == null) ||
(ученикDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"
].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (ученикDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"
               ].Value.ToString() == "М")
                    e.CellStyle.BackColor = Color.SkyBlue;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }

        private void ученикDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string GetSelectedFieldName()
        {
            return
           ученикDataGridView.Columns[ученикDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               ученикBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                ученикBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                ученикBindingSource.Position = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (toolStripTextBox1.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        ученикBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBox1.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                ученикBindingSource.Filter = "";
            if (ученикBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                ученикBindingSource.Filter = "";
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
