using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services
{
    public class RegistrationService : IRegistrationService
    {
        IUnitOfWork unitOfWork = new UnitOfWork();

        public int Register(string email, string password)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RegistrationModel, RegistrationUser>());
            RegistrationModel _registrationUsersBusinesModel = new RegistrationModel()
            {
                Email = email,
                UserPassword = password
            };
            var mapper = new Mapper(config);
            var registrationUserDLL = mapper.Map<RegistrationUser>(_registrationUsersBusinesModel);
            unitOfWork.Registration.Add(registrationUserDLL);
            unitOfWork.Save();
            return registrationUserDLL.UserId;
        }

    }
}
