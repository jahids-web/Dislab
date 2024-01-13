using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class AskQuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
