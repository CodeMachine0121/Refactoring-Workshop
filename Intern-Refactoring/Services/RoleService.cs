namespace Intern;

public class RoleService: IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        var roleFilters = new List<IRoleFilter>()
        {
            new MagicianFilter(),
            new WarriorFilter(),
            new BeginnerFilter(),
        };
        
        foreach (var filter in roleFilters)
        {
            if (filter.IsMatch(dto))
            {
                return dto.ToRoleDomain(filter.GetJob());
            }
        }
        

        return dto.ToRoleDomain(Job.Beginner);
    }
}