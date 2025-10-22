using HealthMate.DAL.DTO.MedicineDto;

namespace HealthMate.DAL.Reposatiries{
    public interface IMedicineRepo{
        Task<List<MedicineNameAndIdDto>> getMedicineNameAndId();
    }
}