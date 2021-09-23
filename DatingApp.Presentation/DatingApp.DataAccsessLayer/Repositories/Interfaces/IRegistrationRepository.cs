using DatingApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
   public interface IRegistrationRepository
    {
        public void Add(RegistrationUser registrationUser);
    }
}
