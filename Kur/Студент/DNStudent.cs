using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool.Студент
{
    public partial class DNStudent : Form
    {
        public DNStudent()
        {
            InitializeComponent();
        }

        private void студентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.студентBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);
            }
            catch (Exception err)
            {
               MessageBox.Show(err.Message, "Ошибка при заполнении данных", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void DNStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.ne_nadoDataSet.Студент);

        }

        // одиночка
        private static DNStudent f;
        public static DNStudent fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new DNStudent();
                return f;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ученикBindingNavigator_RefreshItems(object sender, EventArgs e)
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
                indexPos = студентBindingSource.Find(GetSelectedFieldName(),toolStripTextBoxFind.Text);
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
                MessageBox.Show("Таких студентов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                студентBindingSource.Position = 0;
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
                        студентBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                студентBindingSource.Filter = "";
            if (студентBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                студентBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private string GetSelectedFieldName()
        {
            throw new NotImplementedException();
        }
    }
}
