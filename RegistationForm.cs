namespace CursovaySonin2024
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void redirectToLoginForm()
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonRegistation_Click(object sender, EventArgs e)
        {
            string phoneNumber = maskedTextBoxPhoneNumber.Text;
            string password = maskedTextBoxPassword.Text;

            var dataAccess = new DataAccess("./database.db");

            if (dataAccess.RegisterUser(phoneNumber, password))
            {
                MessageBox.Show("Регистрация прошла успешно!");

                maskedTextBoxPhoneNumber.Clear();
                maskedTextBoxPassword.Clear();

                this.redirectToLoginForm();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации. Проверьте введенные данные. Возможно аккаунт на такой номер уже зарегистрирован.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.redirectToLoginForm();
        }
    }
}