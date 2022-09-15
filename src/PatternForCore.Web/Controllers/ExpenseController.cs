using Microsoft.AspNetCore.Mvc;

namespace PatternForCore.Web.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
