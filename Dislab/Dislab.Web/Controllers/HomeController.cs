using Dislab.Base.Services;
using Dislab.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dislab.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionService _askQuestionService;

        public HomeController(IQuestionService askQuestionService)
        {
            _askQuestionService = askQuestionService;
        }
        public IActionResult Index()
        {
            return View();
        } 
        
        public async Task<IActionResult> AllQuestion()
        {
            var data = await _askQuestionService.GetAllAsync();
            return View(data);
        }    
        
        public IActionResult AskQuestion()
        {
            return View();
        }

        public async Task<IActionResult> QuestionDetails(long id)
        {
            var data = await _askQuestionService.GetByQuestionIdAsync(id);
            return View(data);
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}