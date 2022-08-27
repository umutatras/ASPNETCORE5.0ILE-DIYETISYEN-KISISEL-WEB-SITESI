using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Controllers
{
    [AllowAnonymous]
    public class DietProgController : Controller
    {
        DietProgManager dietProgManager = new DietProgManager(new EfDietDal());
        public IActionResult Index()
        {
            var values=dietProgManager.GetList();
            return View(values);
        }
        public IActionResult DietRead(int id)
        {
            var values=dietProgManager.GetListId(id);
            return View(values);
        }
    }
}
