using Data;
using Data.Entities;
using Data.Service;
using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    [Trait("ҵ���ܲ���", "�û�ģ��")]
    public class UserServiceTest
    {
        private IUserService _userService { get; set; }

        private UserContext GetUerContext()
        {
            return new UserContext();
        }

        [Fact(DisplayName = "����һ���û�")]
        public async Task UserService_Add_WithExpectedParameters()
        {
            UserContext userContext = GetUerContext();
            _userService = new UserService(userContext);
            User entity = new User
            {
                NickName = "Jack",
                CreateTime = DateTime.Now,
                ModifyTime = DateTime.Now,
                IsDelete = false
            };
            bool success = await _userService.AddUserAsync(entity);
            Assert.True(success);
        }
    }
}
