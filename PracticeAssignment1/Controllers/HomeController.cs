using Microsoft.AspNetCore.Mvc;
using PracticeAssignment1.Models;
using PracticeAssignment1.Services;
using System.Diagnostics;

namespace PracticeAssignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuoteService _quoteService;

        public HomeController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public IActionResult Index()
        {
            var quote = _quoteService.GetRandomQuote();
            return View(quote);
        }

        public IActionResult OtherPage()
        {
            var quote = _quoteService.GetRandomQuote();
            return View(quote);
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
