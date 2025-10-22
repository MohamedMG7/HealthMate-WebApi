using HealthMate.DAL.DTO.ObservationDto;

namespace HealthMate.BLL.Manager.UtilityManager{
    public interface IUtilityManager{
        int CalculateAgeReturnYearsOnly(DateOnly birthDate);
        List<int> ExctractSystolicAndDiastolic(decimal bloodPressure);
        //Task<ObservationPatientDashboardReadDto> GetObservationRecordsAsync(int patientId, string observationType, int xDays, int yRecords);
    }
}