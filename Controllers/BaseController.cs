using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;
using DVN.Extension;

namespace DVN.Admin.Controllers
{
    public class BaseController : Controller
    {

        private readonly ApplicationDbContext db;
        private UserService userService;
         
        public User user;

        public BaseController(ApplicationDbContext db, UserService userService)
        {
            this.db = db; 
            this.userService = userService; 
            user = userService.IsUserLoggedIn();
        }

    }
}