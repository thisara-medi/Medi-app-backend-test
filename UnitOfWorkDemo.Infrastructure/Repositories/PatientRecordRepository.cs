using Microsoft.EntityFrameworkCore;
using PMS.Core.Models;
using System.Collections.Generic;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRecordRepository : GenericRepository<PatientMedicalRecordDetails>, IPatientRecordRepository
    {
        public PatientRecordRepository(DbContextClass dbContext) : base(dbContext) { }

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsByPatientName(string patientName)
            => _dbContext.PatientRecord.Where(x => (x.PatientProfile.FirstName + x.PatientProfile.LastName).Contains(patientName));

        public async Task<List<PatientMedicalRecordDetails>> GetRecordByPatientId(int patientId)
            => await _dbContext.PatientRecord.Where(u => u.PatientProfileID == patientId).ToListAsync();
        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsAsQuarable()
            => _dbContext.PatientRecord
            .Include(x=> x.PatientProfile);

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsById(string patientId) 
            => _dbContext.PatientRecord.Where(x => x.PatientProfileID.ToString().Contains(patientId));
    }
}
