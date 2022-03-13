using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool
{
    public partial class FormZ : Form
    {
        public FormZ()
        {
            InitializeComponent();
        }

        string GetSelectedFieldName()
        {
            return
           //ученикDataGridView.Columns[ученикDataGridView.CurrentCell.ColumnIndex
          // ].DataPropertyName;
            студентDataGridView.Columns[студентDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        string GetSelectedFieldName1()
        {
            return
          // учебный_отделDataGridView.Columns[учебный_отделDataGridView.CurrentCell.ColumnIndex
          // ].DataPropertyName;
            студентDataGridView.Columns[студентDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void FormZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.ne_nadoDataSet.Студент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Заявление". При необходимости она может быть перемещена или удалена.
            this.заявлениеTableAdapter1.Fill(this.ne_nadoDataSet.Заявление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Учебный_отдел". При необходимости она может быть перемещена или удалена.
          //  this.учебный_отделTableAdapter.Fill(this.driverSchoolDataSet.Учебный_отдел);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            //this.ученикTableAdapter.Fill(this.driverSchoolDataSet.Ученик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            //this.ученикTableAdapter.Fill(this.driverSchoolDataSet.Ученик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Заявление". При необходимости она может быть перемещена или удалена.
            //this.заявлениеTableAdapter.Fill(this.driverSchoolDataSet.Заявление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Заявление". При необходимости она может быть перемещена или удалена.
            //this.заявлениеTableAdapter.Fill(this.driverSchoolDataSet.Заявление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Заявление". При необходимости она может быть перемещена или удалена.
            //this.заявлениеTableAdapter.Fill(this.driverSchoolDataSet.Заявление);
            //driverSchoolDataSet.Заявление.Columns["Дата"].DefaultValue = DateTime.Now;

        }

        private static FormZ z;
        public static FormZ zd
        {
            get
            {
                if (z == null || z.IsDisposed) z = new FormZ();
                return z;
            }
        }

        private void заявлениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.заявлениеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении данных", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void заявлениеBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.заявлениеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении данных", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void заявлениеBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
            this.заявлениеBindingSource.EndEdit();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void ученикDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ученикDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
((студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value == null) ||
(студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"
].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (студентDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"
               ].Value.ToString() == "М")
                    e.CellStyle.BackColor = Color.SkyBlue;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }

        private void учебный_отделDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
((заявлениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn15"].Value == null) ||
(заявлениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn15"
].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (заявлениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn15"
               ].Value.ToString() == "М")
                    e.CellStyle.BackColor = Color.SkyBlue;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }

        private void учебный_отделDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
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
               студентBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                студентBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                студентBindingSource.Position = 0;
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               учебный_отделBindingSource.Find(GetSelectedFieldName1(),
               toolStripTextBox2.Text);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (toolStripTextBox2.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        учебный_отделBindingSource.Filter =
                       GetSelectedFieldName1() + "='" + toolStripTextBox2.Text + "'";
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
                checkBox2.Checked = false;
            }
        }

        private void фИО_УченикаLabel1_Click(object sender, EventArgs e)
        {

        }

        private void студентDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxS_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxT_Enter(object sender, EventArgs e)
        {

        }

        private void заявлениеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_СтудентTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
