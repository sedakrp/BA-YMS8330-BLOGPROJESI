﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.Context;
using Blog.Data.Dto;
using Blog.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class UserController : Controller

    {

        private readonly blogContext _blogContext;
        public UserController(blogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginAction([FromBody]UserLoginDto userLogin)
        {
        if (!ModelState.IsValid)
	        {
            return BadRequest("Invalid Validation");

	        }
            User user = _blogContext.Users.SingleOrDefault(a => !a.Deleted && a.Password == userLogin.Password);
            if (user !=null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);


                return Ok(user);
            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpGet]//cıkıs yapma
        public IActionResult LogoutAction()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

       
    }
}