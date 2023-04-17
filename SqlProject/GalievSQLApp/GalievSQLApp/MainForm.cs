using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalievSQLApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dataGridView1.Visible = false;

            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        

       
        private void Athlete_Transition_Click(object sender, EventArgs e)
        {
            choice.Text = "Спортсмены";
            dataGridView1.Visible = true;
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=galievbd");
            connection.Open();
            string query = "SELECT * FROM athlete";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);



            dataGridView1.Columns[0].HeaderText = "Код спортсмена";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Возраст";
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
            connection.Close();
        }

        private void Sports_Label_Click(object sender, EventArgs e)
        {
            choice.Text = "Виды спорта";
            dataGridView1.Visible = true;
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=galievbd");
            connection.Open();
            string query = "SELECT * FROM sport";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 450;
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);



            dataGridView1.Columns[0].HeaderText = "Код спорта";
            dataGridView1.Columns[1].HeaderText = "Название спорта";
            dataGridView1.Columns[2].HeaderText = "Описание спорта";
            connection.Close();
        }

        private void StadiumLabel_Click(object sender, EventArgs e)
        {
            choice.Text = "Стадионы";
            dataGridView1.Visible = true;
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=galievbd");
            connection.Open();
            string query = "SELECT * FROM stadium";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 185;
            dataGridView1.Columns[3].Width = 115;
            
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);



            dataGridView1.Columns[0].HeaderText = "Код стадиона";
            dataGridView1.Columns[1].HeaderText = "Название стадиона";
            dataGridView1.Columns[2].HeaderText = "Локация стадиона";
            dataGridView1.Columns[3].HeaderText = "Численность стадиона";
            connection.Close();
        }

        private void Journal_Label_Click(object sender, EventArgs e)
        {
            
            choice.Text = "Учет";
            dataGridView1.Visible = true;
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=galievbd");
            connection.Open();
            string query = "SELECT * FROM athlete_performance";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[1].Width = 95;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;

            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);



            dataGridView1.Columns[0].HeaderText = "Код результата";
            dataGridView1.Columns[1].HeaderText = "Код спортсмена";
            dataGridView1.Columns[2].HeaderText = "Код спорта";
            dataGridView1.Columns[3].HeaderText = "Код стадиона";
            dataGridView1.Columns[4].HeaderText = "Дата выступления";
            dataGridView1.Columns[5].HeaderText = "Результат выступления";
            connection.Close();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход из аккаунта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }
    }
}
