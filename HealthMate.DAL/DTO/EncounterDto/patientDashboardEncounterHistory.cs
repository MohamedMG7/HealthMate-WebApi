namespace HealthMate.DAL.DTO.EncounterDto{
    public class patientDashboardEncounterHistory{
        public int EncounterId { get; set; }
        public string HcpName { get; set; } = null!;
        public string HcpSpecialization { get; set; } = null!;
        public string EncounterDate { get; set; } = null!;
    }
}