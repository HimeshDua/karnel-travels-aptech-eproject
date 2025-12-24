using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using karnel_travels_mvc.Data;
using karnel_travels_mvc.Models;

namespace karnel_travels_mvc.Controllers
{
    /// <summary>
    /// InformationController handles information pages displaying data
    /// Shows details about tourist spots, travel options, hotels, restaurants, and resorts
    /// </summary>
    public class InformationController : Controller
    {
        private readonly KarnelTravelContext _context;
        private readonly ILogger<InformationController> _logger;

        /// <summary>
        /// Constructor with dependency injection
        /// </summary>
        /// <param name="context">Database context</param>
        /// <param name="logger">Logger for tracking page access</param>
        public InformationController(KarnelTravelContext context, ILogger<InformationController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// GET: Information hub page
        /// Displays 5 main links to different information categories:
        /// 1. Tourist Spots Information
        /// 2. Travel Information
        /// 3. Hotel Information
        /// 4. Restaurant Information
        /// 5. Resorts Information
        /// </summary>
        /// <returns>Index view with navigation links</returns>
        public IActionResult Index()
        {
            _logger.LogInformation("Information hub page accessed");
            return View();
        }

        /// <summary>
        /// GET: Tourist Spots Information page
        /// Displays all tourist locations within the country
        /// Shows name, location, description, and quality ratings
        /// Includes newly added entries and available packages
        /// </summary>
        /// <returns>TouristSpots view with list of all tourist spots</returns>
        public IActionResult TouristSpots()
        {
            _logger.LogInformation("Tourist Spots information page accessed");

            // Retrieve all tourist spots from database
            // Order by Id descending to show newest entries first
            var touristSpots = _context.TouristSpots
                .OrderByDescending(t => t.Id)
                .ToList();

            return View(touristSpots);
        }

        /// <summary>
        /// GET: Travel Information page
        /// Displays transportation facilities available within the country
        /// Shows buses, trains, flights, ferries with routes and pricing
        /// Includes newly added transportation options and availability
        /// </summary>
        /// <returns>TravelInfo view with list of all travel options</returns>
        public IActionResult TravelInfo()
        {
            _logger.LogInformation("Travel Information page accessed");

            // Retrieve all travel information from database
            // Order by Id descending to show newest entries first
            var travelInfo = _context.TravelInfos
                .OrderByDescending(t => t.Id)
                .ToList();

            return View(travelInfo);
        }

        /// <summary>
        /// GET: Hotels Information page
        /// Displays all hotels with details
        /// Shows name, location, price, quality, and availability
        /// Includes newly added hotels and any discounts/packages
        /// No booking functionality - display only
        /// </summary>
        /// <returns>Hotels view with list of all hotels</returns>
        public IActionResult Hotels()
        {
            _logger.LogInformation("Hotels information page accessed");

            // Retrieve all hotels from database
            // Order by Id descending to show newest entries first
            var hotels = _context.Hotels
                .OrderByDescending(h => h.Id)
                .ToList();

            return View(hotels);
        }

        /// <summary>
        /// GET: Restaurants Information page
        /// Displays all restaurants with details
        /// Shows name, location, cuisine, price, quality, and seating availability
        /// Includes newly added restaurants and special offers
        /// No reservation functionality - display only
        /// </summary>
        /// <returns>Restaurants view with list of all restaurants</returns>
        public IActionResult Restaurants()
        {
            _logger.LogInformation("Restaurants information page accessed");

            // Retrieve all restaurants from database
            // Order by Id descending to show newest entries first
            var restaurants = _context.Restaurants
                .OrderByDescending(r => r.Id)
                .ToList();

            return View(restaurants);
        }

        /// <summary>
        /// GET: Resorts Information page
        /// Displays all resorts with complete details
        /// Shows name, location, price, quality, availability, and capacity
        /// Includes newly added resorts and package deals
        /// No booking functionality - display only
        /// </summary>
        /// <returns>Resorts view with list of all resorts</returns>
        public IActionResult Resorts()
        {
            _logger.LogInformation("Resorts information page accessed");

            // Retrieve all resorts from database
            // Order by Id descending to show newest entries first
            var resorts = _context.Resorts
                .OrderByDescending(r => r.Id)
                .ToList();

            return View(resorts);
        }
    }
}
