using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RFC.Models;

namespace RFC.Models
{
    public class RFCContext : DbContext
    {
        public RFCContext (DbContextOptions<RFCContext> options)
            : base(options)
        {
        }

        public DbSet<RFC.Models.CreateNew> CreateNew { get; set; }

        public DbSet<RFC.Models.User> User { get; set; }
    }
}
