using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace DiyetisyenProje.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DietProgramController : Controller
    {
        DietProgManager dietProgManager = new DietProgManager(new EfDietDal());
        private readonly IWebHostEnvironment _he;

        public DietProgramController(IWebHostEnvironment he)
        {
            _he = he;
        }
        public IActionResult Index()
        {
            var values=dietProgManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DietProgram dietProgram)
        {
            dietProgram.Dateinfo = DateTime.Now;    
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (dietProgram.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, dietProgram.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                dietProgram.Image = @"\resim\" + filename + ext;
            }
            dietProgManager.TAdd(dietProgram);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = dietProgManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(DietProgram dietProgram)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (dietProgram.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, dietProgram.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                dietProgram.Image = @"\resim\" + filename + ext;
            }
            dietProgManager.TUpdate(dietProgram);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var values = dietProgManager.TGetById(id);
            dietProgManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
