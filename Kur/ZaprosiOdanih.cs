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
    public partial class ZaprosiOdanih : Form
    {
        public ZaprosiOdanih()
        {
            InitializeComponent();
        }

        private static ZaprosiOdanih i;
        public static ZaprosiOdanih inf
        {
            get
            {
                if (i == null || i.IsDisposed) i = new ZaprosiOdanih();
                return i;
            }
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            //Создаем объект command для SQL команды 
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter 
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select 
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ZaprosiOdanih_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Студент ");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Распоряжение");
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT Комната.Id_Комната, Комната.Сколько_проживает, Комната.Этаж, Комната.Номер_комнаты, Заселенный_студент.Id_Студент, Общежитие.Адрес,Заселенный_студент.Заселенный_студент FROM Заселенный_студент INNER JOIN Комната ON Заселенный_студент.Id_Комната = Комната.Id_Комната INNER JOIN Общежитие ON Комната.Id_Общежитие = Общежитие.Id_Общежитие");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите ID необходимого студента.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = @"SELECT Студент.Id_Студент, Студент.Фамилия, Студент.Имя, Студент.Отчетсво, Студент.Номер_группы, Заселенный_студент.Заселенный_студент FROM Студент, Заселенный_студент WHERE Студент.Id_Студент = Заселенный_студент.Id_Студент AND Студент.Фамилия LIKE @Фамилия";
            /*SELECT PK_Студент.PK_Студент, PK_Студент.Фамилия, PK_Студент.Имя, PK_Студент.Отчество, PK_Студент.Номер_группы, Заселенный_студент.Заселенный_студент FROM PK_Студент, Заселенный_студент WHERE (PK_Студент.PK_Студент LIKE @ID)";*/
            /*SELECT * FROM PK_Студент WHERE PK_Студент.PK_Студент LIKE @ID*/
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.Add("@Фамилия", SqlDbType.NChar);
            command.Parameters["@Фамилия"].Value = textBoxWorker.Text + "%";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSelect2.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
