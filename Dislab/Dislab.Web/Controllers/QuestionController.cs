using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
