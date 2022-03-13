using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DriverSchoool
{
    public partial class Ismenenie : Form
    {
        public Ismenenie()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void groupBoxSubquery_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxText.Text))
            {
                MessageBox.Show("Введите необходимые данные",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT Комната.Номер_комнаты, Комната.Этаж, Комната.Сколько_проживает FROM Комната WHERE Сколько_проживает IN (SELECT Сколько_проживает FROM Комната WHERE Сколько_проживает LIKE @ID) ";
            else
            if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT Комната.Номер_комнаты, Комната.Этаж, Комната.Сколько_проживает  FROM Комната  WHERE Сколько_проживает > (SELECT AVG(Сколько_проживает) FROM Комната)  AND Комната.Номер_комнаты LIKE @ID ";
            else
            {
                MessageBox.Show("Не выбран вид подзапроса", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.Add("@ID", SqlDbType.NChar);
            command.Parameters["@ID"].Value = textBoxText.Text + "%";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет таких значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ismenenie_Load(object sender, EventArgs e)
        {

        }
    }
}
