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
        //private readonly IMapper _mapper;

        public QuestionController(IQuestionService askQuestionService /*IMapper mapper*/)
        {
            _askQuestionService = askQuestionService;
            //_mapper = mapper;
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
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _askQuestionService.InsertAsync(model);
                   //_mapper.Map<InsertQuestionDTO>(result);
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
                await _askQuestionService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
           
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
        public async Task<IActionResult> Update(UpdateQuestionVM model)
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
                    return Ok(new
                    {
                        Message = "Error Message",
                        Data = model
                    });
                }
            }
            catch(Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
