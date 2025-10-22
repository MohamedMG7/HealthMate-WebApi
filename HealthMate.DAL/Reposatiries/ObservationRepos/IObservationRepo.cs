using HealthMate.DAL.Data.Models;
using HealthMate.DAL.DTO.MachineLearningDto;
using HealthMate.DAL.DTO.ObservationDto;
using HealthMate.DAL.DTO.PatientDto.HumanPatientDtos;

namespace HealthMate.DAL.Reposatiries.ObservationRepos{
    public interface IObservationRepo : IGenericRepository<Observation>{
        Task<List<HeartRateValueAndDateDto>> GetHeartRateReadingsInXTime(int patientId, int periodInDays);
        Task<List<HemoglobinValueAndDateDto>> GetHemoglobinDataInXTime(int patientId, int periodInDays);
        Task<List<GlucoseLevelValueAndDateDto>> GetGlucoseReadingsInXTime(int patientId, int periodInDays);
        Task<List<DocumentDto>> GetMostRecentDocuments(int patientId);
        Task<List<bloodPressureValueAndDateDto>> GetBloodPressureReadingsInXTime(int patientId, int periodInDays);
        Task<string> GetHighestBloodPressureAsync(int patientId, int periodInDays);
        Task<string> GetLowestBloodPressureAsync(int patientId, int periodInDays);
        Task<AnimeaMLDto> GetRecentCBCTestForML(int patientId);
        Task<decimal> GetLastGlucoseReading(int patientId);

    }
}