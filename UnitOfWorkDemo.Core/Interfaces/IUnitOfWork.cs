



using PMS.Core.Interfaces;

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository Patient { get; }
        IPatientRecordRepository PatientRecord { get; }
        IUserRepository UserRepository { get; }
        Task<int> CompleteAsync();
        int Save();
   
    }
}
