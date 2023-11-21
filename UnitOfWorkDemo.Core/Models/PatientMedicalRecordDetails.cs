using PMS.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace PMS.Core.Models
{
    public class PatientMedicalRecordDetails
    {
        [Key]
        public long PatientMedicalRecordID { get; set; }

        [ForeignKey("Patient")]
        public int PatientProfileID { get; set; }
        public virtual Patient? PatientProfile { get; set; }

        public PatientCategories PatientTypeID { get; set; }
        public long BHTNumber { get; set; }

        [ForeignKey("Reason")]
        public long ReasonID { get; set; }
        public virtual Reason? Reason { get; set; }

        public string? Surgery { get; set; }
        public string? IndicationForTheSurgery { get; set; }
        public string? IndicationForAdmissionToTheICU { get; set; }
        public string? TranexamicAcidGivenOrNot { get; set; }
        public string? PreOpBP_mmHg { get; set; }
        public string? PreOpHR_bpm { get; set; }
        public string? PreOpRR_bpm { get; set; }
        public string? PreOpBloodUrea_mg_dL { get; set; }
        public string? PreOpNa { get; set; }
        public string? PreOpK { get; set; }
        public string? PreOpSCcreatinine { get; set; }
        public string? PreOpHB_g_dL { get; set; }
        public string? PreOpWBC_103 { get; set; }
        public string? PreOpFBS_mg_dL { get; set; }
        public string? PreOpNeutrophilCount { get; set; }
        public string? PostOpDay1BP { get; set; }
        public string? PostOpDay1HR { get; set; }
        public string? PostOpDay1RR { get; set; }
        public string? PostOpDay1BloodUrea { get; set; }
        public string? PostOpDay1SerumNa { get; set; }
        public string? PostOpDay1SerumK { get; set; }
        public string? PostOpDay1SerumCreatinine { get; set; }
        public string? PostOpDay1HB { get; set; }
        public string? PostOpDay1WBC { get; set; }
        public string? PostOpDay1FBS_mg_dL { get; set; }
        public string? PostOpDay1Neutrophil { get; set; }
        public string? PostOpD3BP { get; set; }
        public string? PostOpD3HR { get; set; }
        public string? PostOpD3RR { get; set; }
        public string? PostOpD3BloodUrea { get; set; }
        public string? PostOpD3SerumNa { get; set; }
        public string? PostOpD3SerumK { get; set; }
        public string? PostOpD3SerumCreatinine { get; set; }
        public string? PostOpD3HB { get; set; }
        public string? PostOpD3WBC { get; set; }
        public string? PostOpD3FBS { get; set; }
        public string? PostOpD3NeutrophilCount_103_uL { get; set; }
        public string? PostOpD5BP { get; set; }
        public string? PostOpD5HR { get; set; }
        public string? PostOpD5RR { get; set; }
        public string? PostOpD5BloodUrea { get; set; }
        public string? PostOpD5SerumNa { get; set; }
        public string? PostOpD5SerumK { get; set; }
        public string? PostOpD5SerumCreatinine { get; set; }
        public string? PostOpD5HB { get; set; }
        public string? PostOpD5WBC { get; set; }
        public string? PostOpD5FBS { get; set; }
        public string? PostOpD5Neutrophil { get; set; }
        public double? Height_cm { get; set; }
        public double? Weight_kg { get; set; }
        public double? BMI { get; set; }
        public DateTime? DateofSurgery { get; set; }
        public string? Hypertension { get; set; }
        public string? DLD { get; set; }
        public string? DM { get; set; }
        public string? Thyroid { get; set; }
        public string? Others { get; set; }
        public string? IschemicHeartDiseases { get; set; }
        public string? Other1 { get; set; }
        public string? Other2 { get; set; }
        public string? PeripheralNeuropathies { get; set; }
        public string? Stroke { get; set; }
        public string? OtherBoneDissordersInLimbs_congenital { get; set; }
        public string? OtherBoneDissordersInLimbs_traumatic { get; set; }
        public string? HxOfOtherMSKInjuriesAndPains { get; set; }
        public string? Hepato_Gastrointestinal { get; set; }
        public string? Respiratory { get; set; }
        public string? Renal { get; set; }
        public string? Other { get; set; }
        public string? PerOperativeBloodLoss { get; set; }
        public string? BloodLossInTheDrainD2 { get; set; }
        public string? BloodLossInTheDrainD1_D2 { get; set; }
        public string? TorniquetTimeMin { get; set; }
        public string? NOofPostOpBloodTransfussions { get; set; }
        public string? N0ofPostOpFFPTransfussions { get; set; }
        public string? TotalOperativeRoomTime_min { get; set; }
        public string? BoneAvolsion { get; set; }
        public string? LigametAvulsions { get; set; }
        public string? IatrogenicFactors { get; set; }
        public string? SuperficialWoundInfections_1st { get; set; }
        public string? DeepWoundInfections_1st { get; set; }
        public string? QuadricepMuscleRupture_1st { get; set; }
        public string? SkinOpening_1st { get; set; }
        public string? FatEmbolism_1st { get; set; }
        public string? SurgicalWoundComplication_1st { get; set; }
        public string? Hematoma_1st { get; set; }
        public string? ChestComplications_1st { get; set; }
        public string? SuperficialWoundInfections_2nd { get; set; }
        public string? DeepWoundInfections_2nd { get; set; }
        public string? QuadricepMuscleRupture_2st { get; set; }
        public string? SkinOpening_2st { get; set; }
        public string? FatEmbolism_2st { get; set; }
        public string? SurgicalWoundComplication_2st { get; set; }
        public string? Hematoma_2st { get; set; }
        public string? ChestComplications_2st { get; set; }
        public string? SuperficialWoundInfections_Intermediate { get; set; }
        public string? DeepWoundInfections_Intermediate { get; set; }
        public string? QuadricepMuscleRupture_Intermediate { get; set; }
        public string? SkinOpening_Intermediate { get; set; }
        public string? FatEmbolism_2st_Intermediate { get; set; }
        public string? SurgicalWoundComplication_Intermediate { get; set; }
        public string? Hematoma_Intermediate { get; set; }
        public string? ChestComplications_Intermediate { get; set; }
        public string? SuperficialWoundInfections_Late { get; set; }
        public string? DeepWoundInfections_Late { get; set; }
        public string? QuadricepMuscleRupture_Late { get; set; }
        public string? SkinOpening_Late { get; set; }
        public string? FatEmbolism_Late { get; set; }
        public string? SurgicalWoundComplication_Late { get; set; }
        public string? Hematoma_Late { get; set; }
        public string? ChestComplications_Late { get; set; }
        public string? PainTolerance_PostOpD1 { get; set; }
        public string? PainTolerance_beforeDischarge { get; set; }
        public string? NoofDaysInTheICU { get; set; }
        public string? EffectivenessInMobilization { get; set; }
        public string? NoofDaysInTheHospital { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public string? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }
    }
}
