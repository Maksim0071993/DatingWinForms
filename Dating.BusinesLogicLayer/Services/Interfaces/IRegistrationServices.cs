using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BusinesLogicLayer.Services.Interfaces
{
    public interface IRegistrationServices
    {
        public void Register(string email, string password);
    }
}
