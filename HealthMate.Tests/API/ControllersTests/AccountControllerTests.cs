using Xunit;
using Moq;
using HealthMate.BLL.Manager.AccountManager;
using HealthMate.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.Tests.API.ControllersTests
{
	public class AccountControllerTests
	{
		private readonly Mock<IAccountManager> _accountManagerMock;
		private readonly AccountController _controller;

		//public AccountControllerTests()
		//{
		//	_accountManagerMock = new Mock<IAccountManager>();
		//	_controller = new AccountController(_accountManagerMock.Object);
		//}

	}
}
