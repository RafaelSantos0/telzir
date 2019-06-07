using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FaleMais.Models
{
    public class FaleMaisContext : DbContext
    {
        public FaleMaisContext (DbContextOptions<FaleMaisContext> options)
            : base(options)
        {
        }

        public DbSet<Plane> Plane { get; set; }
    }
}
