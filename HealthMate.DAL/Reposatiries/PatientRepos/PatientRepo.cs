using HealthMate.DAL.Data.DbHelper;
using HealthMate.DAL.Data.Models;
using HealthMate.DAL.DTO.EncounterDto;
using HealthMate.DAL.DTO.PatientDto.HumanPatientDtos;
using HealthMate.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Reposatiries.PatientRepos{
    public class PatientRepo : GenericRepository<Patient>, IPatientRepo{

        private readonly HealthMateContext _context;
        private readonly IDbContextFactory<HealthMateContext> _contextFactory;
        public PatientRepo(HealthMateContext context, IDbContextFactory<HealthMateContext> contextFactory) : base(context)
        {
            _context = context;
            _contextFactory = contextFactory;
        }
       

        public async Task<string> GetPatientImageUrl(int patientId){
          try
            {
                await using var context = await _contextFactory.CreateDbContextAsync();
                var patientImageUrl = await context.Patients
                    .Where(s => s.Patient_Id == patientId)
                    .Select(p => p.ApplicationUser.ImageUrl)
                    .FirstOrDefaultAsync();

                if (patientImageUrl == null)
                {
                    throw new ArgumentNullException("Patient Image Url Not Found");
                }

                return patientImageUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching patient image URL: {ex.Message}");
                throw; 
            }
        }

        public async Task<int> GetPatientAgeByPatientId(int patientId)
        {
            await using var context = await _contextFactory.CreateDbContextAsync();
            
            // Convert DateOnly to DateTime in the query to avoid any DateOnly handling issues
            var birthDateString = await context.Patients
                .Where(p => p.Patient_Id == patientId)
                .Select(p => p.BirthDate.ToString())
                .FirstOrDefaultAsync();
                
            if (string.IsNullOrEmpty(birthDateString))
                throw new Exception($"Patient with ID {patientId} not found or birth date not available");
                
            // Parse the date string and calculate age
            if (DateOnly.TryParse(birthDateString, out var birthDate))
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                int age = today.Year - birthDate.Year;
                
                if (today.Month < birthDate.Month || 
                    (today.Month == birthDate.Month && today.Day < birthDate.Day))
                {
                    age--;
                }
                
                return age;
            }
            
            throw new Exception($"Could not parse birth date value: {birthDateString}");
        }

        public async Task<string> GetPatientGenderByPatientId(int patientId)
        {
            await using var context = await _contextFactory.CreateDbContextAsync();

            var genderValue = await context.Patients
                .Where(p => p.Patient_Id == patientId)
                .Select(p => (int?)p.Gender) // Nullable int in case the patient isn't found
                .FirstOrDefaultAsync();

            if (genderValue == null)
            {
                throw new Exception($"Patient with ID {patientId} not found or gender not available");
            }

            var genderEnum = (Gender)genderValue.Value;
            return genderEnum.ToString();
        }

        public async Task<List<patientDashboardEncounterHistory>> Get4RecentEncounters(int patientId)
        {
            await using var context = await _contextFactory.CreateDbContextAsync();

            var recentEncounters = await context.Encoutners
                .Where(e => e.PatientId == patientId)
                .OrderByDescending(e => e.EndDate)
                .Take(4)
                .Select(e => new patientDashboardEncounterHistory
                {
                    EncounterId = e.Encounter_Id,
                    HcpName = "DR/ " + e.HealthCareProvider.ApplicationUser.First_Name + " " + e.HealthCareProvider.ApplicationUser.Last_Name,
                    HcpSpecialization = e.HealthCareProvider.Specialization,
                    EncounterDate = e.StartDate.ToString("yyyy-MM-dd")
                })
                .ToListAsync();

            return recentEncounters;
        }

        public async Task<DateOnly> GetPatientAge(int patientId){
            return await _context.Patients.Where(s => s.Patient_Id == patientId).Select(p => p.BirthDate).FirstOrDefaultAsync();
        }
        

    }
}