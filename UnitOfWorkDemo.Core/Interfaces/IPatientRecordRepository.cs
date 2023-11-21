using PMS.Core.Models;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IPatientRecordRepository : IGenericRepository<PatientMedicalRecordDetails>
    {
        IQueryable<PatientMedicalRecordDetails> GetPatientRecordsById(string patientId);
        IQueryable<PatientMedicalRecordDetails> GetPatientRecordsAsQuarable();
        IQueryable<PatientMedicalRecordDetails> GetPatientRecordsByPatientName(string patientName);
        Task<List<PatientMedicalRecordDetails>>GetRecordByPatientId(int patientId);
    }
}
