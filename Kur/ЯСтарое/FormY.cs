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
    public partial class FormY : Form
    {
        public FormY()
        {
            InitializeComponent();
        }
        string GetSelectedFieldName()
        {
            return
           ученикDataGridView.Columns[ученикDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }
        private void ученикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ученикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driverSchoolDataSet);

        }

        private void FormY_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driverSchoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            this.ученикTableAdapter.Fill(this.driverSchoolDataSet.Ученик);

        }
        private static FormY y;
        public static FormY yd
        {
            get
            {
                if (y == null || y.IsDisposed) y = new FormY();
                return y;
            }
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
    }
}
