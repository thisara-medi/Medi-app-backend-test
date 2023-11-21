using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Services.Interfaces
{
    public interface IPatientRecordService
    {
        Task<bool> CreatePatientRecord(PatientMedicalRecordDetails patientRecordDetails);

        Task<IEnumerable<PatientMedicalRecordDetails>> GetAllpatientRecords();

        Task<PatientMedicalRecordDetails> GetPatientRecordById(int patientRecordId);

        Task<bool> UpdatePatientRecord(PatientMedicalRecordDetails ppatientRecordDetails);

        Task<bool> DeletePatientRecord(int patientRecordId);
        Task<List<PatientMedicalRecordDetails>> GetRecordByPatientId(int patientRecordId);

        IQueryable<PatientMedicalRecordDetails> GetPatientRecordsAsQuarable();
    }
}
