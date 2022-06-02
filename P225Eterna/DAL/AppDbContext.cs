using Microsoft.EntityFrameworkCore;
using P225Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<FeatureItem> FeatureItems { get; set; }
        public DbSet<PlanFeature> PlanFeatures { get; set; }
    }
}
