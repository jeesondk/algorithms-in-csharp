using Csharp_Algorithms_lists.DataModel;
using System.Linq;

namespace Csharp_Algorithms_lists.DictionaryBased;

public class JobAssignmentLinker
{
    private readonly Dictionary<int, Job> _jobs;
    private readonly Dictionary<int, Assignemnt> _assignemnts;

    public JobAssignmentLinker(Dictionary<int, Job> jobs, Dictionary<int, Assignemnt> assignemnts)
    {
        _jobs = jobs;
        _assignemnts = assignemnts;
    }

    public void LinkItems()
    {
        foreach (var assignemnt in _assignemnts)
        {
            var relatedItems = _jobs.GetValueOrDefault(assignemnt.Value.RelatedJob).RelatedAssingments;
            relatedItems.Add(assignemnt.Key);
        }
    }
}