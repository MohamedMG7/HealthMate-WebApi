using HealthMate.DAL.Data.Models;
using HealthMate.DAL.DTO.DiseaseDto;
using HealthMate.DAL.Reposatiries;

namespace HealthMate.BLL.Manager.DiseaseManager{
    public class DiseaseManager : IDiseaseManager{
        private readonly IGenericRepository<Disease> _diseaseRepo;

        public DiseaseManager(IGenericRepository<Disease> diseaseRepo)
        {
            _diseaseRepo = diseaseRepo;
        }
        public async Task<List<DiseaseNameAndIdDto>> getDiseasesNameAndId(){
            var data = _diseaseRepo.GetAll()
            .Select(p => new DiseaseNameAndIdDto
            {
                Id = p.Disease_Id,
                Name = p.Display_Name
            })
            .ToList();

            return data;
        } 
    }
}