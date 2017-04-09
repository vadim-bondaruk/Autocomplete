using Autocomplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Autocomplete.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetData(string term)
        {
            var listOfPerson = new List<Person>()
            {
                new Person {FirstName = "Ivan", LastName="Ivanov", Id=1 },
                new Person {FirstName = "Petr", LastName = "Petrov", Id=2 },
                new Person {FirstName = "Vadim", LastName = "Bondaruk", Id=3 }
            };

            var result = listOfPerson.Where(p => p.LastName.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0);
            return Json(result);

        }
    }
}