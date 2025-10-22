using HealthMate.DAL.Data.DbHelper;
using HealthMate.DAL.DTO.MedicineDto;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Reposatiries{
    public class MedicineRepo : IMedicineRepo{
        private readonly HealthMateContext _context;
        public MedicineRepo(HealthMateContext context)
        {
            _context = context;
        }

        public async Task<List<MedicineNameAndIdDto>> getMedicineNameAndId(){
            var result = await _context.Medicines
                .Select(m => new MedicineNameAndIdDto
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToListAsync();

            return result;
        }
    }
}