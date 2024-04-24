namespace Intern;

public class RoleDto
{
    public Weapon Weapon { get; set; }
    public int Level { get; set; }

    public RoleDomain ToRoleDomain(Job magician)
    {
        return new RoleDomain()
        {
            Level = Level,
            Weapon = Weapon,
            Job = magician
        };
    }
}