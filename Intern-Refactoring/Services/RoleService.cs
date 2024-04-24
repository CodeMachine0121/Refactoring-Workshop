namespace Intern;

public class RoleService: IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        var roleFilters = new List<IRoleFilter>()
        {
            new MagicianFilter(),
        };
        
        foreach (var filter in roleFilters)
        {
            if (filter.IsMatch(dto))
            {
                return dto.ToRoleDomain(filter.GetJob());
            }
        }
        
        if (IsMatchWarrior(dto))
        {
            return dto.ToRoleDomain(Job.Warrior);
        }

        return dto.ToRoleDomain(Job.Beginner);
    }

    private static bool IsMatchWarrior(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Sword;
    }

}


public class MagicianFilter : IRoleFilter
{
    public bool IsMatch(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Stick;
    }

    public Job GetJob()
    {
       return Job.Magician ;
    }
}

public interface IRoleFilter
{
    bool IsMatch(RoleDto dto);
    Job GetJob();
}
