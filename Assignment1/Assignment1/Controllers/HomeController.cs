using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {

        private static List<Equipment> equipmentList = new List<Equipment>();


        public HomeController()
        {
            if (!equipmentList.Any())
            {
                equipmentList.Add(new Equipment { Id = 1, Type = EquipmentType.Laptop, Description = "Dell Laptop", Availability = true });
                equipmentList.Add(new Equipment { Id = 2, Type = EquipmentType.Phone, Description = "iPhone X", Availability = false });
                equipmentList.Add(new Equipment { Id = 3, Type = EquipmentType.Tablet, Description = "iPad Pro", Availability = true });
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AllEquipment()
        {
            return View(equipmentList);
        }
        public ViewResult AvailableEquipment()
        {
            var availableEquipment = equipmentList.Where(e => e.Availability).ToList();
            return View(availableEquipment);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Request request)
        {
            Repository.AddResponse(request);
            return View("Received", request);
        }
        public ViewResult Requests()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
