﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Data.Migrations
{
    [DbContext(typeof(blogContext))]
    [Migration("20191128180440_Category")]
    partial class Category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Data.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<int>("Hit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Blog.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CreateDate = new DateTime(2019, 11, 28, 18, 4, 40, 308, DateTimeKind.Utc), Deleted = false, Description = "....", Name = "Aşk" },
                        new { Id = 2, CreateDate = new DateTime(2019, 11, 28, 18, 4, 40, 309, DateTimeKind.Utc), Deleted = false, Description = "!!!!", Name = "Meşk" }
                    );
                });

            modelBuilder.Entity("Blog.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .HasMaxLength(320);

                    b.Property<string>("Nickname")
                        .HasMaxLength(50);

                    b.Property<int?>("UserId");

                    b.Property<int>("VoteDown");

                    b.Property<int>("Voteup");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Blog.Data.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Blog.Data.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Nationality");

                    b.HasData(
                        new { Id = 1, Code = "tr", CreateDate = new DateTime(2019, 11, 28, 18, 4, 40, 309, DateTimeKind.Utc), Deleted = false, Name = "Türkiye" }
                    );
                });

            modelBuilder.Entity("Blog.Data.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("PageKind");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Blog.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320);

                    b.Property<int>("Gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("NationalityId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, BirthDate = new DateTime(1990, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), CreateDate = new DateTime(2019, 11, 28, 18, 4, 40, 309, DateTimeKind.Utc), Deleted = false, Email = "sedakrpe@gmail.com", Gender = 1, Name = "Seda", NationalityId = 1, Password = "11223344", Surname = "Korpe", Username = "seda" }
                    );
                });

            modelBuilder.Entity("Blog.Data.Models.Blog", b =>
                {
                    b.HasOne("Blog.Data.Models.Blog")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogId");

                    b.HasOne("Blog.Data.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Data.Models.Comment", b =>
                {
                    b.HasOne("Blog.Data.Models.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Blog.Data.Models.User", b =>
                {
                    b.HasOne("Blog.Data.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");
                });
#pragma warning restore 612, 618
        }
    }
}
