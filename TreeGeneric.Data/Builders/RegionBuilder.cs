using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class RegionBuilder
    {
        public RegionBuilder(EntityTypeConfiguration<Region> entity)
        {
            entity.Property(r => r.Name).IsRequired().HasMaxLength(200);
            entity.Property(r => r.Photo).IsRequired().HasMaxLength(2000);
            entity.Property(r => r.Lat).IsRequired().HasMaxLength(200);
            entity.Property(r => r.Long).IsRequired().HasMaxLength(200);

        }
    }
}
