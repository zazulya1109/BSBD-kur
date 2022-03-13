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
    public partial class FormG : Form
    {
        public FormG()
        {
            InitializeComponent();
        }
        DataTable FillDataGridView(string sqlSelect)
        {


            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.driverSchoolConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private static FormG gr;
        public static FormG grd
        {
            get
            {
                if (gr == null || gr.IsDisposed) gr = new FormG();
                return gr;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой группы !",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";

            sqlSelect = @"SELECT Номер_Группы,Категория,(SELECT Фамилия+' '+Имя+' '+Отчество FROM Ученик WHERE Ученик.Код_Ученика=Группа.Код_ученика) AS Ученик
FROM Группа
 WHERE Номер_Группы =@number";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.driverSchoolConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
               int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Номер группы в условии должен быть задан числом !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Такой группы не существует !",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
