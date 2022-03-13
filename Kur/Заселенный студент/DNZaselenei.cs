using DriverSchoool.Заявление;
using DriverSchoool.Студент;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool.Заселенный_студент
{
    public partial class DNZaselenei : Form
    {
        public DNZaselenei()
        {
            InitializeComponent();
        }

        private void заселенный_студентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заселенный_студентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);

        }

        private void DNZaselenei_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Распоряжение". При необходимости она может быть перемещена или удалена.
            this.распоряжениеTableAdapter.Fill(this.ne_nadoDataSet.Распоряжение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Заселенный_студент". При необходимости она может быть перемещена или удалена.
            this.заселенный_студентTableAdapter.Fill(this.ne_nadoDataSet.Заселенный_студент);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DNStudent fm = new DNStudent();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DNZaivlenie fm = new DNZaivlenie();
            fm.ShowDialog();
        }

        private void распоряжениеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.заселенный_студентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);
        }
    }
}
