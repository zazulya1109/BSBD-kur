using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverSchoool.Заявление
{
    public partial class DNZaivlenie : Form
    {
        public DNZaivlenie()
        {
            InitializeComponent();
        }

        private void заявлениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявлениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ne_nadoDataSet);

        }

        private void DNZaivlenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.ne_nadoDataSet.Студент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ne_nadoDataSet.Заявление". При необходимости она может быть перемещена или удалена.
            this.заявлениеTableAdapter.Fill(this.ne_nadoDataSet.Заявление);

        }
    }
}
