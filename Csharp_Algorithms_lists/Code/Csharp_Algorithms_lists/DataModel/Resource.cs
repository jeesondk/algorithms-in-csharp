namespace Csharp_Algorithms_lists.DataModel;

public class Resource
{
    public int Id { get; set; }
    public Guid InternalId { get; set; }
    public string Name { get; set; }
    public int Cost { get; set; }
    public  ResourceSkills Skills{ get; set; }
}