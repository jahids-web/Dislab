using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.ViewModels;
using Dislab.Base.Services;
using Dislab.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dislab.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionService _askQuestionService;
        private readonly IAnswerService _answerService;

        public HomeController(IQuestionService askQuestionService , IAnswerService answerService)
        {
            _askQuestionService = askQuestionService;
            _answerService = answerService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _askQuestionService.GetAllAsync();
            return View(data);
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

        [HttpPost]
        public async Task<IActionResult> AskQuestion(InsertQuestionVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _askQuestionService.InsertAsync(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> QuestionDetails(long id)
        {
            var data = await _askQuestionService.GetByQuestionIdAsync(id);
            return View(data);
        }

        public async Task<IActionResult> Update(long id)
        {
            var data = await _answerService.GetAnswerByIdAsync(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(GetAnswerByIdVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _answerService.UpdateAsync(model);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return Ok(new
                    {
                        Message = "Error Message",
                        Data = model
                    });
                }
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}