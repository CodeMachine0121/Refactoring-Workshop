namespace Intern;

public class RoleService: IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        if (IsMatchMagician(dto))
        {
            return dto.GetRoleDomain(Job.Magician);
        }
        
        if (IsMatchWarrior(dto))
        {
            return dto.GetRoleDomain(Job.Warrior);
        }

        return dto.GetRoleDomain(Job.Beginner);
    }

    private static bool IsMatchWarrior(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Sword;
    }

    private static bool IsMatchMagician(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Stick;
    }
}
