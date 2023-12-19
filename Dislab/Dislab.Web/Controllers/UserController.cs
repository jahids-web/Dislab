using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
