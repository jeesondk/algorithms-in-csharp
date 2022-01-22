using Csharp_Algorithms_lists.DataModel;

namespace Csharp_Algorithms_lists.ArrayBased;

public class JobAssignmentLinker
{
    private readonly Job[] _jobs;
    private readonly Assignemnt[] _assingment;
    
    public JobAssignmentLinker(Job[] jobs, Assignemnt[] assingment)
    {
        _jobs = jobs;
        _assingment = assingment;
    }

    public void LinkItems()
    {
        foreach (var assignemnt in _assingment)
        {
            var relatedItems = _jobs.FirstOrDefault(j => j.Id == assignemnt.RelatedJob).RelatedAssingments;
            relatedItems.Add(assignemnt.Id);
        }
    }
}