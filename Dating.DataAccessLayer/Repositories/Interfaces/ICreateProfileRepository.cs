using Dating.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DataAccessLayer.Repositories.Interfaces
{
    public interface ICreateProfileRepository
    {
        public void CreateProfile(Profile _profile);
    }
}
