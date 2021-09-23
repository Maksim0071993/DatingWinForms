using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        RegistrationRepository Registration { get; }
        ProfileRepository Profile { get; }
        ChatRepository Chat { get; }
        void Save();
    }
}
