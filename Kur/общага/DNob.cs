using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool.общага
{
    public partial class DNob : Form
    {
        public DNob()
        {
            InitializeComponent();
        }

        private void общежитиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.общежитиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);

        }

        private void DNob_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Общежитие". При необходимости она может быть перемещена или удалена.
            this.общежитиеTableAdapter.Fill(this.ne_nadoDataSet.Общежитие);

        }
    }
}
