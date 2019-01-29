using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
   public class UserBuilder
    {
        public UserBuilder(EntityTypeConfiguration<User> entity)
        {
            entity.Property(u => u.FirstName).IsRequired().HasMaxLength(200);
            entity.Property(u => u.LastName).IsRequired().HasMaxLength(200);
            entity.Property(u => u.Email).IsRequired().HasMaxLength(200);
            entity.Property(u => u.Password).IsRequired().HasMaxLength(200);
            entity.Property(u => u.EmailConfirmationCode).HasMaxLength(200);
            entity.Property(u => u.Phone).IsRequired().HasMaxLength(200);
        }
    }
}
