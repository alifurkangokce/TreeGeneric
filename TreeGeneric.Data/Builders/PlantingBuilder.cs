using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
   public class PlantingBuilder
    {
        public PlantingBuilder(EntityTypeConfiguration<Planting> entity)
        {
            entity.Property(p => p.Lat).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Long).IsRequired().HasMaxLength(200);
            entity.Property(p => p.PlantingCode).IsRequired().HasMaxLength(200);
            entity.HasRequired(p => p.PlanterUser).WithMany(m => m.Plantings).HasForeignKey(p => p.PlanterUserId);
            entity.HasRequired(p => p.Donation).WithMany(m => m.Plantings).HasForeignKey(p => p.DonationId);
        }
    }
}
