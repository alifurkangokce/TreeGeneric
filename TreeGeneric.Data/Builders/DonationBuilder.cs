using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
   public class DonationBuilder
    {
        public DonationBuilder(EntityTypeConfiguration<Donation> entity)
        {
            entity.Property(d => d.Owner).IsRequired().HasMaxLength(200);
            entity.Property(d => d.UpdatedBy).HasMaxLength(4000);
            entity.HasRequired(r => r.Region).WithMany(d => d.Donations).HasForeignKey(r => r.RegionId);
            entity.HasRequired(t => t.TreeType).WithMany(d => d.Donations).HasForeignKey(t => t.TreeTypeId);
        }
    }
}
