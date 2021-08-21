using Dating.BusinesLogicLayer.Services;
using Dating.DataAccessLayer.Models;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            LoginServices _loginServices = new LoginServices();
            SearchForm searchForm = new SearchForm();
            RegistrationForm registrationForm = new RegistrationForm();
            if (_loginServices.SearchUser(_emailLoginTextBox.Text, _passwordLoginTextBox.Text))
            {
                this.Close();
                searchForm.Show();
            }
            else
            {
                this.Close();
                registrationForm.Show();
            }
        }
    }
}
