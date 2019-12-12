using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Dal.Mapping
{
    public class NewsMapping:EntityTypeConfiguration<News>
    {
        public NewsMapping()
        {
            //Table Name:
            ToTable("News");
            //Foreign Key:
            HasRequired(i=>i.Category)      
                .WithMany(i=>i.NewsList)    
                .HasForeignKey(i=>i.CategoryId)
                .WillCascadeOnDelete();

            Property(i => i.NewsBody)
                .IsRequired()
                .HasColumnType("text");

            Property(i => i.NewsDescription)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(200);

            HasKey(i => i.NewsId);

            Property(i => i.NewsImage)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            Property(i => i.NewsTitle)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

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
