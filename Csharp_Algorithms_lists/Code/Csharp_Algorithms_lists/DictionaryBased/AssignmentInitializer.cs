using Csharp_Algorithms_lists.DataModel;

namespace Csharp_Algorithms_lists.DictionaryBased;

public class AssignmentInitializer
{
    private readonly int _count;
    private readonly int _jobsCnt;

    public AssignmentInitializer(int count, int jobsCnt)
    {
        _count = count;
        _jobsCnt = jobsCnt;
    }

    public Dictionary<int, Assignemnt> CreateAssigns()
    {
        var assignments = new Dictionary<int, Assignemnt>();

        for (var i = 0; i < _count; i++)
        {
            var assignment = new Assignemnt
            {
                Id = 10000 + i,
                InternalId = Guid.NewGuid(),
                Name = $"DummyAssignment {i}",
                Description = "Simple descp.",
                Contributor = GenerateContributerList(),
                RelatedJob = SetRelatedJob()
            };
            assignments.Add(assignment.Id, assignment);
        }

        return assignments;
    }

    private int SetRelatedJob()
    {
        var rnd = new Random();
        return rnd.Next(1001, 1001+_jobsCnt);
    }

    private List<int> GenerateContributerList()
    {
        var contributors = new List<int>();

        var rnd = new Random();
        var i = rnd.Next(1, 5);

        for (var j = 0; j < i; j++)
        {
            contributors.Add(rnd.Next(1010, 1110));
        }

        return contributors;
    }
}