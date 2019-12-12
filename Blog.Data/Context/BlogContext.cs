

using Blog.Data.Enums;
using Blog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Data.Context
{
    public class blogContext : DbContext
    {
        public blogContext(DbContextOptions<blogContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog.Data.Models.Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Site> Sites { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 1,
                   CreateDate = DateTime.UtcNow,
                   Deleted = false,
                   Name = "Aşk",
                   Description = "...."
               });
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 2,
                   CreateDate = DateTime.UtcNow,
                   Deleted = false,
                   Name = "Meşk",
                   Description = "!!!!"
               });

            modelBuilder.Entity<Nationality>().HasData(new Nationality()
            {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Name = "Türkiye",
                Code = "tr"



            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Username = "seda",
                Name = "Seda",
                Surname = "Korpe",
                Email = "sedakrpe@gmail.com",
                Password = "11223344",
                BirthDate = new DateTime(1990, 07, 29),
                Gender = Gender.Male,
                NationalityId = 1


            });
            modelBuilder.Entity<Site>().HasData(new Site()
            {
                Id=1,
                Title = "Seda Körpe",
                Desctription = ".......",
                Slogan = "Sayfama Hoşgeldiniz...",
                Copyright = "içerik hırsızlığına hayıııırrrr..."

            });
            base.OnModelCreating(modelBuilder);




        }
    }
}


