using DatingApp.BusinesLogic.BusinessModel;
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
    public partial class CreateProfileForm : Form
    {
        int userId;
        public CreateProfileForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }


        private void _saveProfileButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(_ageTextBox.Text);
            ProfileService profileService = new ProfileService();
            SearchForm searchForm = new SearchForm();
            CorrespondenceForm correspondenceForm = new CorrespondenceForm(this.userId);
            if (_firstNameTextBox.Text != null && _sexComboBox.Text != null && _ageTextBox.Text != "" && _cityCreateProfileTextBox.Text != null)
            {

                ProfileModel profileModel = new ProfileModel()
                {
                    Id = this.userId,
                    FirstName = _firstNameTextBox.Text,
                    LastName = _lastNameTextBox.Text,
                    Age = age,
                    Sex = 1,
                    Orientation = 1,
                    AboutMe = _aboutMeTextBox.Text,
                    City = _cityCreateProfileTextBox.Text
                };
                profileService.CreateProfile(profileModel);
                this.Hide();
                //searchForm.Show();
                correspondenceForm.Show();
            }
            else
            {
                MessageBox.Show("Fields First Name, Age, City, Sex must be filled");
            }

        }
    }       
}
