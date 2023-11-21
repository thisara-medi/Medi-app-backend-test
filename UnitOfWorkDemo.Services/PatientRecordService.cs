using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;
using UnitOfWorkDemo.Services.Interfaces;

namespace UnitOfWorkDemo.Services
{
    public class PatientRecordService : IPatientRecordService
    {
        public IUnitOfWork _unitOfWork;

        public PatientRecordService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreatePatientRecord(PatientMedicalRecordDetails patientRecordDetails)
        {
            if (patientRecordDetails != null)
            {
                await _unitOfWork.PatientRecord.Add(patientRecordDetails);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeletePatientRecord(int patientRecordId)
        {
            if (patientRecordId > 0)
            {
                var patientDetails = await _unitOfWork.PatientRecord.GetById(patientRecordId);
                if (patientDetails != null)
                {
                    _unitOfWork.PatientRecord.Delete(patientDetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<PatientMedicalRecordDetails>> GetAllpatientRecords()
        {
            var patientRecordList = await _unitOfWork.PatientRecord.GetAll();
            return patientRecordList;
        }

        public async Task<PatientMedicalRecordDetails> GetPatientRecordById(int patientRecordId)
        {
            if (patientRecordId > 0)
            {
                var patientRecordDetails = await _unitOfWork.PatientRecord.GetById(patientRecordId);
                if (patientRecordDetails != null)
                {
                    return patientRecordDetails;
                }
            }
            return null;
        }

        public async Task<bool> UpdatePatientRecord(PatientMedicalRecordDetails patientRecordDetails)
        {
            if (patientRecordDetails != null)
            {
                var patientRecord = await _unitOfWork.PatientRecord.GetById(patientRecordDetails.PatientMedicalRecordID);
                if(patientRecord != null)
                {
                    var type = typeof(PatientMedicalRecordDetails);
                    var properties = type.GetProperties();

                    foreach (var property in properties)
                    {
                        var originalValue = property.GetValue(patientRecord);
                        var newValue = property.GetValue(patientRecordDetails);

                        if ((originalValue == null && newValue != null) ||
                            (originalValue != null && !originalValue.Equals(newValue)))
                        {
                            // Update the property if it has changed
                            property.SetValue(patientRecord, newValue);
                        }
                    }

                    // Mark the entity as modified
                    _unitOfWork.PatientRecord.Update(patientRecord);

                    var result = _unitOfWork.Save();// Assuming SaveAsync is asynchronous

                    return result > 0;
                }
            }
            return false;
        }

        public Task<List<PatientMedicalRecordDetails>> GetRecordByPatientId(int patientRecordId)
        {
            if (patientRecordId > 0)
            {
                var patientRecordDetails = _unitOfWork.PatientRecord.GetRecordByPatientId(patientRecordId);
                if (patientRecordDetails != null)
                {
                    return patientRecordDetails;
                }
            }
            return null;
        }

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsByPatientName(string patientName)
            => _unitOfWork.PatientRecord.GetPatientRecordsByPatientName(patientName);

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsAsQuarable()
            => _unitOfWork.PatientRecord.GetPatientRecordsAsQuarable();

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsById(string patientId)
            => _unitOfWork.PatientRecord.GetPatientRecordsById(patientId);
    }
}
