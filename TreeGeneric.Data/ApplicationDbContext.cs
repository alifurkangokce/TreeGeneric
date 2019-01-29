using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data.Builders;
using TreeGeneric.Model;

namespace TreeGeneric.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Planting> Plantings { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<TreeType> TreeTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PostBuilder(modelBuilder.Entity<Post>());
            new DonationBuilder(modelBuilder.Entity<Donation>());
            new PlantingBuilder(modelBuilder.Entity<Planting>());
            new RegionBuilder(modelBuilder.Entity<Region>());
            new TreeTypeBuilder(modelBuilder.Entity<TreeType>());
            new UserBuilder(modelBuilder.Entity<User>());

        }
    }

}
