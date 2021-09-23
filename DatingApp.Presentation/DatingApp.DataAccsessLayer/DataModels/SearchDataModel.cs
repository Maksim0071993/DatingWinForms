using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.DataModels
{
   public class SearchDataModel
    {
        public string FirstName { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string City { get; set; }
        public int Sex { get; set; }
        public int Orientation { get; set; }
    }
}
