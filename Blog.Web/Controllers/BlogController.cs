using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return Ok(blog);
        }
        public IActionResult Detail(int id)//blogun ıdsi olacak
        {
            Data.Models.Blog blog = _blogContext.Blogs
                .Include(a =>a.User)
                .Include(a=>a.Comments)
                .SingleOrDefault(a=> a.Id== id);
            return View(blog);
        }
        public IActionResult AddComment([FromBody]BlogAddCommentDto blogAddComment)
        {
            Data.Models.Comment blog = new Data.Models.Comment()
            {
                BlogId =blogAddComment.BlogId,
                CreateDate = DateTime.UtcNow,
                Content = blogAddComment.Comment,
                Deleted = false,
                Email = blogAddComment.Email,
                Nickname = blogAddComment.Nickname,
                ParentCommentId =blogAddComment.ParetnCommentId,
                Voteup = 0,
                VoteDown = 0
            };
            _blogContext.Comments.Add(blog);
            _blogContext.SaveChanges();
            return new JsonResult("ok");
        }
    }
}