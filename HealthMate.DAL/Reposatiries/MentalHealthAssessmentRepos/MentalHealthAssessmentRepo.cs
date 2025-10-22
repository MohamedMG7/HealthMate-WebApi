using HealthMate.DAL.Data;
using HealthMate.DAL.Data.DbHelper;
using HealthMate.DAL.Data.Models;
using HealthMate.DAL.Enums;
using HealthMate.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMate.DAL.Repositories
{
    /// <summary>
    /// Handles database operations related to mental health assessments.
    /// </summary>
    public class MentalHealthAssessmentRepository : IMentalHealthAssessmentRepo
    {
        private readonly IDbContextFactory<HealthMateContext> _contextFactory;

        public MentalHealthAssessmentRepository(IDbContextFactory<HealthMateContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task AddAsync(MentalHealthAssessment assessment)
        {
            using var context = _contextFactory.CreateDbContext();
            context.MentalHealthAssessments.Add(assessment);
            await context.SaveChangesAsync();
        }

        public async Task<List<MentalHealthAssessment>> GetByPatientIdAsync(int patientId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MentalHealthAssessments
                .Where(a => a.patientId == patientId)
                .OrderByDescending(a => a.CreatedAt)
                .ToListAsync();
        }

        public async Task<MentalHealthAssessment?> GetLatestPhq9Async(int patientId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MentalHealthAssessments
                .Where(a => a.patientId == patientId && a.AssessmentType == AssessmentType.PHQ9)
                .OrderByDescending(a => a.CreatedAt)
                .FirstOrDefaultAsync();
        }

        public async Task<MentalHealthAssessment?> GetLatestGad7Async(int patientId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MentalHealthAssessments
                .Where(a => a.patientId == patientId && a.AssessmentType == AssessmentType.GAD7)
                .OrderByDescending(a => a.CreatedAt)
                .FirstOrDefaultAsync();
        }
    }
}
