using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class Profile
    {
        public Profile()
        {
            ChatRecepients = new HashSet<Chat>();
            ChatSenders = new HashSet<Chat>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public int? Orientation { get; set; }
        public string City { get; set; }
        public string AboutMe { get; set; }

        public virtual RegistrationUser IdNavigation { get; set; }
        public virtual ICollection<Chat> ChatRecepients { get; set; }
        public virtual ICollection<Chat> ChatSenders { get; set; }
    }
}
