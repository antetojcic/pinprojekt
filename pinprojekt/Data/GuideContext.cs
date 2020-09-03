using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pinprojekt.Models;

namespace pinprojekt.Data
{
    public class GuideContext : DbContext
    {
        public GuideContext (DbContextOptions<GuideContext> options)
            : base(options)
        {
        }

        public DbSet<pinprojekt.Models.Guide> Guide { get; set; }
    }
}
