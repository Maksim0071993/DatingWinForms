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

namespace Dating.BusinesLogicLayer.Services
{
   public class RegistrationServices : IRegistrationServices
    {
        private IRegistrationRepository _registrationRepository;
        private DatingWinFormsContext _datingWinFormsContext;

        public RegistrationServices()
        {
            _datingWinFormsContext = new DatingWinFormsContext();
            _registrationRepository = new RegistrationRepository(_datingWinFormsContext);
        }
        public void Register(string email, string password)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RegistrationUsersBusinesModel, RegistrationUsers>());
            RegistrationUsersBusinesModel _registrationUsersBusinesModel = new RegistrationUsersBusinesModel()
            {
                Email = email,
                UserPassword = password
            };
            var mapper = new Mapper(config);
            var registrationUserDLL = mapper.Map<RegistrationUsers>(_registrationUsersBusinesModel);
            _registrationRepository.Register(registrationUserDLL);
            _datingWinFormsContext.SaveChanges();
        }
        
    }
}
