namespace HealthMate.DAL.DTO.ObservationDto{
    public class ObservationPatientDashboardReadDto
    {
        public List<ObservationValueAndDateRead>? Readings { get; set; } 
        public bool IsUpdated { get; set; } 
    }
}