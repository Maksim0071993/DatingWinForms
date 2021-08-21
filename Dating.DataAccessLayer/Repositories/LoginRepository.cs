using Dating.DataAccessLayer.Models;
using Dating.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DataAccessLayer.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private DatingWinFormsContext _datingWinFormsContext;

        public LoginRepository(DatingWinFormsContext datingWinFormsContext)
        {
            _datingWinFormsContext = datingWinFormsContext;
        }

        public bool SearchUser(string email, string password)
        {        
            var registrationUsers = _datingWinFormsContext.RegistrationUsers.Where(p => p.Email == email && p.UserPassword == password).FirstOrDefault();
            return registrationUsers != null;
        }
    }
}
