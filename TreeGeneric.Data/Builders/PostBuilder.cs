using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class PostBuilder
    {
        public PostBuilder(EntityTypeConfiguration<Post> entity)
        {
            entity.Property(p => p.Photo).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Description).HasMaxLength(4000);
            entity.HasRequired(p => p.Planting).WithMany(a => a.Posts).HasForeignKey(p => p.PlantingId);

        }
    }
}
