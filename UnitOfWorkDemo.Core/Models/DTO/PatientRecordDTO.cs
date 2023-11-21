using PMS.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Models.DTO
{
    public class PatientRecordDTO
    {

        public int Id { get; set; }

        public int? PatientId { get; set; }

        [AllowNull]
        public string? bht { get; set; }

        public PatientCategories PatientCategories { get; set; }

        public int? ReasonId { get; set; }

        [AllowNull]
        public int? Age { get; set; }

        [AllowNull]
        public string? Name { get; set; }

        [AllowNull]
        public double? Weight { get; set; }

        [AllowNull]
        public double? Height { get; set; }

        [AllowNull]
        public string? Surgery { get; set; }

        [AllowNull]
        public string? IndicationForAdmissionToTheICU { get; set; }

        [AllowNull]
        public bool? TranexamicAcidGivenOrNot { get; set; }

        [AllowNull]
        public int? PreOpBP_mmHg { get; set; }

        [AllowNull]
        public int? PreOpHR_bpm { get; set; }

        [AllowNull]
        public int? PreOpRR_bpm { get; set; }

        [AllowNull]
        public int? PreOpBloodUrea_mg_dL { get; set; }

        [AllowNull]
        public int? PreOpNa { get; set; }

        [AllowNull]
        public int? PreOpK { get; set; }

        [AllowNull]
        public int? PreOpSCcreatinine { get; set; }

        [AllowNull]
        public int? PreOpHB_g_dL { get; set; }

        [AllowNull]
        public int? PreOpWBC_103 { get; set; }

        [AllowNull]
        public int? PreOpFBS_mg_dL { get; set; }

        [AllowNull]
        public int? PreOpNeutrophilCount { get; set; }

        [AllowNull]
        public int? PostOpDay1BP { get; set; }

        [AllowNull]
        public int? PostOpDay1HR { get; set; }

        [AllowNull]
        public int? PostOpDay1RR { get; set; }

        [AllowNull]
        public int? PostOpDay1BloodUrea { get; set; }

        [AllowNull]
        public int? PostOpDay1SerumNa { get; set; }

        [AllowNull]
        public int? PostOpDay1SerumK { get; set; }

        [AllowNull]
        public int? PostOpDay1SerumCreatinine { get; set; }

        [AllowNull]
        public int? PostOpDay1HB { get; set; }

        [AllowNull]
        public int? PostOpDay1WBC { get; set; }

        [AllowNull]
        public int? PostOpDay1FBS_mg_dL { get; set; }

        [AllowNull]
        public int? PostOpDay1Neutrophil { get; set; }

        [AllowNull]
        public int? PostOpD3BP { get; set; }

        [AllowNull]
        public int? PostOpD3HR { get; set; }

        [AllowNull]
        public int? PostOpD3RR { get; set; }

        [AllowNull]
        public int? PostOpD3BloodUrea { get; set; }

        [AllowNull]
        public int? PostOpD3SerumNa { get; set; }

        [AllowNull]
        public int? PostOpD3SerumK { get; set; }

        [AllowNull]
        public int? PostOpD3SerumCreatinine { get; set; }

        [AllowNull]
        public int? PostOpD3HB { get; set; }

        [AllowNull]
        public int? PostOpD3WBC { get; set; }

        [AllowNull]
        public int? PostOpD3FBS { get; set; }

        [AllowNull]
        public int? PostOpD3NeutrophilCount_103_uL { get; set; }

        [AllowNull]
        public int? PostOpD5BP { get; set; }

        [AllowNull]
        public int? PostOpD5HR { get; set; }

        [AllowNull]
        public int? PostOpD5RR { get; set; }

        [AllowNull]
        public int? PostOpD5BloodUrea { get; set; }

        [AllowNull]
        public int? PostOpD5SerumNa { get; set; }

        [AllowNull]
        public int? PostOpD5SerumK { get; set; }

        [AllowNull]
        public int? PostOpD5SerumCreatinine { get; set; }

        [AllowNull]
        public int? PostOpD5HB { get; set; }

        [AllowNull]
        public int? PostOpD5WBC { get; set; }

        [AllowNull]
        public int? PostOpD5FBS { get; set; }

        [AllowNull]
        public int? PostOpD5Neutrophil { get; set; }

        [AllowNull]
        public int? Height_cm { get; set; }

        [AllowNull]
        public int? Weight_kg { get; set; }

        [AllowNull]
        public decimal? BMI { get; set; }

        [AllowNull]
        public DateTime? DateofSurgery { get; set; }

        [AllowNull]
        public bool? Hypertension { get; set; }

        [AllowNull]
        public bool? DLD { get; set; }

        [AllowNull]
        public bool? DM { get; set; }

        [AllowNull]
        public bool? Thyroid { get; set; }

        [AllowNull]
        public string? Others { get; set; }

        [AllowNull]
        public bool? IschemicHeartDiseases { get; set; }

        [AllowNull]
        public string? Other1 { get; set; }

        [AllowNull]
        public string? Other2 { get; set; }

        [AllowNull]
        public bool? PeripheralNeuropathies { get; set; }

        [AllowNull]
        public bool? Stroke { get; set; }

        [AllowNull]
        public bool? OtherBoneDissordersInLimbs_congenital { get; set; }

        [AllowNull]
        public bool? OtherBoneDissordersInLimbs_traumatic { get; set; }

        [AllowNull]
        public string? HxOfOtherMSKInjuriesAndPains { get; set; }

        [AllowNull]
        public bool? Hepato_Gastrointestinal { get; set; }

        [AllowNull]
        public bool? Respiratory { get; set; }

        [AllowNull]
        public bool? Renal { get; set; }

        [AllowNull]
        public string? other { get; set; }

        [AllowNull]
        public int? PerOperativeBloodLoss { get; set; }

        [AllowNull]
        public int? BloodLossInTheDrainD2 { get; set; }

        [AllowNull]
        public int? BloodLossInTheDrainD1_D2 { get; set; }

        [AllowNull]
        public int? TorniquetTimeMin { get; set; }

        [AllowNull]
        public int? NOofPostOpBloodTransfussions { get; set; }

        [AllowNull]
        public int? N0ofPostOpFFPTransfussions { get; set; }

        [AllowNull]
        public int? TotalOperativeRoomTime_min { get; set; }

        [AllowNull]
        public bool? BoneAvolsion { get; set; }

        [AllowNull]
        public bool? LigametAvulsions { get; set; }

        [AllowNull]
        public string? IatrogenicFactors { get; set; }

        [AllowNull]
        public int? SuperficialWoundInfections_1st { get; set; }

        [AllowNull]
        public int? DeepWoundInfections_1st { get; set; }

        [AllowNull]
        public int? QuadricepMuscleRupture_1st { get; set; }

        [AllowNull]
        public int? SkinOpening_1st { get; set; }

        [AllowNull]
        public int? FatEmbolism_1st { get; set; }

        [AllowNull]
        public int? SurgicalWoundComplication_1st { get; set; }

        [AllowNull]
        public int? Hematoma_1st { get; set; }

        [AllowNull]
        public int? ChestComplications_1st { get; set; }

        [AllowNull]
        public int? SuperficialWoundInfections_2nd { get; set; }

        [AllowNull]
        public int? DeepWoundInfections_2nd { get; set; }

        [AllowNull]
        public int? QuadricepMuscleRupture_2st { get; set; }

        [AllowNull]
        public int? SkinOpening_2st { get; set; }

        [AllowNull]
        public int? FatEmbolism_2st { get; set; }

        [AllowNull]
        public int? SurgicalWoundComplication_2st { get; set; }

        [AllowNull]
        public int? Hematoma_2st { get; set; }

        [AllowNull]
        public int? ChestComplications_2st { get; set; }

        [AllowNull]
        public int? SuperficialWoundInfections_Intermediate { get; set; }

        [AllowNull]
        public int? DeepWoundInfections_Intermediate { get; set; }

        [AllowNull]
        public int? QuadricepMuscleRupture_Intermediate { get; set; }

        [AllowNull]
        public int? SkinOpening_Intermediate { get; set; }

        [AllowNull]
        public int? FatEmbolism_Intermediate { get; set; }

        [AllowNull]
        public int? SurgicalWoundComplication_Intermediate { get; set; }

        [AllowNull]
        public int? Hematoma_Intermediate { get; set; }

        [AllowNull]
        public int? ChestComplications_Intermediate { get; set; }

        [AllowNull]
        public int? SuperficialWoundInfections_Late { get; set; }

        [AllowNull]
        public int? DeepWoundInfections_Late { get; set; }

        [AllowNull]
        public int? QuadricepMuscleRupture_Late { get; set; }

        [AllowNull]
        public int? SkinOpening_Late { get; set; }

        [AllowNull]
        public int? FatEmbolism_Late { get; set; }

        [AllowNull]
        public int? SurgicalWoundComplication_Late { get; set; }

        [AllowNull]
        public int? Hematoma_Late { get; set; }

        [AllowNull]
        public int? ChestComplications_Late { get; set; }

        [AllowNull]
        public int? PainTolerance_PostOpD1 { get; set; }

        [AllowNull]
        public int? PainTolerance_beforeDischarge { get; set; }

        [AllowNull]
        public int? NoofDaysInTheICU { get; set; }

        [AllowNull]
        public int? EffectivenessInMobilization { get; set; }

        [AllowNull]
        public int? NoofDaysInTheHospital { get; set; }

        [AllowNull]
        public DateTime? CreatedDate { get; set; }

        [AllowNull]
        public string? CreatedBy { get; set; }

        [AllowNull]
        public DateTime? ModifiedDate { get; set; }

        [AllowNull]
        public string? ModifiedBy { get; set; }

        [AllowNull]
        public bool? IsDeleted { get; set; }

        [AllowNull]
        public DateTime? DeletedDate { get; set; }

        [AllowNull]
        public string? DeletedBy { get; set; }

    }
}
