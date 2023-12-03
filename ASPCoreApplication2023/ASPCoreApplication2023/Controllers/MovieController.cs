using ASPCoreApplication2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreApplication2023.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name = "movie 1"
            };
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Name = "movie 2" },
                new Movie { Name = "movie 3" }
            };
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        public IActionResult ByRelease(int year, int month)
        {
            return Content($"Year: {year}, Month: {month}");
        }

        public IActionResult MovieCustomerDetails()
        {
            var movie = new Movie { Id = 1, Name = "Movie 1" };

            var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Customer 1" },
            new Customer { Id = 2, Name = "Customer 2" },
        };

            var viewModel = new MovieCustomerViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel); 
        }

    }
}
