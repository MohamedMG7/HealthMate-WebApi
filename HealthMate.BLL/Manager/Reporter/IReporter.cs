using HealthMate.DAL.DTO;

namespace HealthMate.BLL.Manager{
    public interface IReporter{
        Task<TrafficReportDto> generateTrafficReport(int healthcareProviderId);
    }
}