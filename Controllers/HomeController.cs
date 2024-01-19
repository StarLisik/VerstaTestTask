using ASPTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;


namespace ASPTest.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Orders.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult ViewOrder(int id, string citySender, string adressSender, string cityRecipient, string adressRecipient, int weight, DateTime date)
        {
            Order order = new Order();
            order.Id = id;
            order.CitySender = citySender;
            order.AdressSender = adressSender;
            order.CityRecipient = cityRecipient;
            order.AdressRecipient = adressRecipient;
            order.Weight = weight;
            order.Date = date;
            return View(order);
        }
    }
}
