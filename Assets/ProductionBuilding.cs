using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProductionBuilding : MonoBehaviour
{
    public Resource resourceType;
    public float productionTime = 5f;
    public Button productionButton;
    public Slider productionSlider;
    private ResourceBank resourceBank;

    private void Start()
    {
        resourceBank = FindObjectOfType<ResourceBank>();
        productionButton.onClick.AddListener(StartProduction);
        productionSlider.gameObject.SetActive(false);
    }

    private void StartProduction()
    {
        productionButton.interactable = false;
        productionSlider.gameObject.SetActive(true);
        StartCoroutine(ProduceResource());
    }

    private IEnumerator ProduceResource()
    {
        int prodLevel = resourceBank.GetProductionLevel(resourceType);
        float modifiedProductionTime = productionTime * (1 - prodLevel / 100f);
    
        float elapsed = 0f;
        productionSlider.value = 0f;

        while (elapsed < modifiedProductionTime)
        {
            elapsed += Time.deltaTime;
            productionSlider.value = elapsed / modifiedProductionTime;
            yield return null;
        }

        resourceBank.ChangeResource(resourceType, 1);
        productionSlider.gameObject.SetActive(false);
        productionButton.interactable = true;
    }

}