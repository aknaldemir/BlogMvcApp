using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Dal.Mapping
{
    public class TagMapping: EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            ToTable("Tags");
            
            HasKey(i => i.TagId);

            //many to many relation
            HasMany(i => i.NewsList)
                .WithMany(i => i.Tags)
                .Map(at =>
                {
                    at.MapLeftKey("NewsId");
                    at.MapRightKey("TagId");
                    at.ToTable("Tag_News");
                });

            Property(i => i.TagName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

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
