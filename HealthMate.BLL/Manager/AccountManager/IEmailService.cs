namespace HealthMate.BLL.Manager.AccountManager
{
	public interface IEmailService
	{
		Task<string> SendEmailAsync(string email, string subject, string message);
	}
}
