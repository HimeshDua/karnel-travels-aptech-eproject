using Microsoft.AspNetCore.Mvc;
using karnel_travels_mvc.Data;
using karnel_travels_mvc.Models;
using System.Diagnostics;

namespace karnel_travels_mvc.Controllers
{
    /// <summary>
    /// HomeController handles the main pages of the website
    /// Including: Home, About Us, Contact Us, and Feedback submission
    /// </summary>
    public class HomeController : Controller
    {
        private readonly KarnelTravelContext _context;
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Constructor with dependency injection for database context and logger
        /// </summary>
        /// <param name="context">Database context for accessing data</param>
        /// <param name="logger">Logger for tracking events and errors</param>
        public HomeController(KarnelTravelContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// GET: Home page - Landing page with introduction to Karnel Travels
        /// Displays welcome message and purpose of the website
        /// </summary>
        /// <returns>Home index view</returns>
        public IActionResult Index()
        {
            _logger.LogInformation("Home page accessed");
            return View();
        }

        /// <summary>
        /// GET: About Us page - Company overview and services offered
        /// Shows information about Karnel Travels services:
        /// - Transportation
        /// - Tour packages
        /// - Accommodation
        /// - Tourist location services
        /// </summary>
        /// <returns>About view</returns>
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


        /// <summary>
        /// GET: Contact Us page - Display contact form and company details
        /// Shows contact information and feedback form for user submissions
        /// </summary>
        /// <returns>Contact view with empty Feedback model</returns>
        public IActionResult Contact()
        {
            _logger.LogInformation("Contact page accessed");
            return View();
        }

        /// <summary>
        /// POST: Submit Contact/Feedback form
        /// Handles user feedback submission from the contact page
        /// Validates input and saves to database
        /// </summary>
        /// <param name="feedback">Feedback model with user's name, email, and message</param>
        /// <returns>Redirects to success page or returns to form with validation errors</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitContact(Feedback feedback)
        {
            // Remove validation for Id and SubmittedDate as they are auto-generated
            ModelState.Remove("Id");
            ModelState.Remove("SubmittedDate");

            if (ModelState.IsValid)
            {
                try
                {
                    // Set the submission date to current date/time
                    feedback.SubmittedDate = DateTime.Now;

                    // Add feedback to database
                    _context.Feedbacks.Add(feedback);
                    _context.SaveChanges();

                    _logger.LogInformation($"Feedback submitted successfully by {feedback.Email}");

                    // Store success message in TempData to display after redirect
                    TempData["SuccessMessage"] = "Thank you for your feedback! We will get back to you soon.";

                    // Redirect to contact page to show success message
                    return RedirectToAction(nameof(Contact));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error submitting feedback");
                    ModelState.AddModelError("", "An error occurred while submitting your feedback. Please try again.");
                }
            }

            // If validation fails, return to contact page with errors
            return View("Contact", feedback);
        }

        /// <summary>
        /// Error page - Displays error information for debugging
        /// </summary>
        /// <returns>Error view with error details</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
