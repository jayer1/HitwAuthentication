using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IS_Proj_HIT.Models;
using isprojectHiT.Models;

namespace IS_Proj_HIT.Controllers
{
    public class HomeController : Controller
    {
        private IWCTCHealthSystemRepository repository;
        public HomeController(IWCTCHealthSystemRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ethnicity() => View(repository.Ethnicities);

        public IActionResult Gender() => View(repository.Genders);

        public IActionResult Discharge() => View(repository.Discharges);

        public IActionResult Sex() => View(repository.Sexes);
    }
}
