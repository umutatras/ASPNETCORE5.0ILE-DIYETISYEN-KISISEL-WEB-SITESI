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
    public class MakaleController : Controller
    {
        MakaleManager makaleManager = new MakaleManager(new EfMakaleDal());
        private readonly IWebHostEnvironment _he;

        public MakaleController(IWebHostEnvironment he)
        {
            _he = he;
        }
        public IActionResult Index()
        {
            var values = makaleManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Makale makale)
        {
            makale.Dateinfo = DateTime.Now;
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (makale.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, makale.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                makale.Image = @"\resim\" + filename + ext;
            }
            makaleManager.TAdd(makale);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = makaleManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Makale makale)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var filename = Guid.NewGuid().ToString();
                var uploads = Path.Combine(_he.WebRootPath, @"resim");
                var ext = Path.GetExtension(files[0].FileName);
                if (makale.Image != null)
                {
                    var imagePath = Path.Combine(_he.WebRootPath, makale.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, filename + ext), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                makale.Image = @"\resim\" + filename + ext;
            }
            makaleManager.TUpdate(makale);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var values = makaleManager.TGetById(id);
            makaleManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
