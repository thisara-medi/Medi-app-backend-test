
using PMS.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UnitOfWorkDemo.Core.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [AllowNull]
        public string? FirstName { get; set; }

        [AllowNull]
        public string? LastName { get; set; }

        [AllowNull]
        public DateTime? DateOfBirth { get; set; }
        public string NIC { get; set; }

        [AllowNull]
        public string? Gender { get; set; }

        [AllowNull]
        public int? ContactNumber { get; set; }

        [AllowNull]
        public string? Address { get; set; }

        [AllowNull]
        public int? EmergencyContactNo { get; set; }

        [AllowNull]
        public string? BloodGroup { get; set; }

        [AllowNull]
        public string? MedicalHistory { get; set; }

        [AllowNull]
        public string? Allergic { get; set; }

        [AllowNull]
        public string? insuranceInfomation { get; set; }

        public ICollection<PatientMedicalRecordDetails> PatientMedicalRecordDetails { get; set; }
    }

}
