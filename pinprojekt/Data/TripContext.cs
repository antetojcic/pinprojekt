using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pinprojekt.Models;

namespace pinprojekt.Data
{
    public class TripContext : DbContext
    {
        public TripContext (DbContextOptions<TripContext> options)
            : base(options)
        {
        }

        public DbSet<pinprojekt.Models.Trip> Trip { get; set; }
        public DbSet<pinprojekt.Models.Guide> Guide { get; set; }

    }
}
