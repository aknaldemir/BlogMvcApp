using System.Collections.Generic;
using Blog.Entities.Concrete;

namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.Dal.Concrete.EntityFramework.NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.Dal.Concrete.EntityFramework.NewsContext context)
        {
           List<Category> categories=new List<Category>()
           {
               new Category(){CategoryName = "Ekonomi",CreatedDate = DateTime.Now.AddDays(-5)},
               new Category(){CategoryName = "Spor",CreatedDate = DateTime.Now.AddDays(-10)},
               new Category(){CategoryName = "Dünya",CreatedDate = DateTime.Now.AddDays(-1)},
               new Category(){CategoryName = "Politika",CreatedDate = DateTime.Now.AddDays(-5)},
               new Category(){CategoryName = "Sağlık",CreatedDate = DateTime.Now.AddDays(-5)},
           };

           context.Categories.AddRange(categories);
           context.SaveChanges();

           List<News> newsList=new List<News>()
           {
               new News(){NewsTitle = "Haber Baslik 1",NewsDescription = "Açıklama 1",NewsBody = "İçerik 1",NewsImage = "1.jpg",CreatedDate = DateTime.Now,IsApproved = true,IsHome = true,IsSlider = true,CategoryId = 1},
               new News(){NewsTitle = "Haber Baslik 2",NewsDescription = "Açıklama 2",NewsBody = "İçerik 2",NewsImage = "2.jpg",CreatedDate = DateTime.Now,IsApproved = true,IsHome = true,IsSlider = true,CategoryId = 2},
               new News(){NewsTitle = "Haber Baslik 3",NewsDescription = "Açıklama 3",NewsBody = "İçerik 3",NewsImage = "3.jpg",CreatedDate = DateTime.Now,IsApproved = true,IsHome = true,IsSlider = true,CategoryId = 3},
               new News(){NewsTitle = "Haber Baslik 4",NewsDescription = "Açıklama 4",NewsBody = "İçerik 4",NewsImage = "4.jpg",CreatedDate = DateTime.Now,IsApproved = true,IsHome = true,IsSlider = true,CategoryId = 4}
           };

           context.NewsList.AddRange(newsList);
           context.SaveChanges();

           List<User> users=new List<User>()
           {
               new User(){FirstName = "Akın",LastName = "Aldemir",Email = "akinaldemir@gmail.com",Password = "1234",CreatedDate = DateTime.Now},
               new User(){FirstName = "İsmail",LastName = "Devlez",Email = "ismaildevlez@gmail.com",Password = "1234",CreatedDate = DateTime.Now},
           };

           context.Users.AddRange(users);
           context.SaveChanges();



        }
    }
}
