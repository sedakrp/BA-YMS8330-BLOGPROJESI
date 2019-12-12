using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.Context;
using Blog.Data.Enums;
using Blog.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class AboutUsController : Controller
    {
        public readonly blogContext _blogContext;

        public AboutUsController(blogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public IActionResult Index()
        {
            Page page = _blogContext.Pages.FirstOrDefault(a => !a.Deleted && a.PageKind == PageKind.About);
            return View(page);
        }
    }
}