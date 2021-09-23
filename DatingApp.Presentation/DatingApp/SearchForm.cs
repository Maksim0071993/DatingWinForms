using DatingApp.BusinesLogic.Services;
using DatingApp.DataAccessLayer.Repositories;
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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            _listBoxAfterSearch.Items.Clear();
        }

        private void _searchButton_Click(object sender, EventArgs e)
        {
            _listBoxAfterSearch.Items.Clear();
            int ageFrom;
            int ageTo;
            SearchService _searchService = new SearchService();
            if (_ageFromSearchTextBox.Text != "" || _ageToSearchTextBox.Text != "")
            {
                 ageFrom = int.Parse(_ageFromSearchTextBox.Text);
                 ageTo = int.Parse(_ageToSearchTextBox.Text);
            }
            else
            {
                ageFrom = 0;
                ageTo = 999;
            }
            
            
           var resultSearch = _searchService.SearchUserToProfile(_firstNameSearchTextBox.Text, ageFrom, ageTo, _citySearchTextBox.Text, _sexSearchComboBox.SelectedIndex, _orientationSearchComboBox.SelectedIndex);
            ;
            for (int i = 0; i < resultSearch.Count; i++)
            {
                _listBoxAfterSearch.Items.Add(resultSearch[i].FirstName);
            }
            
        }
    }
}
