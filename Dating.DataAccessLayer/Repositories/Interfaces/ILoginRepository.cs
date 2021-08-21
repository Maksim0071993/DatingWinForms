using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DataAccessLayer.Repositories.Interfaces
{
    public interface ILoginRepository
    {
         bool SearchUser(string email, string password);
    }
}
