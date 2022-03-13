using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool.Комната
{
    public partial class DNKomnata : Form
    {
        public DNKomnata()
        {
            InitializeComponent();
        }

        private void комнатаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.комнатаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);

        }

        private void DNKomnata_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Комната". При необходимости она может быть перемещена или удалена.
            this.комнатаTableAdapter.Fill(this.ne_nadoDataSet.Комната);

        }
    }
}
