namespace Intern;

public class BeginnerFilter : IRoleFilter
{
    public bool IsMatch(RoleDto dto)
    {
        return true;
    }

    public Job GetJob()
    {
        return Job.Beginner;
    }
}