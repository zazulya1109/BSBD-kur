using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool.Распоряжение
{
    public partial class DNRaspore : Form
    {
        public DNRaspore()
        {
            InitializeComponent();
        }

        private void распоряжениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.распоряжениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);

        }

        private void DNRaspore_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Распоряжение". При необходимости она может быть перемещена или удалена.
            this.распоряжениеTableAdapter.Fill(this.ne_nadoDataSet.Распоряжение);

        }

        private void распоряжениеDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
          ((распоряжениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value == null) ||
          (распоряжениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() == "1")) e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if
               (распоряжениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() == "2")
                    e.CellStyle.BackColor = Color.SkyBlue;
                if
                (распоряжениеDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() == "4")
                    e.CellStyle.BackColor = Color.Yellow;
                else
                    e.CellStyle.BackColor = Color.Pink;
            }
        }

        private void распоряжениеBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
