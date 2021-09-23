using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories
{
    public class ProfileRepository : ICreateProfileRepository
    {
        private readonly DatingAppWinFormsContext _datingAppWinFormsContext;

        public ProfileRepository(DatingAppWinFormsContext datingAppWinFormsContext)
        {
            _datingAppWinFormsContext = datingAppWinFormsContext;
        }

        public void Add(Profile profile)
        {
            _datingAppWinFormsContext.Profiles.Add(profile);
        }
        public List<Profile> Get(Func<Profile, bool> func)
        {
            var profiles = _datingAppWinFormsContext.Profiles.Where(func).ToList();
            return profiles;
        }
        public List<Profile> GetAll()
        {
            var profiles = _datingAppWinFormsContext.Profiles.ToList();
            return profiles;
        }
    }
}
