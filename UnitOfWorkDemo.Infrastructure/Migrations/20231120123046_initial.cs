using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactNo = table.Column<int>(type: "int", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    insuranceInfomation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reason",
                columns: table => new
                {
                    ReasonID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reason", x => x.ReasonID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientRecord",
                columns: table => new
                {
                    PatientMedicalRecordID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientProfileID = table.Column<int>(type: "int", nullable: false),
                    PatientTypeID = table.Column<int>(type: "int", nullable: false),
                    BHTNumber = table.Column<long>(type: "bigint", nullable: false),
                    ReasonID = table.Column<long>(type: "bigint", nullable: false),
                    Surgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicationForTheSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicationForAdmissionToTheICU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranexamicAcidGivenOrNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpBP_mmHg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpHR_bpm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpRR_bpm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpBloodUrea_mg_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpSCcreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpHB_g_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpWBC_103 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpFBS_mg_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpNeutrophilCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1HR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1RR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1BloodUrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1SerumNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1SerumK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1SerumCreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1HB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1FBS_mg_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1Neutrophil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3HR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3RR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3BloodUrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3SerumNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3SerumK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3SerumCreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3HB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3FBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3NeutrophilCount_103_uL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5HR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5RR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5BloodUrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5SerumNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5SerumK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5SerumCreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5HB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5FBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5Neutrophil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height_cm = table.Column<double>(type: "float", nullable: true),
                    Weight_kg = table.Column<double>(type: "float", nullable: true),
                    BMI = table.Column<double>(type: "float", nullable: true),
                    DateofSurgery = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hypertension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DLD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thyroid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IschemicHeartDiseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeripheralNeuropathies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stroke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherBoneDissordersInLimbs_congenital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherBoneDissordersInLimbs_traumatic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HxOfOtherMSKInjuriesAndPains = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hepato_Gastrointestinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Respiratory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerOperativeBloodLoss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodLossInTheDrainD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodLossInTheDrainD1_D2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TorniquetTimeMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOofPostOpBloodTransfussions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N0ofPostOpFFPTransfussions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalOperativeRoomTime_min = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoneAvolsion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigametAvulsions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IatrogenicFactors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_2nd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_2nd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_2st_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PainTolerance_PostOpD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PainTolerance_beforeDischarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoofDaysInTheICU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectivenessInMobilization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoofDaysInTheHospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecord", x => x.PatientMedicalRecordID);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Patients_PatientProfileID",
                        column: x => x.PatientProfileID,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Reason_ReasonID",
                        column: x => x.ReasonID,
                        principalTable: "Reason",
                        principalColumn: "ReasonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_PatientProfileID",
                table: "PatientRecord",
                column: "PatientProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_ReasonID",
                table: "PatientRecord",
                column: "ReasonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientRecord");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Reason");
        }
    }
}
