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
    public class AdminAboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        private readonly IWebHostEnvironment _he;

        public AdminAboutController(IWebHostEnvironment he)
        {
            _he = he;
        }

        public IActionResult Index()
        {
            var values=aboutManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values=aboutManager.TGetById(id);
            return View(values);    
        }
        [HttpPost]
        public IActionResult Update(About about)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (about.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, about.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                about.Image = @"\resim\" + filename + ext;
            }
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");   
        }
    }
}
