using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Net.Http.Headers;
using DVN.Models;
using System.Security.Claims;
using DVN.ViewModels;
using System.Collections.Generic;

namespace DVN.Admin.Controllers
{
    [Route("admin/post")]
    public class PostController : Controller
    {
        private ApplicationDbContext db;

        public PostController(
            ApplicationDbContext context
        )
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await db.Posts.OrderByDescending(item => item.Id)
                                .Select(item => new PostIndexViewModel
                                {
                                    Id = item.Id,
                                    Title = item.Title,
                                    Description = item.Description,
                                    Author = item.User.FullName,
                                    CreatedAt = item.CreatedAt,

                                }).ToListAsync();
            return View("Views/Admin/Post/Index.cshtml", posts);
        }

        [HttpGet("search")]
        public IActionResult SearchEmail(string query, DateTime? fillDate, int page = 1, int pageSize = 25)
        {
            var Posts = new List<PostIndexViewModel>();
            var sql = db.Posts.Include(item => item.User).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(query))
            {
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Title, query) ||
                                      EF.Functions.ILike(item.User.FullName, query)
                               );
            }

            if (fillDate.HasValue)
            {
                sql = sql.Where(item => item.CreatedAt == fillDate);
            }

            Posts = sql
                     .Select(item => new PostIndexViewModel
                     {
                         Id = item.Id,
                         Title = item.Title,
                         Description = item.Description,
                         Author = item.User.FullName,
                         CreatedAt = item.CreatedAt
                     })
                     .OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/Post/Index.cshtml", Posts);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {

            return View("Views/Admin/Post/Create.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("upload-thumbnail"), DisableRequestSizeLimit]
        public IActionResult UploadThumbnail()
        {
            try
            {

                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "uploads");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var now = DateTime.Now.Ticks.ToString();
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var typeFile = fileName.Substring(fileName.LastIndexOf("."));
                    fileName = fileName.Substring(0, fileName.Length - typeFile.Length) + now + typeFile;
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    dbPath = dbPath.Substring(7);

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server errors {e}");
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromForm] Post model)
        {


            if (ModelState.IsValid)
            {

                model.UserId = 2;
                model.CreatedAt = DateTime.Now;
                await db.Posts.AddAsync(model);
                await db.SaveChangesAsync();
                return Redirect("/admin/Post");
            }


            return View("Views/Admin/Post/Create.cshtml");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail(int id)
        {

            var post = await db.Posts.Where(i => i.Id == id).Select(p => new Post
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Content = p.Content,
                Thumbnail = p.Thumbnail,
                CreatedAt = p.CreatedAt,
                UpdatedAt = p.UpdatedAt,
                UserId = p.UserId
            }).FirstAsync();
            if (post != null)
            {
                return View("Views/Admin/Post/Detail.cshtml", post);
            }

            return BadRequest("Không tồn tại bài viết");

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromForm] Post model, int id)
        {

            var post = await db.Posts.FindAsync(id);

            //  id not found --> err

            if (post != null)
            {
                if (ModelState.IsValid)
                {
                    post.Title = model.Title;
                    post.Description = model.Description;
                    post.Content = model.Content;
                    post.Thumbnail = model.Thumbnail;
                    post.UserId = 2;
                    post.UpdatedAt = DateTime.Now;
                    await db.SaveChangesAsync();
                }
                ViewBag.message = "Cập nhật thành công";
                return View("Views/Admin/Post/Detail.cshtml", post);
            }


            return BadRequest("Không tồn tại bài viết");
        }
    }

}