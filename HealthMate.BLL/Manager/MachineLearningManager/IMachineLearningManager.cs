using HealthMate.DAL.DTO.MachineLearningDto;

namespace HealthMate.BLL.Manager.MachineLearningManager{
    public interface IMachineLearningManager{
        Task<MachineLearningResponse> CheckAnimea(int patientId);
        Task<MachineLearningResponse> CheckDiabetes(int patientId);

    }
}