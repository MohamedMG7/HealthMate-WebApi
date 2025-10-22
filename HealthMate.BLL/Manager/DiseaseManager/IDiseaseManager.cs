using HealthMate.DAL.DTO.DiseaseDto;

namespace HealthMate.BLL.Manager.DiseaseManager{
    public interface IDiseaseManager{
        Task<List<DiseaseNameAndIdDto>> getDiseasesNameAndId(); 
    }
}