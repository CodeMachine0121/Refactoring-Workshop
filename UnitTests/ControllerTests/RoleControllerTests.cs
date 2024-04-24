using Intern;
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

        _roleService.Received().GenerateRoleBy(Arg.Any<RoleDto>());
    }

}