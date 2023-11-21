using PMS.Core.Models;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
