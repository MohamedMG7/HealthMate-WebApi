using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.ConditionDto;
using HealthMate.DAL.DTO.ObservationDto;

namespace HealthMate.DAL.DTO.HealthRecordDto
{
	public class HealthRecordsReadDto
	{
        public IEnumerable<ConditionReadDto> Conditions { get; set; }
        public IEnumerable<EncounterReadDto> Encounters { get; set; }
        public IEnumerable<ObservationReadDto> Observations { get; set; }
    }
}
