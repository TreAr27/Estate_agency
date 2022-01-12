using Estate_agency.data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data
{
    public class AppDBContent :DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Apartments> Apartments { get; set; }
        public DbSet<Categorycs> Category { get; set; }
    }
}
