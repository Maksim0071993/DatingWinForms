using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.BusinessModel
{
    public class ProfileModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public int? Orientation { get; set; }
        public string AboutMe { get; set; }
        public int? RegistrationUsersId { get; set; }
        public string City { get; set; }
        public int Id { get; set; }
    }
}
