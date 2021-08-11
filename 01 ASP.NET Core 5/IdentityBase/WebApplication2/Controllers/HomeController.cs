using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<MyExtendedIdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, 
                                UserManager<MyExtendedIdentityUser> userManager,
                                ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            /*(var result = await this._userManager.FindByIdAsync("30de0176-74ca-4df3-bc1f-6a298abdaf75");

            MyExtendedIdentityUser user = result;
            user.KleurVanDeAuto = "Groen";

            var res = await this._userManager.UpdateAsync(user);
            */
//            var user = this._context.Users.FirstOrDefault(a=>a.Id == "30de0176-74ca-4df3-bc1f-6a298abdaf75");
  //          user.KleurVanDeAuto = "Oranje";
  //
    //        this._context.SaveChanges();

            //this._context.Users.Add(user);
            //this._context.SaveChanges();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
