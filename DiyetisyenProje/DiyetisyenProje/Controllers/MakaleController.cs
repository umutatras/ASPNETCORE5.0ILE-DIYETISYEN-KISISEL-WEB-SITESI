using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DiyetisyenProje.Controllers
{
    [AllowAnonymous]
    public class MakaleController : Controller
    {
        MakaleManager makaleManager = new MakaleManager(new EfMakaleDal());
        public IActionResult Index()
        {
            var values=makaleManager.GetList();
            return View(values);
        }
        public IActionResult MakaleRead(int id)
        {
            var makale = makaleManager.GetIdMakale(id);
            return View(makale);
        }
    }
}
