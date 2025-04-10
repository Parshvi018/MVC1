using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            TempData["Location"] = "India";
            return View();
        }
        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Test",
                Gender = "Female"
            };
            ViewBag.CurrentDate = DateTime.Now.ToShortDateString();
            ViewData["Title"] = "Miss";
            string? Location= Convert.ToString(TempData["Location"]);
            return View(student);

        }
    }
}
