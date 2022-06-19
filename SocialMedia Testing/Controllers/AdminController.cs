using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia_Testing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia_Testing.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


    }
}
