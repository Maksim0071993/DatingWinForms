using Dating.DataAccessLayer.Models;
using Dating.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DataAccessLayer.Repositories
{
   public class RegistrationRepository : IRegistrationRepository
    {
        private DatingWinFormsContext _datingWinFormsContext;

        public RegistrationRepository(DatingWinFormsContext datingWinFormsContext)
        {
            _datingWinFormsContext = datingWinFormsContext;
        }

        public void Register(RegistrationUsers _registrationUser)
        {
            _datingWinFormsContext.RegistrationUsers.Add(_registrationUser);
        }
    }
}
