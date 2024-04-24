using FluentAssertions;
using Intern;
using NUnit.Framework;

namespace TestProject1.ServiceTests;

[TestFixture]
public class RoleServiceTests
{

    [Test]
    public void should_get_beginner()
    {
        var roleService = new RoleService();

        var role = roleService.GenerateRoleBy(new RoleDto
        {
            Weapon = "",
            Level = 1
        });
        
        role.Should().BeEquivalentTo(new RoleDomain()
        {
            Level = 1,
            Weapon = "",
            Job = "Beginner"
        });
    }
    
}