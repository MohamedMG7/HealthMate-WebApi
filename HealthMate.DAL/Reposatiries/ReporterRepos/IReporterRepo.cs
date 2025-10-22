using HealthMate.DAL.DTO;

namespace HealthMate.DAL.Reposatiries{
    public interface IReporterRepo{
        Task<TrafficReportDto> getDataForTrafficReport(int healthcareproviderId);
    }
}