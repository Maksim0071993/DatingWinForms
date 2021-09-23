using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatingAppWinFormsContext datingAppWinFormsContext = new DatingAppWinFormsContext();
        private RegistrationRepository registrationRepository;
        private ProfileRepository profileRepository;
        private ChatRepository messageRepository;

        public RegistrationRepository Registration
        {
            get
            {
                if (registrationRepository == null)
                    registrationRepository = new RegistrationRepository(datingAppWinFormsContext);
                return registrationRepository;
            }
        }
        public ProfileRepository Profile
        {
            get
            {
                if (profileRepository == null)
                    profileRepository = new ProfileRepository(datingAppWinFormsContext);
                return profileRepository;
            }
        }
        public ChatRepository Chat
        {
            get
            {
                if (messageRepository == null)
                    messageRepository = new ChatRepository(datingAppWinFormsContext);
                return messageRepository;
            }
        }
        public void Save()
        {
            datingAppWinFormsContext.SaveChanges();
        }
    }
}
