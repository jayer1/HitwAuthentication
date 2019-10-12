﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IS_Proj_HIT.Models;
using IS_Proj_HIT.Models.ViewModels;
using isprojectHiT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IS_Proj_HIT.Controllers
{
    public class PatientController : Controller
    {
        private IWCTCHealthSystemRepository repository;

        public int PageSize = 4;
        public PatientController(IWCTCHealthSystemRepository repo) => repository = repo;

        //public IActionResult Index() => View(repository.Patients);

        public ViewResult Index(int patientPage = 1) => View(new ListPatientsViewModel
        {
            Patients = repository.Patients
                .OrderBy(p => p.FirstName)
                .Skip((patientPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = patientPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Patients.Count()
            }
        });


        public IActionResult AddPatient() {

            ViewBag.LastModified = DateTime.Today.AddYears(-1);



            // Do it this way if you need to have nothing selected as default
            // var query = repository.Religions.Select(r => new { r.ReligionId, r.Name });
            //ViewBag.Religions = new SelectList(query.AsEnumerable(), "ReligionId", "Name", 0);

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

        
        // Click Create button on Add Patient page
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

       

        public IActionResult DeletePatient(string id)
        {
            repository.DeletePatient(repository.Patients.FirstOrDefault(b => b.Mrn == id));
            return RedirectToAction("Index");
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

        // Pick record to send to edit page
        public IActionResult Edit(string id)
        {
            ViewBag.LastModified = DateTime.Today.AddYears(-1);
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

            return View(repository.Patients.FirstOrDefault(p => p.Mrn == id));

        }

        // Save edits to data in edit page
        [HttpPost]
        [ActionName("Update")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Patient model)
        {
            if (ModelState.IsValid)
            {
                model.LastModified = @DateTime.Now;
                repository.EditPatient(model);
                return RedirectToAction("Index");
            }

            return View();
        }

       
    }
}