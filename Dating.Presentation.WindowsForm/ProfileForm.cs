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
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void _saveProfileButton_Click(object sender, EventArgs e)
        {
            CreateProfileServices createProfileServices = new CreateProfileServices();
           
                int age = int.Parse(_ageTextBox.Text);
                int sex = _sexComboBox.SelectedIndex;
                int orientation = _orientationComboBox.SelectedIndex;
                
                createProfileServices.CreateProfile(_firstNameTextBox.Text, _lastNameTextBox.Text,age, sex, orientation, _aboutMeTextBox.Text, _cityCreateProfileTextBox.Text);       
        }

        private void _saveProfileButton_Click_1(object sender, EventArgs e)
        {

        }
    }       
}
