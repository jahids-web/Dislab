﻿using Microsoft.AspNetCore.Mvc;

namespace Dislab.Web.Controllers
{
    public class VoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
