using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;

namespace DriverSchoool
{
    public partial class FormAuth : Form
    {
        public string password, password_hash, textbox_hash,textbox_role;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
DialogResult.Yes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 24;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 32;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 hash = new Class2();
            password_hash = hash.Hash(password);
            textbox_hash = hash.Hash(textBox2.Text);
            textbox_role = comboBox1.Text;
            SQLiteConnection conn = new SQLiteConnection("Data Source=account.db; Version = 3;");
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Count (*) From users where Login = '" + textBox1.Text + "' and Password = '" + textbox_hash + "' and Role = '" + comboBox1.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (textbox_role == "Администратор")
                {
                    this.Hide();
                    var FormMain = new FormMain();
                    FormMain.Closed += (s, args) => this.Close();
                    FormMain.Show();
                }
                else if (textbox_role == "Раселитель")
                {
                    this.Hide();
                    var FormMain = new FormMain1();
                    FormMain.Closed += (s, args) => this.Close();
                    FormMain.Show();
                } 
                else if (textbox_role == "Комендант")
                {
                    this.Hide();
                    var FormMain = new FormMain2();
                    FormMain.Closed += (s, args) => this.Close();
                    FormMain.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль! Пожалуйста,повторите попытку." +
                    "            Примечание: Возможно вы забыли выбрать роль пользователя !");
                textBox1.Text = "";
                textBox1.Clear();
                textBox2.Text = "";
                textBox2.Clear();
                comboBox1.Text = "" ;
            }
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=account.db; Version = 3;");
            try
            {
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show((ex.Message));
            }
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                string sql_command = "DROP TABLE IF EXISTS users;"
                + "CREATE TABLE users("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "login TEXT(24), "
                + "password TEXT(32)," 
                + "role TEXT(20))";
                cmd.CommandText = sql_command;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show((ex.Message));
                }
                Class2 hash = new Class2();
                password = "1";
                password_hash = hash.Hash(password);
                string str = "insert into users(login,password,role) values ('1','" + password_hash + "','Администратор')";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                password = "12345";
                password_hash = hash.Hash(password);
                string std = "insert into users(login,password,role) values ('addict','" + password_hash + "','Раселитель')";
                cmd.CommandText = std;
                cmd.ExecuteNonQuery();
                password = "12345678";
                password_hash = hash.Hash(password);
                string stt = "insert into users(login,password,role) values ('guest','" + password_hash + "','Комендант')";
                cmd.CommandText = stt;
                cmd.ExecuteNonQuery();
            }
            conn.Dispose();
        }

        public FormAuth()
        {
            InitializeComponent();
        }
    }
}
