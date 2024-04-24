namespace Intern;

public class RoleService: IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        if (dto.Level >= 10 && dto.Weapon == Weapon.Sword)
        {
            return new RoleDomain()
            {
                Level = dto.Level,
                Weapon = dto.Weapon,
                Job = Job.Warrior
            };
        }

        return new RoleDomain()
        {
            Level = dto.Level,
            Weapon = dto.Weapon,
            Job = Job.Beginner
        };
    }
}
