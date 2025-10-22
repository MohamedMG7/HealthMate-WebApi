using HealthMate.DAL.DTO.ConditionDto;

namespace HealthMate.BLL.Manager.ConditionManager
{
	public interface IConditionManager
	{
		void AddCondition(ConditionAddDto condition);
		IEnumerable<ConditionReadDto> GetAllConditions();
		ConditionReadDto GetCondition(int conditionId);
		void DeleteCondition(int conditionId);
		Task<PatientDashboardConditionReadDto> getMostRecentSevereOngoingCondition(int patientId);
	}
}
