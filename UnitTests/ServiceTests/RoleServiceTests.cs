using FluentAssertions;
using Intern;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace TestProject1.ServiceTests;

[TestFixture]
public class RoleServiceTests
{
    [SetUp]
    public void SetUp()
    {
        _roleService = new RoleService();
    }

    private RoleService _roleService;

    [Test]
    public void should_get_beginner()
    {
        var role = _roleService.GenerateRoleBy(new RoleDto
        {
            Weapon = Weapon.Unkown,
            Level = 1
        });

        role.Should().BeEquivalentTo(new RoleDomain()
        {
            Level = 1,
            Weapon = Weapon.Unkown,
            Job = Job.Beginner 
        });
    }

}