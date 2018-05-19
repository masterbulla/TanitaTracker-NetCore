﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebNetCore.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = "List of Users";
            return View();
        }

        public IActionResult Roles()
        {
            throw new NotImplementedException();
        }

        public IActionResult Permissions()
        {
            throw new NotImplementedException();
        }
    }
}