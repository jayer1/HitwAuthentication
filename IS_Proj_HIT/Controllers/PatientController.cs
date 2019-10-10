using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IS_Proj_HIT.Models;
using isprojectHiT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IS_Proj_HIT.Controllers
{
    public class PatientController : Controller
    {
        private IWCTCHealthSystemRepository repository;
        public PatientController(IWCTCHealthSystemRepository repo) => repository = repo;
        public IActionResult AddPatient() {

            ViewBag.LastModified = DateTime.Today.AddYears(-1);
            ViewBag.Religions = repository.Religions.Select(r =>
                                 new SelectListItem
                                 {
                                     Value = r.ReligionId.ToString(),
                                     Text = r.Name
                                 }).ToList();

            ViewBag.Sexes = repository.Sexes.Select(s =>
                                 new SelectListItem
                                 {
                                     Value = s.SexId.ToString(),
                                     Text = s.Name
                                 }).ToList();

            ViewBag.Gender = repository.Genders.Select(g =>
                                 new SelectListItem
                                 {
                                     Value = g.GenderId.ToString(),
                                     Text = g.Name
                                 }).ToList();

            ViewBag.Ethnicity = repository.Ethnicities.Select(e =>
                                 new SelectListItem
                                 {
                                     Value = e.EthnicityId.ToString(),
                                     Text = e.Name
                                 }).ToList();

            ViewBag.MaritalStatus = repository.MaritalStatuses.Select(m =>
                                 new SelectListItem
                                 {
                                     Value = m.MaritalStatusId.ToString(),
                                     Text = m.Name
                                 }).ToList();

            ViewBag.Employment = repository.Employments.Select(e =>
                                new SelectListItem
                                {
                                    Value = e.EmploymentId.ToString(),
                                    Text = (e.EmployerName + " - " + e.Occupation).ToString()
                                }).ToList();
            return View();

        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPatient(Patient model)
        {
            //ViewBag.LastModified = DateTime.Today.AddYears(-1);
            if (ModelState.IsValid)
            {
                if (repository.Patients.Any(p => p.Mrn == model.Mrn))
                {
                    ModelState.AddModelError("", "MRN Id must be unique");
                }
                else
                {
                    model.LastModified = @DateTime.Now;
                    repository.AddPatient(model);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployment()
        {
            ViewBag.LastModified = DateTime.Today.AddYears(-1);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEmployment(Employment model)
        {
            if (ModelState.IsValid)
            {
                if (repository.Employments.Any(e => e.EmploymentId == model.EmploymentId))
                {
                    ModelState.AddModelError("", "Employment ID must be unique");
                }
                else
                {
                    model.LastModified = @DateTime.Now;
                    repository.AddEmployment(model);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public IActionResult AddEmploymentToPatient()
        {
            
            return View();
        }
    }
}