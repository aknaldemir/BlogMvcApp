using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Dal.Mapping
{
    public class UserMapping:EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("Users");

            HasKey(i => i.UserId);

            Property(i => i.FirstName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar");

            Property(i => i.LastName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar");


            Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar");


            Property(i => i.Password)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("nvarchar");

            Property(i => i.CreatedDate)
                .IsRequired()
                .HasColumnType("date");

            Property(i => i.UpdatedDate)
                .IsOptional()
                .HasColumnType("date");

            Property(i => i.DeletedDate)
                .IsOptional()
                .HasColumnType("date");



        }
    }
}
