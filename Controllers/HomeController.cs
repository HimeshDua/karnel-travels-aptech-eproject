using Microsoft.AspNetCore.Mvc;
using karnel_travels_mvc.Data;
using karnel_travels_mvc.Models;
using System.Diagnostics;

namespace karnel_travels_mvc.Controllers
{

    public class HomeController : Controller
    {
        private readonly KarnelTravelContext _context;
        private readonly ILogger<HomeController> _logger;
        public HomeController(KarnelTravelContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home page accessed");
            return View();
        }
        public IActionResult About()
        {
            _logger.LogInformation("About page accessed");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy page accessed");
            return View();
        }

        public IActionResult Contact()
        {
            _logger.LogInformation("Contact page accessed");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitContact(Feedback feedback)
        {
            ModelState.Remove("Id");
            ModelState.Remove("SubmittedDate");

            if (ModelState.IsValid)
            {
                try
                {
                    feedback.SubmittedDate = DateTime.Now;

                    _context.Feedbacks.Add(feedback);
                    _context.SaveChanges();

                    _logger.LogInformation($"Feedback submitted successfully by {feedback.Email}");

                    TempData["SuccessMessage"] = "Thank you for your feedback! We will get back to you soon.";

                    return RedirectToAction(nameof(Contact));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error submitting feedback");
                    ModelState.AddModelError("", "An error occurred while submitting your feedback. Please try again.");
                }
            }

            return View("Contact", feedback);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
