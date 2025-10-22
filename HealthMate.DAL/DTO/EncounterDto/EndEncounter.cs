using HealthMate.DAL.DTO.LabTestDto;
using HealthMate.DAL.DTO.ObservationDto;
using HealthMate.DAL.DTO.ConditionDto;
using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.EndEcnounterDto;
using EndEncounterDto;



namespace HealthMate.DAL.DTO.HealthCareProviderDto{
    public class EndEncounter{
        //public int EncounterId { get; set; }
        public EndEncounterEncounterAddDto Encounter { get; set; } = null!;
        public EndEncounterPrescriptionAddDto? Prescription { get; set; }
        public ICollection<EndEncounterObservationAddDto>? Observations { get; set; }
        public EndEncounterConditionAddDto? Condition { get; set; }
        public EndEncounterLabTestAddDto? LabTests { get; set; }
        public ICollection<MedicalImageAddDto>? MedicalImages { get; set; }
    }
}