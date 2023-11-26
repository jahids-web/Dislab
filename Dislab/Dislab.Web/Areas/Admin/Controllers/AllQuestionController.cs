using Dislab.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AllQuestionController : Controller
    {
        private readonly ILogger<AskQuestionController> _logger;

        public AllQuestionController(ILogger<AskQuestionController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
