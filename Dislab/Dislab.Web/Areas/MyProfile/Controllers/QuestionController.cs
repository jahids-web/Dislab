﻿using Dislab.Base.Features.Questions.Entities;
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
        public IActionResult GetQuestionById(long id)
        {
            var question = _askQuestionService.GetByQuestionIdAsync(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Question Successfully.",
                Data = question
            });
        }

        public IActionResult Update(long id)
        {
           var data = _askQuestionService.GetByQuestionIdAsync(id);
           return View(data);
        }

        [HttpPost]
        public IActionResult Update(UpdateQuestionVM model)
        {
            if(ModelState.IsValid)
            {
                _askQuestionService.UpdateAsync(model);
            }
            return RedirectToAction(nameof(Index));
        }

}
