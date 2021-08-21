using System;
using System.Collections.Generic;

#nullable disable

namespace Dating.DataAccessLayer.Models
{
    public partial class RegistrationUsers
    {
        public RegistrationUsers()
        {
            Profiles = new HashSet<Profile>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
