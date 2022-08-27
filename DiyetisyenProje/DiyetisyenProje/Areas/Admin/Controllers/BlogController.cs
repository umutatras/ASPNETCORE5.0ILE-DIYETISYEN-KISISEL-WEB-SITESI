using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace DiyetisyenProje.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        private readonly IWebHostEnvironment _he;

        public BlogController(IWebHostEnvironment he)
        {
            _he = he;
        }

        public IActionResult Index()
        {
            var values = blogManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Blog blog)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (blog.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, blog.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                blog.Image = @"\resim\" + filename + ext;
            }
            blogManager.TAdd(blog);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values=blogManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Blog blog)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (blog.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, blog.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                blog.Image = @"\resim\" + filename + ext;
            }
            blogManager.TUpdate(blog);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var values=blogManager.TGetById(id);
            blogManager.TDelete(values);
            return RedirectToAction("Index");   
        }
    }
}
