using HealthMate.DAL.DTO.MedicineDto;

namespace HealthMate.DAL.DTO.PrescriptionDto{
    public class PrescriptionDetailsReadDto{
        public string PatientName { get; set; } = null!;
        public string PatientNationalId { get; set; } = null!;
        public string PrescriptionDate { get; set; } = null!;
        public string DiseaseName { get; set; } = null!;
        public List<MedicineDetailsReadDto> Medicines { get; set; } = new();
    }
}