using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using karnel_travels_mvc.Data;
using karnel_travels_mvc.Models;

namespace karnel_travels_mvc.Controllers
{
    /// <summary>
    /// SearchController handles all search functionality
    /// Allows searching across TouristSpots, Hotels, Restaurants, and Resorts
    /// with filters for location, price, quality, and availability
    /// </summary>
    public class SearchController : Controller
    {
        private readonly KarnelTravelContext _context;
        private readonly ILogger<SearchController> _logger;

        /// <summary>
        /// Constructor with dependency injection
        /// </summary>
        /// <param name="context">Database context</param>
        /// <param name="logger">Logger for tracking search operations</param>
        public SearchController(KarnelTravelContext context, ILogger<SearchController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// GET: Search page - Displays search form and results
        /// Shows all available tourist spots, hotels, restaurants, and resorts by default
        /// </summary>
        /// <param name="searchTerm">General search term (optional)</param>
        /// <param name="location">Filter by location (optional)</param>
        /// <param name="minPrice">Minimum price filter (optional)</param>
        /// <param name="maxPrice">Maximum price filter (optional)</param>
        /// <param name="quality">Quality filter (optional)</param>
        /// <param name="availability">Availability filter (optional)</param>
        /// <returns>Search view with filtered results</returns>
        public IActionResult Index(
            string? searchTerm,
            string? location,
            decimal? minPrice,
            decimal? maxPrice,
            string? quality,
            bool? availability)
        {
            _logger.LogInformation("Search page accessed with filters - SearchTerm: {SearchTerm}, Location: {Location}",
                searchTerm, location);

            // Create a view model to hold all search results
            var viewModel = new SearchViewModel();

            // Query TouristSpots
            var touristSpotsQuery = _context.TouristSpots.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                touristSpotsQuery = touristSpotsQuery.Where(t =>
                    t.Name.Contains(searchTerm) ||
                    t.Location.Contains(searchTerm) ||
                    t.Description.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(location))
            {
                touristSpotsQuery = touristSpotsQuery.Where(t => t.Location.Contains(location));
            }

            if (!string.IsNullOrEmpty(quality))
            {
                touristSpotsQuery = touristSpotsQuery.Where(t => t.Quality.Contains(quality));
            }

            if (availability.HasValue)
            {
                touristSpotsQuery = touristSpotsQuery.Where(t => t.IsAvailable == availability.Value);
            }

            viewModel.TouristSpots = touristSpotsQuery.ToList();

            // Query Hotels
            var hotelsQuery = _context.Hotels.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                hotelsQuery = hotelsQuery.Where(h =>
                    h.Name.Contains(searchTerm) ||
                    h.Location.Contains(searchTerm) ||
                    h.Description.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(location))
            {
                hotelsQuery = hotelsQuery.Where(h => h.Location.Contains(location));
            }

            if (minPrice.HasValue)
            {
                hotelsQuery = hotelsQuery.Where(h => h.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                hotelsQuery = hotelsQuery.Where(h => h.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(quality))
            {
                hotelsQuery = hotelsQuery.Where(h => h.Quality.Contains(quality));
            }

            if (availability.HasValue && availability.Value)
            {
                hotelsQuery = hotelsQuery.Where(h => h.Availability > 0);
            }

            viewModel.Hotels = hotelsQuery.ToList();

            // Query Restaurants
            var restaurantsQuery = _context.Restaurants.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                restaurantsQuery = restaurantsQuery.Where(r =>
                    r.Name.Contains(searchTerm) ||
                    r.Location.Contains(searchTerm) ||
                    r.Description.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(location))
            {
                restaurantsQuery = restaurantsQuery.Where(r => r.Location.Contains(location));
            }

            if (minPrice.HasValue)
            {
                restaurantsQuery = restaurantsQuery.Where(r => r.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                restaurantsQuery = restaurantsQuery.Where(r => r.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(quality))
            {
                restaurantsQuery = restaurantsQuery.Where(r => r.Quality.Contains(quality));
            }

            if (availability.HasValue && availability.Value)
            {
                restaurantsQuery = restaurantsQuery.Where(r => r.Availability > 0);
            }

            viewModel.Restaurants = restaurantsQuery.ToList();

            // Query Resorts
            var resortsQuery = _context.Resorts.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                resortsQuery = resortsQuery.Where(r =>
                    r.Name.Contains(searchTerm) ||
                    r.Location.Contains(searchTerm) ||
                    r.Description.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(location))
            {
                resortsQuery = resortsQuery.Where(r => r.Location.Contains(location));
            }

            if (minPrice.HasValue)
            {
                resortsQuery = resortsQuery.Where(r => r.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                resortsQuery = resortsQuery.Where(r => r.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(quality))
            {
                resortsQuery = resortsQuery.Where(r => r.Quality.Contains(quality));
            }

            if (availability.HasValue && availability.Value)
            {
                resortsQuery = resortsQuery.Where(r => r.Availability > 0);
            }

            viewModel.Resorts = resortsQuery.ToList();

            // Store filter values in ViewData for repopulating form
            ViewData["SearchTerm"] = searchTerm;
            ViewData["Location"] = location;
            ViewData["MinPrice"] = minPrice;
            ViewData["MaxPrice"] = maxPrice;
            ViewData["Quality"] = quality;
            ViewData["Availability"] = availability;

            return View(viewModel);
        }
    }
}
