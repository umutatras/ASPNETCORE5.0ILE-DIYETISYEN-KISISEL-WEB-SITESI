using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Controllers
{
    [AllowAnonymous]
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Head()
        {
            return PartialView();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }
        public PartialViewResult Main()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}
