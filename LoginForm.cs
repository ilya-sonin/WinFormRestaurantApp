using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovaySonin2024
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void toResutuarantMenu()
        {
            var resuarantForm = new RestuarantMenu();
            resuarantForm.Show();
            this.Hide();
        }

        private void toRegistration()
        {
            var registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = maskedTextBoxPhoneNumber.Text;
            string password = maskedTextBoxPassword.Text;

            var dataAccess = new DataAccess("./database.db");

            // Проверяем, что пользователь существует и пароль верный
            if (dataAccess.AuthenticateUser(phoneNumber, password))
            {
                maskedTextBoxPhoneNumber.Clear();
                maskedTextBoxPassword.Clear();

                this.toResutuarantMenu();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации. Проверьте введенные данные.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.toRegistration();
        }
    }
}
