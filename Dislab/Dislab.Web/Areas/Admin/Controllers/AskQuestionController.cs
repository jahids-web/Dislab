using Dislab.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AskQuestionController : Controller
    {
        private readonly ILogger<AskQuestionController> _logger;

        public AskQuestionController(ILogger<AskQuestionController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
