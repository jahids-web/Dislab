using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
