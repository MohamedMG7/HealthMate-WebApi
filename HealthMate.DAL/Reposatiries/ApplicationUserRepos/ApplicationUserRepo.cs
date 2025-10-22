using HealthMate.DAL.Data.DbHelper;
using HealthMate.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Reposatiries.ApplicationUserRepos
{
	public class ApplicationUserRepo : GenericRepository<ApplicationUser>,IApplicationUserRepo
	{
		private readonly HealthMateContext _context;

		public ApplicationUserRepo(HealthMateContext context) : base(context)
		{
			_context = context;
		}

		
		public string GetUsernameById(string Id)
		{
			//return the username if found if not return null
			string user = _context.ApplicationUsers.Where(a => a.Id == Id).Select(a => a.First_Name + " " + a.Last_Name).FirstOrDefault();
			return user == null ? null : user;
		}
	}
}
