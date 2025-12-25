using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using karnel_travels_mvc.Data;
using karnel_travels_mvc.Models;

namespace karnel_travels_mvc.Controllers
{
    public class SearchController : Controller
    {
        private readonly KarnelTravelContext _context;
        private readonly ILogger<SearchController> _logger;

        public SearchController(KarnelTravelContext context, ILogger<SearchController> logger)
        {
            _context = context;
            _logger = logger;
        }

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

            var viewModel = new SearchViewModel();

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
