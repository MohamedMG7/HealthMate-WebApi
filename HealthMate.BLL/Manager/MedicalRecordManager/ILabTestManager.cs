using HealthMate.DAL.DTO.LabTestDto;

namespace HealthMate.BLL.Manager.LabTestManager{
    public interface ILabTestManager{
        Task addLabTestAsync(LabTestAddDto LabTest);
    }
}