using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Dapper.Extensions;
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
        private readonly IMapper _mapper;

        public HomeController(IQuestionService askQuestionService, IMapper mapper )
        {
            _askQuestionService = askQuestionService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _askQuestionService.GetAllFEAsync();
            return View(data);
        } 
        
        public async Task<IActionResult> AllQuestion()
        {
            var data = await _askQuestionService.GetAllFEAsync();
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
                    var result = await _askQuestionService.InsertFEAsync(model);
                    TempData["message"] = "Question Inserted Successfully";

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
            var data = await _askQuestionService.GetQuestionByFEIdAsync(id);
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}