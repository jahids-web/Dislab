using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class AskQuestionController : Controller
    {
        private readonly IAskQuestionService _askQuestionService;

        public AskQuestionController(IAskQuestionService askQuestionService)
        {
            _askQuestionService = askQuestionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(AskQuestion question) 
        {
            var result = _askQuestionService.Insert(question);
            return View();
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

        [HttpPut]
        public void Update(AskQuestion askQuestion)
        {
            _askQuestionService.Update(askQuestion);
        }

        [HttpGet]
        public IEnumerable<AskQuestion> GetAll()
        {
            var data = _askQuestionService.GetAll();
            return data;
        }









    }
}
