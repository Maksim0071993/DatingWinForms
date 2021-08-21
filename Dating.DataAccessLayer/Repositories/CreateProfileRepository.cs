using Dating.DataAccessLayer.Models;
using Dating.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DataAccessLayer.Repositories
{
    public class CreateProfileRepository : ICreateProfileRepository
    {
        private DatingWinFormsContext _datingWinFormsContext;

        public CreateProfileRepository(DatingWinFormsContext datingWinFormsContext)
        {
            _datingWinFormsContext = datingWinFormsContext;
        }

        public void CreateProfile(Profile _profile)
        {
            _datingWinFormsContext.Profiles.Add(_profile);
        }   
    }
}
