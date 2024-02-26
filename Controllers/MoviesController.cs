using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("salam");
            return View();
        }
    }
}
