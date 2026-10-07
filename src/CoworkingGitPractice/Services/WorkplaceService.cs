using CoworkingGitPractice.Models;

namespace CoworkingGitPractice.Services;

public class WorkplaceService
{
    private readonly List<Workplace> _workplaces = [];

    public void Add(Workplace workplace)
    {
        _workplaces.Add(workplace);
    }

    public IReadOnlyList<Workplace> GetAll()
    {
        return _workplaces;
    }
}
