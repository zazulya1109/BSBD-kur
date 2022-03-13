using DriverSchoool.Заселенный_студент;
using DriverSchoool.Заявление;
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
    public partial class FormMain1 : Form
    {
        public FormMain1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudents.fd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormZ.zd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormGroup.gd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormINF.inf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormR.rdb.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Котов Дмитрий Сергеевич,Гр. 717-2 ,2020. Курсовой проект 'Автошкола'", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaprosiOdanih fm = new ZaprosiOdanih();
            fm.ShowDialog();
        }

        private void заявлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ismenenie fm = new Ismenenie();
            fm.ShowDialog();
        }

        private void операторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operators fm = new Operators();
            fm.ShowDialog();
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

        private void данныеОЗаявленияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNZaivlenie fm = new DNZaivlenie();
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
