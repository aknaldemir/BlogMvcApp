using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Dal.Mapping
{
    public class CommentMapping:EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            ToTable("Comments");

            HasKey(i => i.CommentId);

            HasRequired(i => i.User)
                .WithMany(i => i.Comments)
                .HasForeignKey(i => i.UserId);

            HasRequired(i => i.News)
                .WithMany(i => i.Comments)
                .HasForeignKey(i => i.NewsId);

            Property(i => i.CommentText)
                .IsRequired()
                .HasMaxLength(500)
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
