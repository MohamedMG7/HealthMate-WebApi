using HealthMate.DAL.Data.Models;
using HealthMate.DAL.DTO.EncounterDto;

namespace HealthMate.DAL.Reposatiries.PatientRepos{
    public interface IPatientRepo : IGenericRepository<Patient>{
        Task<string> GetPatientImageUrl(int patientId);
        Task<int> GetPatientAgeByPatientId(int patientId);
        Task<string> GetPatientGenderByPatientId(int patientId);
        Task<List<patientDashboardEncounterHistory>> Get4RecentEncounters(int patientId);
        Task<DateOnly> GetPatientAge(int patientId);

        
    }
}