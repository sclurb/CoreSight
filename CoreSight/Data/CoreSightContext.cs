using CoreSight.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSight.Data
{
    public class CoreSightContext : DbContext
    {

        public CoreSightContext(DbContextOptions<CoreSightContext> options): base(options)
        {

        }
        public DbSet<Readings> Readings { get; set; }
    }
}
