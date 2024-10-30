using TMPro;
using UnityEngine;

public class ResourceVisual : MonoBehaviour
{
    public Resource resourceType;
    public TextMeshProUGUI resourceText;
    private ResourceBank _resourceBank;

    private void Start()
    {
        _resourceBank = FindObjectOfType<ResourceBank>();
        UpdateResourceText();
    }

    private void UpdateResourceText()
    {
        resourceText.text = _resourceBank.GetResource(resourceType).Value.ToString();
    }

    private void Update()
    {
        UpdateResourceText();
    }
}