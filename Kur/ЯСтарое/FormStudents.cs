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
    public partial class FormStudents : Form
    {
        public FormStudents()
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
            // ученикDataGridView.Columns[ученикDataGridView.CurrentCell.ColumnIndex
            // ].DataPropertyName;
            студентDataGridView.Columns[студентDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }


        private void ученикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.ne_nadoDataSet.Студент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            // this.ученикTableAdapter.Fill(this.driverSchoolDataSet.Ученик);

        }

        private static FormStudents f;
        public static FormStudents fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormStudents();
                return f;
            }
        }

        private void ученикDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void ученикDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
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
               toolStripTextBoxFind.Text);
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
                MessageBox.Show("Таких студентов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                ученикBindingSource.Position = 0;
            }

        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        ученикBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
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
                checkBoxFind.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентDataGridView.DataSource = FillDataGridView("DBCC CHECKIDENT('driverSchool.dbo.Ученик', RESEED, 0)");
        }

        private void ученикBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void студентDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void студентDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value == null) ||
               (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "1")) e.CellStyle.BackColor = Color.Green;
            else
            {
                if
                (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "2")
                    e.CellStyle.BackColor = Color.SkyBlue;
                if
                (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "3")
                    e.CellStyle.BackColor = Color.Yellow;
                if
                (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "4")
                    e.CellStyle.BackColor = Color.Pink;
                if
                (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "5")
                    e.CellStyle.BackColor = Color.Blue;
                if
                (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "6")
                    e.CellStyle.BackColor = Color.Aqua;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxFind_Click(object sender, EventArgs e)
        {

        }
    }
}
