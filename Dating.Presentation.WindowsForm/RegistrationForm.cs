using Dating.BusinesLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dating.Presentation.WindowsForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void _registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationServices registrationServices = new RegistrationServices();
            if(_passwordRegistrationTextBox.Text == _confirmPasswordRegistrationTextBox.Text)
            {
                registrationServices.Register(_eMailRegistrationTextBox.Text, _passwordRegistrationTextBox.Text);
                CreateProfileForm _createProfileForm = new CreateProfileForm();
                this.Hide();
                _createProfileForm.Show();
            }
            else
            {
                MessageBox.Show("Password mismatch");
            }
        }

        private void _goToLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm _loginForm = new LoginForm();
            this.Hide();
            _loginForm.Show();
        }
    }
}
