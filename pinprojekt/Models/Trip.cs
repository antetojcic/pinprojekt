using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pinprojekt.Models
{
    public class Trip
    {
        public int TripID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Price { get; set; }
        public string Duration { get; set; }
        public int GuideID { get; set; }


    }
}
