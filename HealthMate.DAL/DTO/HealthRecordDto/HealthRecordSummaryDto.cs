using HealthMate.DAL.DTO.ConditionDto;
using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.LabTestDto;
using HealthMate.DAL.DTO.MedicalImageDto;
using HealthMate.DAL.DTO.MedicineDto;
using HealthMate.DAL.DTO.PrescriptionDto;

namespace HealthMate.DAL.DTO.HealthRecordDto{
    public class HealthRecordSummaryDto{
        public ICollection<ConditionSummaryReadDto> ConditionsSummary { get; set; } = new HashSet<ConditionSummaryReadDto>();
        public ICollection<LabTestSummaryReadDto> LabTestsSummary { get; set; } = new HashSet<LabTestSummaryReadDto>();
        public ICollection<MedicalImageSummaryReadDto> MedicalImagesSummary { get; set; } = new HashSet<MedicalImageSummaryReadDto>();
        public ICollection<MedicineSummaryReadDto> MedicinesSummary { get; set; } = new HashSet<MedicineSummaryReadDto>();
        public ICollection<PrescriptionSummaryReadDto> PrescriptionsSummary { get; set; } = new HashSet<PrescriptionSummaryReadDto>();
        public ICollection<EncounterSumaryReadDto> EncountersSummary { get; set; } = new HashSet<EncounterSumaryReadDto>();
    }
}