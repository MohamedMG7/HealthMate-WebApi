using HealthMate.DAL.Data.Models;
using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Reposatiries.VerificationCodeRepo
{
	public interface IVerificationCodeRepo : IGenericRepository<VerificationCode>
	{
		bool GetByUserIdAndCode(string userId, string confirmationCode, VerificationPurpose expectedPurpose);
		bool CleanUserAndUnusedExpiredCodes(string userId);
	}
}
