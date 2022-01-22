using Csharp_Algorithms_lists.DataModel;

namespace Csharp_Algorithms_lists.DictionaryBased;

public class ResourceInitializer
{
    private readonly int _count;

    public ResourceInitializer(int count)
    {
        _count = count;
    }
    
    public Dictionary<int, Resource> CreateResources()
    {
        var resources = new Dictionary<int, Resource>();

        var enumValues = Enum.GetValues(typeof(ResourceSkills));
        var rnd = new Random();
        
        for (var i = 0; i < _count; i++)
        {
            var resource = new Resource
            {
                Id = 1010 + i,
                InternalId = Guid.NewGuid(),
                Name = $"Random Worker {i}",
                Skills = (ResourceSkills)enumValues.GetValue(rnd.Next((enumValues.Length))),
                Cost = rnd.Next(100, 400)
            };
            resources.Add(resource.Id, resource);
        }

        return resources;
    }
}