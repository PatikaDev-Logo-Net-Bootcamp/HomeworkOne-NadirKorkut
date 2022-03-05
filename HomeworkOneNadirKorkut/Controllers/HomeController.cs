using HomeworkOneNadirKorkut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOneNadirKorkut.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var invalidUser = new ResponseViewModel
                {
                    Data = "null",
                    Success = false,
                    Error = "Hatalı Giriş"
                };
                TempData["response"] = "Data : " + invalidUser.Data + ", " + "Success : " + invalidUser.Success + ", " + "Error : " + invalidUser.Error;
                return View();
            }

            var validUser = new ResponseViewModel
            {
                Data = "Giriş İşlemi Başarılı",
                Success = true,
                Error = "null"
            };

            TempData["response"] = "Data : " + validUser.Data + ", " + "Success : " + validUser.Success + ", " + "Error : " + validUser.Error;
            return View(model);
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
