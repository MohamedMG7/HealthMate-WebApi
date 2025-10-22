
using HealthMate.DAL.DTO.UserDto;
using HealthMate.DAL.Data.Models;

namespace HealthMate.BLL.Manager.UsersManager
{
	public interface IUserManager
	{
		IEnumerable<UserReadDto> GetAll();
		IEnumerable<ActiveUserReadDto> GetAllActive();
		string GetUserNameById(string Id);
	}
}
