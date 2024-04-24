namespace Intern;

public class WarriorFilter : IRoleFilter
{
    public bool IsMatch(RoleDto dto)
    {
        return dto.Level >= 10 && dto.Weapon == Weapon.Sword;
    }

    public Job GetJob()
    {
        return Job.Warrior;
    }
}