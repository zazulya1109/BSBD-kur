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
    public partial class FormRB : Form
    {
        public FormRB()
        {
            InitializeComponent();
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
        private static FormRB rby;
        public static FormRB rbyd
        {
            get
            {
                if (rby == null || rby.IsDisposed) rby = new FormRB();
                return rby;
            }
        }
        private void FormRB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Учебный_отдел". При необходимости она может быть перемещена или удалена.
            this.учебный_отделTableAdapter.Fill(this.driverSchoolDataSet.Учебный_отдел);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
               учебный_отделBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBox1.Text);
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
                if (toolStripTextBox1.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        учебный_отделBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBox1.Text + "'";
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
