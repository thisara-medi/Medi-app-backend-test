using PMS.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Services.Interfaces
{
    public interface IPatientService
    {
        Task<bool> CreatePatient(PatientDto patientDetails);

        Task<IEnumerable<Patient>> GetAllpatients();

        Task<Patient> GetPatientById(int patientId);

        Task<bool> UpdatePatient(Patient patientDetails);

        Task<bool> DeletePatient(int patientId);
    }
}
