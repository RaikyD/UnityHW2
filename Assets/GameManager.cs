using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ResourceBank resourceBank;

    private void Awake()
    {
        resourceBank = FindObjectOfType<ResourceBank>();
    }
}