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

        public IActionResult Index()
        {
            var data = new GetAllQuiestionsVM();
            data = _askQuestionService.GetAll();
            return View(data);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(InsertQuestionVM model)
        {
            if (ModelState.IsValid)
            {
                var result = _askQuestionService.Insert(model);
            }
           
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            _askQuestionService.Delete(id);
            return Ok(new { IsSuccess = true, Message = "Question Deleted Successfully." });
        }

        [HttpGet]
        public IActionResult GetQuestionById(long id)
        {
            var question = _askQuestionService.GetByQuestionId(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Question Successfully.",
                Data = question
            });
        }

        public IActionResult Update(long id)
        {
           var data = _askQuestionService.GetByQuestionId(id);
           return View(data);
        }

        [HttpPost]
        public IActionResult Update(UpdateQuestionVM model)
        {
            if(ModelState.IsValid)
            {
                _askQuestionService.Update(model);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
