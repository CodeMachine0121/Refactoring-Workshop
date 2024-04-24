namespace Intern;

public class RoleService: IRoleService
{
    public RoleDomain GenerateRoleBy(RoleDto dto)
    {
        return new RoleDomain()
        {
            Level = dto.Level,
            Weapon = dto.Weapon,
            Job = Job.Beginner
        };
    }
}
