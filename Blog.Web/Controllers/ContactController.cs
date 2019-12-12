﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.Context;
using Blog.Data.Dto;
using Blog.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly blogContext _blogContext;
        
        public ContactController(blogContext blogContext)
        {
            _blogContext = blogContext;
        
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Send([FromBody] ContactSendDto contactSend )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _blogContext.Contacts.Add(new Contact()
            {
                Name = contactSend.Name,
                Surname = contactSend.Surname,
                Message = contactSend.Message,
                CreateDate = DateTime.UtcNow



            });
            _blogContext.SaveChanges();


            return new JsonResult("ok");
        }
    }
}