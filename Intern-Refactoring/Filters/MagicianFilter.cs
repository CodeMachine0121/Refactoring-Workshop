namespace Intern;

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