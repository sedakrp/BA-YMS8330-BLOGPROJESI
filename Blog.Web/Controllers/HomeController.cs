using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private blogContext _blogContext;
        public HomeController(blogContext blogContext)
        {
            _blogContext = blogContext;    
        }
        public IActionResult Index()
        {
            List<Blog.Data.Models.Blog> blogs = _blogContext.Blogs.Include(a =>a.User)
                .OrderByDescending(a => a.CreateDate).ToList();

            return View(blogs);
        }
    }
}