using IS_Proj_HIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isprojectHiT.Models
{
    public interface IWCTCHealthSystemRepository
    {
        IQueryable<Ethnicity> Ethnicities { get; }
        IQueryable<Gender> Genders { get; }
        IQueryable<Discharge> Discharges { get; }
        IQueryable<Sex> Sexes { get; }
        IQueryable<Religion> Religions { get; }
        IQueryable<MaritalStatus> MaritalStatuses { get; }
        IQueryable<Patient> Patients { get; }
        IQueryable<Employment> Employments { get; }

        void AddPatient(Patient patient);

        void AddEmployment(Employment employment);

    }
}
