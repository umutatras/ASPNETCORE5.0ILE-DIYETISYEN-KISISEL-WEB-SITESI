using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Areas.ViewComponents.Head
{
    public class Head:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
