using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrownbagSession1.Models;
using Microsoft.EntityFrameworkCore;

namespace BrownbagSession1.Data
{
    public class BrownbagSessionDbContext : DbContext
    {
        public BrownbagSessionDbContext(DbContextOptions<BrownbagSessionDbContext> options)
            : base(options)
        {

        }

        public DbSet<Candidate> Candidate { get; set; }

    }
}
