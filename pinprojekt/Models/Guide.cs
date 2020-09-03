using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pinprojekt.Models
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Rating { get; set; }

        public ICollection<Trip> Group { get; set; }

    }
}
