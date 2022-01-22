namespace Csharp_Algorithms_lists.DataModel;

public class Job
{
    public int Id { get; set; }
    public Guid InternalId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<int> RelatedAssingments { get; set; }
}