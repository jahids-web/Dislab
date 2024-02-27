using AutoMapper;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;
using Dislab.Base.Services;
using Microsoft.AspNetCore.Mvc;

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
            var data = await _askQuestionService.GetAllFEAsync();
            return View(data);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> InsertFE(InsertQuestionVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _askQuestionService.InsertFEAsync(model);
                }
                return RedirectToAction(nameof(Index));
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
                await _askQuestionService.DeleteFEAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetQuestionByFEId(long id)
        {
            var question = await _askQuestionService.GetQuestionByFEIdAsync(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Question Successfully.",
                Data = question
            });
        }

        public async Task<IActionResult> UpdateQuestionFE(long id)
        {
            var data = await _askQuestionService.GetQuestionByFEIdAsync(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuestionFE(QuestionDetailsVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _askQuestionService.UpdateFEAsync(model);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        //DashBoard 
        public async Task<IActionResult> Update(long id)
        {
            var data = await _askQuestionService.GetQuestionByIdAsync(id);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AdminQuestionVM model)
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
                    return Ok();
                }
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
