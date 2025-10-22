using HealthMate.DAL.Data.Models;

namespace HealthMate.DAL.Reposatiries{
    public interface ILabTestAttributeRepo : IGenericRepository<LabTestAttribute>{
        Task<int> GetIdByNameAsync(string AttributeName);
    }
}