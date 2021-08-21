using AutoMapper;
using Dating.BusinesLogicLayer.BusinesModels;
using Dating.BusinesLogicLayer.Services.Interfaces;
using Dating.DataAccessLayer.Models;
using Dating.DataAccessLayer.Repositories;
using Dating.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profile = Dating.DataAccessLayer.Models.Profile;

namespace Dating.BusinesLogicLayer.Services
{
    public class CreateProfileServices : ICreateProfileServices
    {
        private ICreateProfileRepository _createProfileRepository;
        private DatingWinFormsContext _datingWinFormsContext;


        public CreateProfileServices()
        {
            _datingWinFormsContext = new DatingWinFormsContext();
            _createProfileRepository = new CreateProfileRepository(_datingWinFormsContext);
        }
        public void CreateProfile(string firstName, string lastName, int age, int sex, int orientation, string aboutMe, string city)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CreateProfileBusinesModel, Profile>());

            CreateProfileBusinesModel _createProfileBusinesModel = new CreateProfileBusinesModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Sex = sex,
                Orientation = orientation,
                AboutMe = aboutMe,
                City = city
            };
            var mapper = new Mapper(config);
            var profileDLL = mapper.Map<Profile>(_createProfileBusinesModel);
            _createProfileRepository.CreateProfile(profileDLL);
            _datingWinFormsContext.SaveChanges();
        }
    }
}
