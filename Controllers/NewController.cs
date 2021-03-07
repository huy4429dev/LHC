using Microsoft.AspNetCore.Mvc;
using DVN.Models;
using DVN.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DVN.Controllers
{
    [Route("/tin-tuc")]
    public class NewController : Controller
    {
        private ApplicationDbContext db;

        public NewController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 25)
        {
            var query = db.Posts.Include(item => item.User).AsQueryable();
            var Posts = query
                              .OrderByDescending(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();

            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("/Views/News/Index.cshtml", Posts);
        }

        [HttpGet("tim-kiem")]

        public IActionResult Search(string query, int page = 1, int pageSize = 25)
        {
            var Posts = new List<Post>();
            var sql = db.Posts.Include(item => item.User).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = query.Trim();
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Title, query)
                               );
            }

            Posts = sql.OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            ViewBag.Query = query.Replace("%","");
            return View("/Views/News/Index.cshtml", Posts);
        }

        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            var data = db.Posts.Select(item => new Post
            {
                Content = item.Content,
                Thumbnail = item.Thumbnail,
                Description = item.Description,
                CreatedAt = item.CreatedAt,
                Title = item.Title,
                User = item.User,
                Id = item.Id
            })
            .FirstOrDefault();

            ViewBag.recentPost = db.Posts
                                   .Include(item => item.User)
                                   .Where(item => item.Id != id)
                                   .OrderByDescending(item => item.Id)
                                   .Take(5)
                                   .ToList();
            return View("/Views/News/Detail.cshtml", data);
        }

    }
}