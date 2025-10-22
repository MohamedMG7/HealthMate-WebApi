using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.ObservationDto;
using HealthMate.DAL.DTO.PatientDto.HumanPatientDtos;

namespace HealthMate.BLL.Manager.ObservationManager
{
	public interface IObservationManager
	{
		void AddObservation(ObservationAddDto observationDto);
		IEnumerable<ObservationReadDto> GetAllObservations();
		ObservationReadDto GetObservation(int observationId);
		void DeleteObservation(int ObservationId);
		Task<HeartRateDto> GetAverageHeartrateInXTime(int patientId, int periodInDays);
		Task<HemoglobinDto> GetHemoglobinDataInXTime(int patientId, int periodInDays);
		Task<GlucoseLevelDto> GetAverageGlucoseInXTime(int patientId, int periodInDays);
		Task<bloodPressureDto> GetAverageBloodPressureInXTime(int patientId, int periodInDays);
	
	}
}
