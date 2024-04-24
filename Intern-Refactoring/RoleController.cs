using Intern;
using Intern_Refactoring;
using Microsoft.AspNetCore.Mvc;

public class RoleController(IRoleService roleService) : ControllerBase
{

    public RoleResponse GetRoleBy(RoleRequest request)
    {
        roleService.GenerateRoleBy(new RoleDto());
        return new RoleResponse();
    }
}