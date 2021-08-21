using System;
using System.Collections.Generic;

#nullable disable

namespace Dating.DataAccessLayer.Models
{
    public partial class Profile
    {
        public Profile()
        {
            ChatRecipients = new HashSet<Chat>();
            ChatSenders = new HashSet<Chat>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public int? Orientation { get; set; }
        public string AboutMe { get; set; }
        public int? RegistrationUsersId { get; set; }
        public string City { get; set; }

        public virtual RegistrationUsers RegistrationUsers { get; set; }
        public virtual ICollection<Chat> ChatRecipients { get; set; }
        public virtual ICollection<Chat> ChatSenders { get; set; }
    }
}
