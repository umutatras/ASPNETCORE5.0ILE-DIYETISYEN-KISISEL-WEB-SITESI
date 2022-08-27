using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactDynamicManager contactDynamicManager = new ContactDynamicManager(new EfContactDynamicDal());
        ContactStaticManager contactStaticManager = new ContactStaticManager(new EfContactStaticDal());
        public IActionResult Index()
        {
            var values=contactStaticManager.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult ContactAdd(ContactDynamic contactDynamic)
        {
            contactDynamicManager.TAdd(contactDynamic);
            return RedirectToAction("Index");
        }
    }
}
