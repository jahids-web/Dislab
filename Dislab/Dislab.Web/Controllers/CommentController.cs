using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
