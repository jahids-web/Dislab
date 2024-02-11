using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.ViewModels;
using Dislab.Base.Services;
using Dislab.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Areas.MyProfile.Controllers
{
    [Area("MyProfile")]
    public class AnswerController : Controller
    {
        private readonly IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _answerService.GetAllAsync();
            return View(data);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(QuestionDetailsVM questionDetailsModel)
        {
           
            try
            {
                if(ModelState.IsValid)
                {
                    var model = questionDetailsModel.GetAnswerVM();
                    await _answerService.InsertAsync(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAnswerByIdAsync(long id)
        {
            var question = await _answerService.GetAnswerByIdAsync(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Answer Successfully.",
                Data = question
            });
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

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                ViewData["DeleteMessage"] = "Your data is Deleted Successfully!";
                await _answerService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }

        }
    }
}
