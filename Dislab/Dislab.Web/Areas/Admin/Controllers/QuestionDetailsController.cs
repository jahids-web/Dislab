using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class QuestionDetailsController : Controller
    {

        private readonly ILogger<QuestionDetailsController> _logger;

        public QuestionDetailsController(ILogger<QuestionDetailsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
