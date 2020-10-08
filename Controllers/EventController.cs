using Microsoft.AspNetCore.Mvc;

namespace EventMeeting.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}