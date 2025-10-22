using HealthMate.DAL.DTO.ConditionDto;
using HealthMate.DAL.DTO.EncounterDto;

namespace HealthMate.BLL.Manager.EncounterManager
{
	public interface IEncounterManager
	{
		void AddEncounter(EncounterAddDto encounter);
		IEnumerable<EncounterReadDto> GetAllEncounters();
		EncounterReadDto GetEncounter(int encounterId);
		void DeleteEncounter(int encounterId);
	}
}
