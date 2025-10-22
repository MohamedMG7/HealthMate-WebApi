using HealthMate.DAL.DTO.ConditionDto;
using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.HealthRecordDto;
using HealthMate.DAL.DTO.MentalHealthAssessmentDto;
using HealthMate.DAL.DTO.ObservationDto;

namespace HealthMate.DAL.DTO.PatientDto.HumanPatientDtos{
    public class patientDashboardDto{
        public int patientId { get; set; }
        public string patientImageUrl { get; set; } = null!;
        public HeartRateDto heartRate { get; set; } = null!;
        public GeneralPatientInformationReadDto PatientGeneralInformation { get; set; } = null!;
        public bloodPressureDto bloodPressure {get;set;} = null!;
        public HemoglobinDto Hemoglobin { get; set; } = null!;
        public GlucoseLevelDto Glucose { get; set; } = null!;
        public PatientDashboardConditionReadDto Condition { get; set; } = null!;
        public List<DocumentDto> Documents { get; set; } = null!;
        public List<patientDashboardEncounterHistory> AppointmentHisory { get; set; } = null!;
        public MentalStatusDto MentalHealthStatus { get; set; } = null!;
    
    }
}