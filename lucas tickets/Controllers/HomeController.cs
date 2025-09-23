using eventlist.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;


namespace lucas_tickets.Controllers
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
            List<Events> eventlist = new List<Events>();

            Events events1 = new Events();
            events1.Title = "new event";
            events1.Description = "a new event";
            events1.Category = 1;
            events1.Createdate =  DateTime.Now;
            events1.Location = "18 pine st";
            events1.Owner = "lucas";

            eventlist.Add(events1);

            return View(eventlist);
        }
    }
}



       
        