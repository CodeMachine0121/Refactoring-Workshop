namespace Intern;

public class RoleService : IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        var roleFilters = new List<IRoleFilter>()
        {
            new MagicianFilter(),
            new WarriorFilter(),
            new BeginnerFilter()
        };

        return dto.ToRoleDomain(roleFilters.First(x => x.IsMatch(dto)).GetJob());
    }
}