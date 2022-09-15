using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;

namespace PatternForCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExpenseServices _movieServices;

        public HomeController(IExpenseServices movieServices)
        {
            _movieServices = movieServices;
        }


        [Authorize]
        public IActionResult Index()
        {
            return View(_movieServices.GetAll());
        }

        public IActionResult SaveMovie(Expense expense)
        {
            _movieServices.Add(expense);
            return RedirectToAction("Index");
        }

       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
