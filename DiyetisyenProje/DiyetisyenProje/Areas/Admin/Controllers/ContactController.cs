using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        ContactStaticManager contactStaticManager = new ContactStaticManager(new EfContactStaticDal());
        public IActionResult Index()
        {
            var values=contactStaticManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values=contactStaticManager.TGetById(1);
            return View(values);    
        }
        [HttpPost]
        public IActionResult Update(ContactStatic contactStatic)
        {
            contactStaticManager.TUpdate(contactStatic);
            return RedirectToAction("Index");
        }
    }
}
