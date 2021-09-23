using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.DataModels;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services
{
    public class SearchService : ISearchService
    {
        
        public List<ProfileModel> SearchUserToProfile(string firstName, int? ageFrom, int? ageTo, string city, int? sex, int? orientation)
        {
            IUnitOfWork _unitOfWork = new UnitOfWork();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<DataAccessLayer.Models.Profile, ProfileModel>());
            var mapper = new Mapper(config);
            var loginUsers = _unitOfWork.Profile.Get(x => x.FirstName == firstName || (x.Age >= ageFrom && x.Age <= ageTo) || x.City == city || x.Sex == sex || x.Orientation == orientation).ToList();
            var result = loginUsers.Select(p => mapper.Map<ProfileModel>(p)).ToList();
            return result;
        }
    }
}
