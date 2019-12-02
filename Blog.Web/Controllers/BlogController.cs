﻿using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _blogContext;
        public BlogController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public IActionResult New()
        {
            List<Data.Models.Category> categories = _blogContext.Categories.Where(a => !a.Deleted).ToList();

            return View(categories);
        }

        public IActionResult Add([FromBody] BlogAddDto blogAdd)
        {
            int userId = HttpContext.Session.GetInt32("UserId").Value;

            Blog.Data.Models.Blog blog = new Blog.Data.Models.Blog()
            {
                UserId = userId,
                Title = blogAdd.Title,
                Content = blogAdd.Content,
                CreateDate=DateTime.UtcNow,
                Hit=0,
                Deleted=false,
                CategoryId=blogAdd.CategoryId

            };

            _blogContext.Blogs.Add(blog);
            _blogContext.SaveChanges();
            return Ok();
        }
        public IActionResult Detail(int id)//blogun ıdsi olacak
        {
            var blog = _blogContext.Blogs.Find(id);
            return View(blog);
        }
    }
}