using HealthMate.DAL.Data.Models;

namespace HealthMate.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Interface for accessing mental health assessment data from the database.
    /// </summary>
    public interface IMentalHealthAssessmentRepo
    {
        Task AddAsync(MentalHealthAssessment assessment);
        Task<List<MentalHealthAssessment>> GetByPatientIdAsync(int patientId);
        Task<MentalHealthAssessment?> GetLatestPhq9Async(int patientId);
        Task<MentalHealthAssessment?> GetLatestGad7Async(int patientId);
    }
}
