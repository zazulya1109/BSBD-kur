using DriverSchoool.Заселенный_студент;
using DriverSchoool.Комната;
using DriverSchoool.общага;
using DriverSchoool.Распоряжение;
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

namespace DriverSchoool
{
    public partial class FormMain2 : Form
    {
        public FormMain2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormY.yd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRB.rbyd.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormG.grd.Show();
        }

        private void FormMain2_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Зазуля Анастасия Сергеевна,группа 718,2021. КУРСОВАЯ РАБОТА", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void данныеСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNStudent fm = new DNStudent();
            fm.ShowDialog();
        }

        private void распоряженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNRaspore fm = new DNRaspore();
            fm.ShowDialog();
        }

        private void заселенныйСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNKomnata fm = new DNKomnata();
            fm.ShowDialog();
        }

        private void данныеООбщежитияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNob fm = new DNob();
            fm.ShowDialog();
        }

        private void данныеОЗаселенныхСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNZaselenei fm = new DNZaselenei();
            fm.ShowDialog();
        }
    }
}
