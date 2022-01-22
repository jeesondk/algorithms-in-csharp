using Csharp_Algorithms_lists.DataModel;

namespace Csharp_Algorithms_lists.ArrayBased;

public class JobInitializer
{
    private readonly int _count;

    public JobInitializer(int count)
    {
        _count = count;
    }

    public JobInitializer()
    {
        _count = 1000;
    }

    public Job[] CreateJobs()
    {
        var jobs = new Job[_count];
        var assignments = new List<int>();
        

        for (var i = 0; i < _count; i++)
        {
            jobs[i] = new Job
            {
                Id = 1001 + i,
                InternalId = Guid.NewGuid(),
                Name = $"Job Nr. {i}",
                Description = "Simple descrp.",
                RelatedAssingments = new List<int>()
            };
        }
        return jobs;
    }

    private List<int> GenerateAssignemtnRelation()
    {
        var assignments = new List<int>();
        var rnd = new Random();
        var i = rnd.Next(3, 10);

        for (var j = 0; j < i; j++)
        {
            assignments.Add(rnd.Next(10000, 10100));
        }

        return assignments;
    }
}