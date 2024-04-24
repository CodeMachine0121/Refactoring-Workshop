using Intern;
using Intern_Refactoring;
using Microsoft.AspNetCore.Mvc;

public class RoleController(IRoleService roleService) : ControllerBase
{

    public RoleResponse GetRoleBy(RoleRequest request)
    {
        var domain = roleService.GenerateRoleBy(ToRoleDto(request));

        return new RoleResponse()
        {
            Status = ApiStatus.Success,
            Data = domain
        };
    }

    private static RoleDto ToRoleDto(RoleRequest request)
    {
        return new RoleDto()
        {
            Level = request.Level,
            Weapon = Enum.TryParse<Weapon>(request.Weapon, out var weapon) ? weapon : Weapon.Unkown
        };
    }
}