using Csharp_Algorithms_lists.DataModel;

namespace Csharp_Algorithms_lists.DictionaryBased;

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

    public Dictionary<int,Job> CreateJobs()
    {
        var jobs = new Dictionary<int, Job>();
        
        for (var i = 0; i < _count; i++)
        {
            var job = new Job
            {
                Id = 1001 + i,
                InternalId = Guid.NewGuid(),
                Name = $"Job Nr. {i}",
                Description = "Simple descrp.",
                RelatedAssingments = new List<int>()
            };
            
            jobs.Add(job.Id, job);
        }
        return jobs;
    }
}