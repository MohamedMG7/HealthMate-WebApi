using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.HealthCareProviderDto;
using HealthMate.DAL.DTO.HealthRecordDto;
using HealthMate.DAL.DTO.PatientDto.HumanPatientDtos;

namespace HealthMate.BLL.Manager.HealthCareProviderManager
{
	public interface IHealthCareProviderManager
	{
		Task<int> GetTheCountOfTodayEncountersAsync(int healthCareProviderId);
		Task<int> GetTheCountOfPatientsDoctorEncounteredAsync(int healthCareProviderId);
		//int GetTheCountOfAllUnreadMessagesFromPatients(); not now
		Task<int> GetTheCountOfTotalEncountersAsync(int healthCareProviderId);
		Task<IEnumerable<EncounterTableSummaryReadDto>> GetRecentEncountersOrderedAsync(int healthCareProviderId);
		Task<string> GetHealthCareProviderNameById(int healthCareProviderId);

		Task<bool> EndEncounter(EndEncounter endEcounterDto,int PatientId, int HealthcareProviderId);
		Task<patientDashboardDto> StartEncounter(string PatientNationalId);
		Task<ClinicDashBoardDataDto> GetClinicalDashboardData(int HealthCareProviderId);
		Task<List<int>> GetLast7DaysEncountersCountAsync(int healthCareProviderId);
		
	}
}
