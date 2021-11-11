using Microsoft.AspNetCore.Mvc;
using FSInterview.Models;

namespace FSInterview.Controllers
{
    public class FormController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Account account)
        {
            return View("ThankYou", account);
        }
    }
}
