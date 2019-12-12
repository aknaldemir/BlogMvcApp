using System.Data.Entity;
using Blog.Dal.Mapping;
using Blog.Entities.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Dal.Concrete.EntityFramework
{
    public class NewsContext:DbContext
    {
        public NewsContext():base("BlogConnection")
        {
            
        }
        public DbSet<News> NewsList { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NewsMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new TagMapping());
            modelBuilder.Configurations.Add(new UserMapping());
        }
    }
}