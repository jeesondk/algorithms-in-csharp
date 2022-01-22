namespace Csharp_Algorithms_lists.DataModel;

public class Assignemnt
{
    public int Id { get; set; }
    public Guid InternalId { get; set; }
    public int RelatedJob { get; set; }
    public String Name { get; set; }
    public string Description { get; set; }
    public List<int> Contributor { get; set; }
}