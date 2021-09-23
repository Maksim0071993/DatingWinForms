using DatingApp.BusinesLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.Presentation.WindowsForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void _registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationService registrationService = new RegistrationService();
            if (_passwordRegistrationTextBox.Text == _confirmPasswordRegistrationTextBox.Text)
            {
                int id = registrationService.Register(_eMailRegistrationTextBox.Text.TrimEnd(), _passwordRegistrationTextBox.Text.TrimEnd());
                CreateProfileForm _createProfileForm = new CreateProfileForm(id);
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
