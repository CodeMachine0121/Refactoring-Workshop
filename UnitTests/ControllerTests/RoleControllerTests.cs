using FluentAssertions;
using Intern;
using Intern_Refactoring;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using NSubstitute;
using NUnit.Framework;

namespace TestProject1.ControllerTests;

[TestFixture]
public class RoleControllerTests
{
    [SetUp]
    public void SetUp()
    {
        _roleService = Substitute.For<IRoleService>();
        _roleController = new RoleController(_roleService);
    }

    private IRoleService _roleService;
    private RoleController _roleController;

    [Test]
    public void should_get_role_by_service_with_dto()
    {
        _roleController.GetRoleBy(new RoleRequest
        {
            Level = 1,
            Weapon = "any-weapon"
        });

        _roleService.Received().GenerateRoleBy(Arg.Is<RoleDto>(r => r.Level == 1 && r.Weapon == Weapon.Unkown));
    }

    [Test]
    public void should_get_role_with_api_response()
    {
        _roleService.GenerateRoleBy(Arg.Any<RoleDto>()).Returns(new RoleDomain()
        {
            Level = 10,
            Weapon = Weapon.Sword,
            Job = Job.Warrior
        });
        
        var response = _roleController.GetRoleBy(new RoleRequest()
        {
            Level = 10,
            Weapon = "Sword"
        });
        
        response.Should().BeEquivalentTo( new RoleResponse()
        {
            Status = ApiStatus.Success,
            Data = new RoleDomain() {
                Level = 10,
                Weapon = Weapon.Sword,
                Job = Job.Warrior
            }
        });
    }

}