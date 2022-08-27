using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        ContactDynamicManager contactDynamicManager = new ContactDynamicManager(new EfContactDynamicDal());
        public IActionResult Index()
        {
            var values=contactDynamicManager.GetList();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values=contactDynamicManager.TGetById(id);
            contactDynamicManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
