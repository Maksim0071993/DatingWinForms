using Dating.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Dating.Models
{
    public class Profile
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public SexualOrientations SexualOrientation { get; set; }
        public string AboutMe { get; set; }
        public string Image { get; set; }

    }
}
