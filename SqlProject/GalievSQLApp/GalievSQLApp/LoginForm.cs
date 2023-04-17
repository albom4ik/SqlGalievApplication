using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalievSQLApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            

            loginField.Text = "Введите логин";

            passField.Text = "Введите пароль";


            loginField.Font = new Font(loginField.Font.FontFamily, 18, loginField.Font.Style);

            passField.Font = new Font(passField.Font.FontFamily, 18, passField.Font.Style);

            
            loginField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;

            this.passField.Size = new Size(this.passField.Size.Width, 52);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;


            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                MessageBox.Show("Вы успешно вошли в систему");
                
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль! Попробуйте еще раз");
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void RegisterLabel_Enter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;

            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {

            if (passField.Text == "Введите пароль")
            {
                passField.UseSystemPasswordChar = true;
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {

            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }
    }
}
