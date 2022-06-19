using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia_Testing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SocialMedia_Testing.Controllers
{
    public class PostController : Controller
    {

        private readonly   _context;
        public PostController( _context);

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Post()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost([Bind("User_Id,PostCaption,PostText")])
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Add(Post);
                   await _context.SaveChangesAsync();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
