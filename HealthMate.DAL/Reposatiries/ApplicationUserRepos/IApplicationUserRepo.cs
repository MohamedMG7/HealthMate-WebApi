using HealthMate.DAL.Data.Models;

namespace HealthMate.DAL.Reposatiries.ApplicationUserRepos
{
	public interface IApplicationUserRepo : IGenericRepository<ApplicationUser>
	{
		string GetUsernameById(string Id);
	}
}
