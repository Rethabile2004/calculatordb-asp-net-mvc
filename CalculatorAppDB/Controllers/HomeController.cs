using CalculatorAppDB.Data;
using CalculatorAppDB.Interfaces;
using CalculatorAppDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculatorAppDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CalculatorContext _context;
        private readonly IDBInitializer _seedDatabase;

        public HomeController(ILogger<HomeController> logger, CalculatorContext context, IDBInitializer seedDatabase)
        {
            //
            // Name             : HomeController(ILogger<HomeController> logger, CalculatorContext context, IDBInitializer seedDatabase)
            // Purpose          : Constructor to initialize controller dependencies including logger, database context, and seeder
            // Re-use           : None
            // Input Parameters : ILogger<HomeController> logger
            //                    CalculatorContext context
            //                    IDBInitializer seedDatabase
            // Output Type      : None
            //
            _logger = logger;
            _context = context;
            _seedDatabase = seedDatabase;
        } // end constructor

        public IActionResult Index()
        {
            //
            // Name             : IActionResult Index()
            // Purpose          : Display the main home page view
            // Re-use           : None
            // Input Parameters : None
            // Output Type      : IActionResult
            //                    - Index view
            //
            return View();
        } // end Index

        public IActionResult Privacy()
        {
            //
            // Name             : IActionResult Privacy()
            // Purpose          : Display the privacy policy view
            // Re-use           : None
            // Input Parameters : None
            // Output Type      : IActionResult
            //                    - Privacy view
            //
            return View();
        } // end Privacy

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }//end method
        public IActionResult SeedDatabase()
        {
            //
            // Name             : IActionResult SeedDatabase()
            // Purpose          : Create and seed the calculator database with initial data
            // Re-use           : Initialize()
            // Input Parameters : None
            // Output Type      : IActionResult
            //                    - SeedDatabase view with feedback message
            //
            _seedDatabase.Initialize(_context);
            ViewBag.SeedDbFeedback = "Database created and the Calculator Table populated with data. Please check the Database folder.";
            return View("SeedDatabase");
        } // end SeedDatabase
    } // end class HomeController
} // end namespace 

