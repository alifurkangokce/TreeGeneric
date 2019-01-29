using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class TreeTypeBuilder
    {
        public TreeTypeBuilder(EntityTypeConfiguration<TreeType> entity)
        {
            entity.Property(t => t.Name).IsRequired().HasMaxLength(200);
            entity.Property(t => t.Photo).IsRequired().HasMaxLength(2000);
            entity.HasRequired(p => p.Region).WithMany(t => t.TreeTypes).HasForeignKey(p => p.RegionId).WillCascadeOnDelete(false);
        }
    }
}
