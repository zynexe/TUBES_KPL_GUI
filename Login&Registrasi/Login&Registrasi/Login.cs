using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Registrasi
{
    public partial class Login : Form
    {

        private string email;
        private string password;

        public Login(string email, string password)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
        }

        public Login()
        {
            InitializeComponent();
        }

        public string[] staticEmail = { "ecospheree@gmail.com", "trontoton@gmail.com", "lilipung@gmail.com" };

        public string[] staticPassword = { "eco16", "tronton31", "lili20" };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            Login login1 = new Login();

            bool isValidUser = CheckValidUser(email, password);

            if (isValidUser)
            {
                MessageBox.Show("Login successful!");
                Login login = new Login(email, password);
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username!");
            }
        }

        private bool CheckValidUser(string email, string password)
        {
            for (int i = 0; i < staticEmail.Length; i++)
            {
                if (email == staticEmail[i] && password == staticPassword[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
