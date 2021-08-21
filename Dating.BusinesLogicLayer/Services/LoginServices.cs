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
    public class LoginServices : ILoginServices
    {
        private ILoginRepository _loginRepository;
        private DatingWinFormsContext _datingWinFormsContex;

        public LoginServices()
        {
            _datingWinFormsContex = new DatingWinFormsContext();
            _loginRepository = new LoginRepository(_datingWinFormsContex);
        }
        public bool SearchUser(string email, string password)
        {
            return _loginRepository.SearchUser(email, password);    
        }
    }
}
