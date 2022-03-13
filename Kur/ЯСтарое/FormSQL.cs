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
    public partial class FormSQL : Form
    {
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

        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL q;
        public static FormSQL qd
        {
            get
            {
                if (q == null || q.IsDisposed) q = new FormSQL();
                return q;
            }
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Ученик"); 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Учебный_отдел");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Заявление");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Группа");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButton5.Checked)
                sqlSelect = @"SELECT Учебный_отдел.Код_Работник, Фамилия, Имя, Отчество,
Заявление.Код_Заявления
 FROM Учебный_отдел, Заявление 
 WHERE  Учебный_отдел.Код_Работник = Заявление.Код_Работник
 GROUP BY Учебный_отдел.Код_Работник, Фамилия, Имя, Отчество,
Заявление.Код_Заявления";
            else
            if (radioButton6.Checked)
                sqlSelect = @"SELECT Учебный_отдел.Код_Работник, Фамилия, Имя, Отчество,
Группа.Код_Группа
 FROM Учебный_отдел, Группа
 WHERE Учебный_отдел.Код_Работник = Группа.Код_Работник
GROUP BY Учебный_отдел.Код_Работник, Фамилия, Имя, Отчество,
Группа.Код_Группа";
            else
                sqlSelect = @"SELECT Учебный_отдел.Код_Работник, Фамилия, Имя, Отчество,
Группа.Код_Группа,Заявление.Код_Заявления
 FROM Учебный_отдел, Группа,Заявление
WHERE Учебный_отдел.Код_Работник = Группа.Код_Работник AND Учебный_отдел.Код_Работник = Заявление.Код_Работник
GROUP BY Учебный_отдел.Код_Работник, Фамилия, Имя, Отчество,
Группа.Код_Группа,Заявление.Код_Заявления";
            SqlConnection connection = new
SqlConnection(Properties.Settings.Default.driverSchoolConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBox1.Text +
           "%");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
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
               int.Parse(textBox2.Text);
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
            dataGridView2.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Такой группы не существует !",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxKod.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxKod.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Учебный_отдел WHERE Код_Работник=@Id_dish";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.driverSchoolConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id_dish", id);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удалено");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Удаление невозможно. В таблице 'Сотрудники' имеются связные записи", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 return;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView("SELECT * FROM Учебный_отдел");
        }

        private void dataGridViewSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView("DBCC CHECKIDENT('driverSchool.dbo.Ученик', RESEED, 0)");
            MessageBox.Show("Автоинкремент сброшен !");
            return;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView("DBCC CHECKIDENT('driverSchool.dbo.Учебный_отдел', RESEED, 0)");
            MessageBox.Show("Автоинкремент сброшен !");
            return;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView("DBCC CHECKIDENT('driverSchool.dbo.Заявление', RESEED, 0)");
            MessageBox.Show("Автоинкремент сброшен !");
            return;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView("DBCC CHECKIDENT('driverSchool.dbo.Группа', RESEED, 0)");
            MessageBox.Show("Автоинкремент сброшен !");
            return;
        }
    }
}

