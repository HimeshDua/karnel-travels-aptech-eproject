using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using karnel_travels_mvc.Data;
using karnel_travels_mvc.Models;

namespace karnel_travels_mvc.Controllers
{
    public class InformationController : Controller
    {
        private readonly KarnelTravelContext _context;
        private readonly ILogger<InformationController> _logger;
    public InformationController(KarnelTravelContext context, ILogger<InformationController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Information hub page accessed");
            return View();
        }

      
        public IActionResult TouristSpots()
        {
            _logger.LogInformation("Tourist Spots information page accessed");

            var touristSpots = _context.TouristSpots
                .OrderByDescending(t => t.Id)
                .ToList();

            return View(touristSpots);
        }

       
        public IActionResult TravelInfo()
        {
            _logger.LogInformation("Travel Information page accessed");

            var travelInfo = _context.TravelInfos
                .OrderByDescending(t => t.Id)
                .ToList();

            return View(travelInfo);
        }

        public IActionResult Hotels()
        {
            _logger.LogInformation("Hotels information page accessed");

            var hotels = _context.Hotels
                .OrderByDescending(h => h.Id)
                .ToList();

            return View(hotels);
        }
        public IActionResult Restaurants()
        {
            _logger.LogInformation("Restaurants information page accessed");

            var restaurants = _context.Restaurants
                .OrderByDescending(r => r.Id)
                .ToList();

            return View(restaurants);
        }

        public IActionResult Resorts()
        {
            _logger.LogInformation("Resorts information page accessed");

            var resorts = _context.Resorts
                .OrderByDescending(r => r.Id)
                .ToList();

            return View(resorts);
        }
    }
}
