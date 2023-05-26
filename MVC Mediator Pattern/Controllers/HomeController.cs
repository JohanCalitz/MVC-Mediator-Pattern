using Microsoft.AspNetCore.Mvc;
using MVC_Mediator_Pattern.Infrastructure;
using MVC_Mediator_Pattern.Models;
using System;
using System.Diagnostics;

namespace MVC_Mediator_Pattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonMediator _personMediator;

        public HomeController(IPersonMediator personMediator)
        {
            _personMediator = personMediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson(Person person)
        {
            await _personMediator.CreatePerson(person.Name, person.Age);

            return RedirectToAction("Index");
        }
    }
}