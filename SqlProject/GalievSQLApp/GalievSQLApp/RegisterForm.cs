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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GalievSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";

            userMailField.Text = "Введите почту";

            loginField.Text = "Введите логин";

            passField.Text = "Введите пароль";

            userNameField.Font = new Font(userNameField.Font.FontFamily, 18, userNameField.Font.Style);

            userMailField.Font = new Font(userMailField.Font.FontFamily, 18, userMailField.Font.Style);

            loginField.Font = new Font(loginField.Font.FontFamily, 18, loginField.Font.Style);

            passField.Font = new Font(passField.Font.FontFamily, 18, passField.Font.Style);

            

            userNameField.ForeColor = Color.Gray;
            userMailField.ForeColor = Color.Gray;
            loginField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userMailField_Enter(object sender, EventArgs e)
        {
            if (userMailField.Text == "Введите почту")
            {

                userMailField.Text = "";
                userMailField.ForeColor = Color.Black;
            }
        }

        private void userMailField_Leave(object sender, EventArgs e)
        {
            if (userMailField.Text == "")
            {
                userMailField.Text = "Введите почту";
                userMailField.ForeColor = Color.Gray;
            }
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



        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userMailField.Text == "Введите почту")
            {
                MessageBox.Show("Введите почту");
                return;
            }

            if (passField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }



            if (isUserExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `mail`) VALUES (@login, @pass, @name, @mail)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = userMailField.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.closeConnection();


        }


        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());


            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
           

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            
            {
                
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}
