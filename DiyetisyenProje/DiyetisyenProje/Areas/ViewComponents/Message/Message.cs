using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Areas.ViewComponents.Message
{
    public class Message:ViewComponent
    {

        ContactDynamicManager contactDynamicManager = new ContactDynamicManager(new EfContactDynamicDal());
        public IViewComponentResult Invoke()
        {
            var values=contactDynamicManager.GetList();
            return View(values);
        }
    }
}
