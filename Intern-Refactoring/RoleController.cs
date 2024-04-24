using Intern;
using Intern_Refactoring;
using Microsoft.AspNetCore.Mvc;

public class RoleController(IRoleService roleService) : ControllerBase
{

    public RoleResponse GetRoleBy(RoleRequest request)
    {
        var domain = roleService.GenerateRoleBy(new RoleDto());

        return new RoleResponse()
        {
            Status = ApiStatus.Success,
            Data = domain
        };
    }
}