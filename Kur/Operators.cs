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
    public partial class Operators : Form
    {
        public Operators()
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

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked)
                AddStudent();
            else
                if (radioButtonUpdate.Checked)
                UpdateStudent();
            else
                if (radioButtonDelete.Checked)
                DeleteStudent();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void AddStudent()
        {
            if (String.IsNullOrEmpty(textBoxFDML.Text) || (String.IsNullOrEmpty(textBoxNDML.Text) || (String.IsNullOrEmpty(textBoxODML.Text) || (String.IsNullOrEmpty(textBoxGroupDML.Text) || (String.IsNullOrEmpty(textBoxCourseDML.Text))))))
            {
                MessageBox.Show("Обязательно введите его ФИО, номер группы, курс и комнату", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int passnum = 0;
            if (!int.TryParse(textBoxCourseDML.Text, out passnum))
            {
                MessageBox.Show("Некоректные данные!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO PK_Студент (Id_Студент,Фамилия, Имя, Отчество, Номер_группы, Курс_обучения) VALUES (@ID, @Фамилия, @Имя, @Отчество, @Номер_группы, @Курс_обучения)";
            /*@Общежитие, @Комната)";*/
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@Фамилия", textBoxFDML.Text);
            command.Parameters.AddWithValue("@Имя", textBoxNDML.Text);
            command.Parameters.Add("@Отчество", SqlDbType.NVarChar).Value = textBoxODML.Text;
            command.Parameters.AddWithValue("@Номер_группы", textBoxGroupDML.Text);
            command.Parameters.AddWithValue("@Курс_обучения", textBoxCourseDML.Text);
            /*command.Parameters.AddWithValue("@Общежитие", textBoxHostelDML.Text);
            command.Parameters.AddWithValue("@Комната", textBoxRoomNumDML.Text);*/

            connection.Close();
            buttonSelectStudent_Click(this, EventArgs.Empty);
        }

        private void buttonSelectStudent_Click(object sender, EventArgs e)
        {
            string sqlSelect = @"SELECT Студент.Id_Студент, Студент.Фамилия, Студент.Имя, Студент.Номер_группы, '2' FROM Студент ";
            /*SELECT * FROM PK_Студент WHERE PK_Студент.PK_Студент LIKE @ID*/
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            /*command.Parameters.Add("@ID", SqlDbType.NChar);
            command.Parameters["@ID"].Value = textBoxWorker.Text + "%";*/
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void UpdateStudent()
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Обязательно укажите ID студента, данные которого подлежать корректировке", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некоректное значение ID студента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "update Студент set Фамилия= @Фамилия, Имя = @Имя, Отчество = @Отчество, Номер_группы = @Номер_группы, Курс_обучения = @Курс_обучения WHERE Id_Студент = @id ";
            /*UPDATE PK_Студент SET Фамилия= @Фамилия, Имя = @Имя, Отчество = @Отчество, Номер_группы = @Номер_группы, Курс_обучения = @Курс_обучения WHERE PK_Студент = @id ";*/
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxFDML.Text))
                sqlValues += "Фамилия=@Фамилия";

            if (!String.IsNullOrEmpty(textBoxNDML.Text))
                sqlValues += "Имя=@Имя";

            if (!String.IsNullOrEmpty(textBoxODML.Text))
                sqlValues += "Отчество=@Отчество";

            if (!String.IsNullOrEmpty(textBoxGroupDML.Text))
                sqlValues += "Номер_группы=@Номер_группы";

            if (!String.IsNullOrEmpty(textBoxCourseDML.Text))
                sqlValues += "Курс_обучения=@Курс_обучения";
        }
        void DeleteStudent()
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Обязательно укажите ID записи, которую необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Студент WHERE Id_Студент = @id";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ne_nadoConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@id", textBoxID.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectStudent_Click(this, EventArgs.Empty);
        }

        private void groupBoxDML_Enter(object sender, EventArgs e)
        {

        }
    }
}
