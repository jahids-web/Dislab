using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;
using Dislab.Base.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Dislab.Web.Areas.MyProfile.Controllers
{
    [Area("MyProfile")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _askQuestionService;

        public QuestionController(IQuestionService askQuestionService)
        {
            _askQuestionService = askQuestionService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _askQuestionService.GetAllAsync();
            return View(data);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(InsertQuestionVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _askQuestionService.InsertAsync(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            await _askQuestionService.DeleteAsync(id);
            return Ok(new { IsSuccess = true, Message = "Question Deleted Successfully." });
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestionById(long id)
        {
            var question = await _askQuestionService.GetByQuestionIdAsync(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Question Successfully.",
                Data = question
            });
        }

        public async Task<IActionResult> Update(long id)
        {
            var data = await _askQuestionService.GetByQuestionIdAsync(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AskQuestion model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _askQuestionService.UpdateAsync(model);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            catch(Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
