namespace Intern;

public class RoleRequest
{
    public int Level { get; set; }
    public string Weapon { get; set; }

    public RoleDto ToRoleDto()
    {
        return new RoleDto()
        {
            Level = Level,
            Weapon = Enum.TryParse<Weapon>(Weapon, out var weapon) ? weapon : Intern.Weapon.Unkown
        };
    }
}