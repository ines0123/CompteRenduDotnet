using ASPCoreApplication2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreApplication2023.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Ines"},
            new Customer { Id = 2, Name = "Emna"},
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Customer c = customers.Find(x => x.Id == id);
            return View(c);
        }

    }
}
