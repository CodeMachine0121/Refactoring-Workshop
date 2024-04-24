namespace Intern;

public interface IRoleFilter
{
    bool IsMatch(RoleDto dto);
    Job GetJob();
}