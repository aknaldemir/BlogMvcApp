using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Dal.Mapping
{
    public class CategoryMapping:EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            //Table Name:
            ToTable("Categories");

            Property(i => i.CategoryName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            HasKey(i => i.CategoryId);

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
