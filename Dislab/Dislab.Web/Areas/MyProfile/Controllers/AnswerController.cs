using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.ViewModels;
using Dislab.Base.Services;
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

        public IActionResult Index()
        {
            return View();
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




    }
}
