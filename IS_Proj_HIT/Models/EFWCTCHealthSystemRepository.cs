using IS_Proj_HIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isprojectHiT.Models
{
    public class EFWCTCHealthSystemRepository : IWCTCHealthSystemRepository
    {
        private WCTCHealthSystemContext context;
        public EFWCTCHealthSystemRepository(WCTCHealthSystemContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Ethnicity> Ethnicities => context.Ethnicity;
        public IQueryable<Gender> Genders => context.Gender;

        public IQueryable<Discharge> Discharges => context.Discharge;
        public IQueryable<Sex> Sexes => context.Sex;

        public IQueryable<Patient> Patients => context.Patient;

        public IQueryable<Religion> Religions => context.Religion;

        public IQueryable<MaritalStatus> MaritalStatuses => context.MaritalStatus;

        public IQueryable<Employment> Employments => context.Employment;

        public void AddEmployment(Employment employment)
        {
            context.Add(employment);
            context.SaveChanges();
        }

        public void AddPatient(Patient patient)
        {
            context.Add(patient);
            context.SaveChanges();
        }
    }
}
