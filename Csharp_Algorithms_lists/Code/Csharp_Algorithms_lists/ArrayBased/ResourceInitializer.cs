using Csharp_Algorithms_lists.DataModel;

namespace Csharp_Algorithms_lists.ArrayBased;

public class ResourceInitializer
{
    private readonly int _count;

    public ResourceInitializer(int count)
    {
        _count = count;
    }

    public Resource[] CreateResources()
    {
        var resources = new Resource[_count];

        Array enumVals = Enum.GetValues(typeof(ResourceSkills));
        Random rndSkill = new Random();
        Random rndCost = new Random();
        
        

        for (var i = 0; i < _count; i++)
        {
            resources[i] = new Resource
            {
                Id = 1010 + i,
                InternalId = Guid.NewGuid(),
                Name = $"Random Worker {i}",
                Skills = (ResourceSkills)enumVals.GetValue(rndSkill.Next((enumVals.Length))),
                Cost = rndCost.Next(100, 400)
            };
        }

        return resources;
    }
}