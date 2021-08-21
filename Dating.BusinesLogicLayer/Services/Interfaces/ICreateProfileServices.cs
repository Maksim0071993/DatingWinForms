using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BusinesLogicLayer.Services.Interfaces
{
    public interface ICreateProfileServices
    {
        public void CreateProfile(string firstName, string lastName, int age, int sex, int orientation, string aboutMe, string city);
    }
}
