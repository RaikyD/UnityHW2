using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    private Dictionary<Resource, ObservableInt> resources;
    private Dictionary<Resource, int> productionLevels;

    private void Awake()
    {
        resources = new Dictionary<Resource, ObservableInt>
        {
            { Resource.Humans, new ObservableInt(10) },
            { Resource.Food, new ObservableInt(5) },
            { Resource.Wood, new ObservableInt(5) },
            { Resource.Stone, new ObservableInt(0) },
            { Resource.Gold, new ObservableInt(0) }
        };
        
        productionLevels = new Dictionary<Resource, int>
        {
            { Resource.Humans, 0 },
            { Resource.Food, 0 },
            { Resource.Wood, 0 },
            { Resource.Stone, 0 },
            { Resource.Gold, 0 }
        };
    }
    
    public void ChangeResource(Resource r, int value)
    {
        if (resources.ContainsKey(r))
        {
            resources[r].Value += value;
        }
    }
    
    public ObservableInt GetResource(Resource r)
    {
        return resources.ContainsKey(r) ? resources[r] : null;
    }
    
    public int GetProductionLevel(Resource r)
    {
        return productionLevels.ContainsKey(r) ? productionLevels[r] : 0;
    }
    
    public void IncreaseProductionLevel(Resource r)
    {
        if (productionLevels.ContainsKey(r))
        {
            productionLevels[r] += 1;
        }
    }
}