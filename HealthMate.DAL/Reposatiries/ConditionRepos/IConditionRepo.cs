using HealthMate.DAL.Data.Models;
using HealthMate.DAL.DTO.ConditionDto;

namespace HealthMate.DAL.Reposatiries.ConditionRepos{
    public interface IConditionRepo : IGenericRepository<Condition>{
        Task<PatientDashboardConditionReadDto> getMostRecentSevereOngoingCondition(int patinetId);
    }
}