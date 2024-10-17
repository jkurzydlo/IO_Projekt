using ksiegarniaAp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ksiegarniaAp.Controllers {
	public class HomeController : Controller {
		private readonly AppDbContext _dbContext;
		private readonly ILogger<HomeController> _logger;

		public HomeController(AppDbContext dbContext,ILogger<HomeController> logger) {
			_logger = logger;
			_dbContext = dbContext;
        }

		public IActionResult Index() {

			return View(
				_dbContext.Books.
				Skip(new Random().Next(0, _dbContext.Books.Count() < 10 ? 0 : _dbContext.Books.Count() - 10)).
				Take(10).
				ToList());
		}

		public IActionResult Privacy() {
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
