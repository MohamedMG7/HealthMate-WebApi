using HealthMate.DAL.Data.Models;

namespace HealthMate.DAL.Reposatiries.AdminRepos
{
	public interface IAdminRepo
	{
		Patient GetPatientWithApplicationUserData(int id);
	}
}
