using Project.Tasks;
using Project.EntityFrameworkCore;

namespace Project.Tests.TestData;

public class TestDataBuilder
{
    private readonly ProjectDbContext _context;

    public TestDataBuilder(ProjectDbContext context)
    {
        _context = context;
    }

    public void Build()
    {
        _context.Tasks.AddRange(
            new Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality."),
            new Task("Clean your room") { State = TaskState.Completed }
            );
    }
}