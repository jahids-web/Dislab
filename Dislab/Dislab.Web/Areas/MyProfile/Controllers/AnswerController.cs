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

        public async Task<IActionResult> Index(long id)
        {
            ViewBag.QuestionTitle = "Your Question Title";

            var data = await _answerService.GetAllAnswerAsync(id);
            return View(data);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> InsertFE(QuestionDetailsVM questionDetailsModel)
        {

            try
            {
                if(ModelState.IsValid)
                {
                    var model = questionDetailsModel.GetInsertAnswerVM();
                    await _answerService.InsertFEAsync(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAnswerByIdFEAsync(long id)
        {
            var question = await _answerService.GetAnswerByIdFEAsync(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Answer Successfully.",
                Data = question
            });
        }

        public async Task<IActionResult> UpdateFE(long id)
        {
            var data = await _answerService.GetAnswerByIdFEAsync(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFE(QuestionDetailsVM questionDetailsVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = questionDetailsVM.GetUpdateAnswerVm();
                    await _answerService.UpdateFEAsync(model);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return Ok(new
                    {
                        Message = "Error Message",
                        Data = questionDetailsVM
                    });
                }
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            try
            {
                ViewData["DeleteMessage"] = "Your data is Deleted Successfully!";
                await _answerService.DeleteFEAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }

        }

        //DashBoard
        public async Task<IActionResult> Update(long id)
        {
            var data = await _answerService.GetAnswerByIdAsync(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AdminAnswerVM model)
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

    }
}
