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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            LoginService _loginService = new LoginService();
            SearchForm searchForm = new SearchForm();
            
            RegistrationForm registrationForm = new RegistrationForm();
            var result = _loginService.SearchUser(_emailLoginTextBox.Text, _passwordLoginTextBox.Text);
            CorrespondenceForm correspondenceForm = new CorrespondenceForm(result.UserId);
            if (result != null)
            {
                this.Close();
                correspondenceForm.Show();
                //searchForm.Show();
            }
            else
            {
                this.Close();
                registrationForm.Show();
            }
        }
    }
}
