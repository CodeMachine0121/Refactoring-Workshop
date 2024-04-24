using FluentAssertions;
using Intern;
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

    [Test]
    public void should_get_warrior()
    {
        var role = _roleService.GenerateRoleBy(new RoleDto
        {
            Weapon = Weapon.Sword,
            Level = 10
        });

        role.Should().BeEquivalentTo(new RoleDomain()
        {
            Level = 10,
            Weapon = Weapon.Sword,
            Job = Job.Warrior
        });
    }

}