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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
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

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Учебный_отдел". При необходимости она может быть перемещена или удалена.
            this.учебный_отделTableAdapter.Fill(this.driverSchoolDataSet.Учебный_отдел);

        }
        private static FormTeacher r;
        public static FormTeacher rd
        {
            get
            {
                if (r == null || r.IsDisposed) r = new FormTeacher();
                return r;
            }
        }

        private void учебный_отделBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.учебный_отделBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении данных", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void учебный_отделDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
((учебный_отделDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value == null) ||
(учебный_отделDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"
].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (учебный_отделDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"
               ].Value.ToString() == "М")
                    e.CellStyle.BackColor = Color.SkyBlue;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            учебный_отделBindingSource.Position = 0;
            Show();
            Activate();


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
               учебный_отделBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
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
                        учебный_отделBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
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
                checkBoxFind.Checked = false;
            }
        }
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)учебный_отделBindingSource.Current)["Код_Работник"];
            else
                return -1;

        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void учебный_отделBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FormTeacher_Shown(object sender, EventArgs e)
        {

        }

        private void учебный_отделDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            учебный_отделDataGridView.DataSource = FillDataGridView("DBCC CHECKIDENT('driverSchool.dbo.Учебный_отдел', RESEED, 0)");
        }
    }
}