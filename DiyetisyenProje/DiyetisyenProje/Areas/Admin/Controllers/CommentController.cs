using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DiyetisyenProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            var values=commentManager.GetList();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values=commentManager.TGetById(id);
            commentManager.TDelete(values);
            return RedirectToAction("Index");   
        }
    }
}
