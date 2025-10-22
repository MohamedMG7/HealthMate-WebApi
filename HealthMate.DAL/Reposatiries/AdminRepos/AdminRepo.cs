using HealthMate.DAL.Data.DbHelper;
using HealthMate.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace HealthMate.DAL.Reposatiries.AdminRepos
{
	public class AdminRepo : IAdminRepo
	{
		private readonly HealthMateContext _context;
        public AdminRepo(HealthMateContext context)
        {
			_context = context;    
        }

        public Patient GetPatientWithApplicationUserData(int id)
		{
			return _context.Patients.Include(p => p.ApplicationUser).FirstOrDefault(p => p.Patient_Id == id);
		}
	}
}
