using HealthMate.DAL.DTO.ConditionDto;
using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.LabTestDto;
using HealthMate.DAL.DTO.MedicalImageDto;
using HealthMate.DAL.DTO.MedicineDto;
using HealthMate.DAL.DTO.PrescriptionDto;
using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Reposatiries.HealthRecordRepos
{
	public interface IHealthRecordRepo
	{
		Task<(string Name, DateOnly BirthDate, float? Weight, float? Height, Gender Gender)> GetPatientGeneralInfoAsync(int patientId);

		// Lab Tests
		Task<List<LabTestSummaryReadDto>> getLabTestsSummary(int patientId);

		// Medical Images
		Task<List<MedicalImageSummaryReadDto>> getMedicalImagesSummary(int patientId);

		// Medicines
		Task<List<MedicineSummaryReadDto>> getMedicineSummary(int patientId);

		// Conditions
		Task<List<ConditionSummaryReadDto>> getConditionsSummary(int patientId);

		// Prescriptions
		Task<List<PrescriptionSummaryReadDto>> getPrescriptionsSummary(int patientId);
		//Encounters
		Task<List<EncounterSumaryReadDto>> getEncounterSummary(int patientId);

		// Medical Images Details
		Task<MedicalImageDetailsReadDto> getMedicalImageDetails(int MedicalImageId);

		// Prescription Details
		Task<PrescriptionDetailsReadDto> getPrescriptionDetails(int prescriptionId);

		// LabTest Details
		Task<LabTestDetailsReadDto> getLabTestDetails(int labTestId);
		// Encounter Details
		Task<EncounterDetailsDto> getEncounterDetails(int encounterId);
	}
}
