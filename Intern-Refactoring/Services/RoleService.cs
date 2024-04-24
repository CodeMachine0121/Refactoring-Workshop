namespace Intern;

public class RoleService: IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        if (IsMatchMagician(dto))
        {
            return GetRoleDomain(dto, Job.Magician);
        }
        
        if (IsMatchWarrior(dto))
        {
            return GetRoleDomain(dto, Job.Warrior);
        }

        return GetRoleDomain(dto, Job.Beginner);
    }

    private static bool IsMatchWarrior(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Sword;
    }

    private static RoleDomain GetRoleDomain(RoleDto dto, Job magician)
    {
        return new RoleDomain()
        {
            Level = dto.Level,
            Weapon = dto.Weapon,
            Job = magician
        };
    }

    private static bool IsMatchMagician(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Stick;
    }
}
