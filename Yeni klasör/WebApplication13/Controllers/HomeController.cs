
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dto;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ornek([FromBody] OrnekDto ornekDto )
        {
            return View(ornekDto);
        }
    }
}