using Microsoft.AspNetCore.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class DeckController : Controller
    {
        private DeckContext context { get; set; }

        public DeckController(DeckContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
