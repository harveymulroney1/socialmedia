using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMedia_Testing.Models;
using Microsoft.EntityFrameworkCore;
using SocialMedia_Testing.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace Computer_science_social_media_project_8_june // 38 minutes ep 3
{
    public class AuthenticationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AuthenticationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet] // loaded when we visit Login url
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost] // dont do anything if dont try to log in
        [AllowAnonymous] // any pages locked still alows login to be reached
        public async Task<IActionResult> Login(Users userModel)
        {
            if (ProcessLogin(userModel.Username, userModel.Password));
            {
                var claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name,userModel.Username)
                    
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principle = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(userIdentity));
                //return Redirect("/Feed"); // redirects to their Feed
                return Redirect("/Admin"); // redirects to admin panel
            }
            return View();
        }
        private bool ProcessLogin(string username, string password)
        {
            Users logindata = new Users();
            var LoginObj = _context.Users.Where(x => x.Username == username && password == x.Password).SingleOrDefault();

            if (LoginObj != null)
            {
                return true;
            }
            // if no result then return false
            Console.WriteLine("Incorrect Username or Password ");
                return false;
            
            
        }
    }
}
