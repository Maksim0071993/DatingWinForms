using DatingApp.BusinesLogic.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface ISearchService
    {
        public List<ProfileModel> SearchUserToProfile(string firstName, int? ageFrom, int? ageTo, string city, int? sex, int? orientation);

    }
}
