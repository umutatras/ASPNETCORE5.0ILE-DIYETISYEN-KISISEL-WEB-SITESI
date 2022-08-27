using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Areas.ViewComponents.Footer
{
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
