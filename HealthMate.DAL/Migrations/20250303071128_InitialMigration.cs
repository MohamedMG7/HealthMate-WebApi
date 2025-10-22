using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodySites",
                columns: table => new
                {
                    BodySite_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    System = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodySites", x => x.BodySite_Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Disease_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scientific_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Display_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ICD11_Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Disease_Id);
                });

            migrationBuilder.CreateTable(
                name: "LabTestAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueUnit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTestAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActiveIngrediantes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsedToCure = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Admin_Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareProviders",
                columns: table => new
                {
                    HealthCareProvider_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOnJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Governorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareProviders", x => x.HealthCareProvider_Id);
                    table.ForeignKey(
                        name: "FK_HealthCareProviders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Fhir_Id = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "NEWID()"),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Governorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    Height = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patient_Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserFeedbacks",
                columns: table => new
                {
                    UserFeedback_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUser_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedBackCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFeedbacks", x => x.UserFeedback_Id);
                    table.ForeignKey(
                        name: "FK_UserFeedbacks_AspNetUsers_ApplicationUser_Id",
                        column: x => x.ApplicationUser_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VerificationCodes",
                columns: table => new
                {
                    ApplicationUser_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VerificationCodeDigits = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerificationCodes", x => new { x.ApplicationUser_Id, x.VerificationCodeDigits });
                    table.ForeignKey(
                        name: "FK_VerificationCodes_AspNetUsers_ApplicationUser_Id",
                        column: x => x.ApplicationUser_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDiseaseExperiences",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    Experince = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDiseaseExperiences", x => new { x.ApplicationUserId, x.DiseaseId });
                    table.ForeignKey(
                        name: "FK_UserDiseaseExperiences_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDiseaseExperiences_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Disease_Id");
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Animal_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Animal_Fhir_Id = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "NEWID()"),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Animal_Id);
                    table.ForeignKey(
                        name: "FK_Animals_Patients_Owner_Id",
                        column: x => x.Owner_Id,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateTable(
                name: "Encoutners",
                columns: table => new
                {
                    Encounter_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Encounter_Fhir_Id = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "NEWID()"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    HealthCareProviderId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_To_Visit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Treatment_Plan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encoutners", x => x.Encounter_Id);
                    table.ForeignKey(
                        name: "FK_Encoutners_HealthCareProviders_HealthCareProviderId",
                        column: x => x.HealthCareProviderId,
                        principalTable: "HealthCareProviders",
                        principalColumn: "HealthCareProvider_Id");
                    table.ForeignKey(
                        name: "FK_Encoutners_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateTable(
                name: "LabTests",
                columns: table => new
                {
                    LabTestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    LabTestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTests", x => x.LabTestId);
                    table.ForeignKey(
                        name: "FK_LabTests_Patients_patientId",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalImages",
                columns: table => new
                {
                    MedicalImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paitentId = table.Column<int>(type: "int", nullable: false),
                    MedicalImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interpertation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalImages", x => x.MedicalImageId);
                    table.ForeignKey(
                        name: "FK_MedicalImages_Patients_paitentId",
                        column: x => x.paitentId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateTable(
                name: "Observations",
                columns: table => new
                {
                    Observation_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observation_Fhir_Id = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "NEWID()"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueQuanitity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ValueUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfObservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Interpertation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodySiteId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observations", x => x.Observation_Id);
                    table.ForeignKey(
                        name: "FK_Observations_BodySites_BodySiteId",
                        column: x => x.BodySiteId,
                        principalTable: "BodySites",
                        principalColumn: "BodySite_Id");
                    table.ForeignKey(
                        name: "FK_Observations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrescriptionImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.PrescriptionId);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Condition_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condition_Fhir_Id = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "NEWID()"),
                    PaientId = table.Column<int>(type: "int", nullable: false),
                    EncounterId = table.Column<int>(type: "int", nullable: true),
                    DateRecorded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClinicalStatus = table.Column<int>(type: "int", nullable: false),
                    Recorder = table.Column<int>(type: "int", nullable: false),
                    Disease_Id = table.Column<int>(type: "int", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    BodySiteId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isChronic = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Condition_Id);
                    table.ForeignKey(
                        name: "FK_Conditions_BodySites_BodySiteId",
                        column: x => x.BodySiteId,
                        principalTable: "BodySites",
                        principalColumn: "BodySite_Id");
                    table.ForeignKey(
                        name: "FK_Conditions_Diseases_Disease_Id",
                        column: x => x.Disease_Id,
                        principalTable: "Diseases",
                        principalColumn: "Disease_Id");
                    table.ForeignKey(
                        name: "FK_Conditions_Encoutners_EncounterId",
                        column: x => x.EncounterId,
                        principalTable: "Encoutners",
                        principalColumn: "Encounter_Id");
                    table.ForeignKey(
                        name: "FK_Conditions_Patients_PaientId",
                        column: x => x.PaientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                });

            migrationBuilder.CreateTable(
                name: "LabTestResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabTestId = table.Column<int>(type: "int", nullable: false),
                    LabTestAttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabTestResults_LabTestAttributes_LabTestAttributeId",
                        column: x => x.LabTestAttributeId,
                        principalTable: "LabTestAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LabTestResults_LabTests_LabTestId",
                        column: x => x.LabTestId,
                        principalTable: "LabTests",
                        principalColumn: "LabTestId");
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicines",
                columns: table => new
                {
                    PatientMedicineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    FrequencyInHours = table.Column<int>(type: "int", nullable: false),
                    DurationInDays = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true),
                    IsPrescribed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicines", x => x.PatientMedicineId);
                    table.ForeignKey(
                        name: "FK_PatientMedicines_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientMedicines_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id");
                    table.ForeignKey(
                        name: "FK_PatientMedicines_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "PrescriptionId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0", null, "Patient", "PATIENT" },
                    { "1", null, "HealthCareProvider", "HEALTHCAREPROVIDER" },
                    { "2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ApplicationUserId",
                table: "Admins",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Owner_Id",
                table: "Animals",
                column: "Owner_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_BodySiteId",
                table: "Conditions",
                column: "BodySiteId",
                unique: true,
                filter: "[BodySiteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_Disease_Id",
                table: "Conditions",
                column: "Disease_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_EncounterId",
                table: "Conditions",
                column: "EncounterId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_PaientId",
                table: "Conditions",
                column: "PaientId");

            migrationBuilder.CreateIndex(
                name: "IX_Encoutners_HealthCareProviderId",
                table: "Encoutners",
                column: "HealthCareProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Encoutners_PatientId",
                table: "Encoutners",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareProviders_ApplicationUserId",
                table: "HealthCareProviders",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabTestResults_LabTestAttributeId",
                table: "LabTestResults",
                column: "LabTestAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_LabTestResults_LabTestId",
                table: "LabTestResults",
                column: "LabTestId");

            migrationBuilder.CreateIndex(
                name: "IX_LabTests_patientId",
                table: "LabTests",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalImages_paitentId",
                table: "MedicalImages",
                column: "paitentId");

            migrationBuilder.CreateIndex(
                name: "IX_Observations_BodySiteId",
                table: "Observations",
                column: "BodySiteId",
                unique: true,
                filter: "[BodySiteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Observations_PatientId",
                table: "Observations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicines_MedicineId",
                table: "PatientMedicines",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicines_PatientId",
                table: "PatientMedicines",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicines_PrescriptionId",
                table: "PatientMedicines",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ApplicationUserId",
                table: "Patients",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDiseaseExperiences_DiseaseId",
                table: "UserDiseaseExperiences",
                column: "DiseaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFeedbacks_ApplicationUser_Id",
                table: "UserFeedbacks",
                column: "ApplicationUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationCodes_ApplicationUser_Id",
                table: "VerificationCodes",
                column: "ApplicationUser_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "LabTestResults");

            migrationBuilder.DropTable(
                name: "MedicalImages");

            migrationBuilder.DropTable(
                name: "Observations");

            migrationBuilder.DropTable(
                name: "PatientMedicines");

            migrationBuilder.DropTable(
                name: "UserDiseaseExperiences");

            migrationBuilder.DropTable(
                name: "UserFeedbacks");

            migrationBuilder.DropTable(
                name: "VerificationCodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Encoutners");

            migrationBuilder.DropTable(
                name: "LabTestAttributes");

            migrationBuilder.DropTable(
                name: "LabTests");

            migrationBuilder.DropTable(
                name: "BodySites");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "HealthCareProviders");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
