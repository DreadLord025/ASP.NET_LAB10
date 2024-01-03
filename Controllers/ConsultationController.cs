using LAB10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAB10.Controllers
{
    public class ConsultationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Debug.WriteLine(model.FullName);
            Debug.WriteLine(model.Email);
            Debug.WriteLine(model.DesiredDate);
            Debug.WriteLine(model.Product);
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }

}
