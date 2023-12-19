using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
