using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.HealthRecordDto;
using HealthMate.DAL.DTO.LabTestDto;
using HealthMate.DAL.DTO.MedicalImageDto;
using HealthMate.DAL.DTO.PrescriptionDto;


namespace HealthMate.BLL.Manager.HealthRecordManager
{
	public interface IHealthRecordManager
	{
		// this should have 
		//General information
		Task<GeneralPatientInformationReadDto> GetPatientGeneralInformation(int PatientId);

		//important behaviours like if he is a smoke we should show this? 

		//allergies 

		// HealthTrend

		// All Health Records
		Task<HealthRecordsReadDto> GetAllHealthRecords(int patientId);

		Task<HealthRecordSummaryDto> GetAllHealthRecordSummary(int patientId);

		#region Health Record Details
		Task<LabTestDetailsReadDto> GetLabTestDetailsAsync(int labTestId);
		Task<MedicalImageDetailsReadDto> GetMedicalImageDetailsAsync(int medicalImageId);
		Task<PrescriptionDetailsReadDto> GetPrescriptionDetailsAsync(int PrescriptionId);
		Task<EncounterDetailsDto> GetEncounterDetailsAsync(int encounterId);
		#endregion

		
		
	}
}
