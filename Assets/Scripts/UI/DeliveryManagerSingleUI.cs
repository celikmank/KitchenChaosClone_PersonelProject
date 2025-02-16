using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryManagerSingleUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI recipeNameText;
    [SerializeField] private  Transform iconContainer;
    [SerializeField] private  Transform iconTemplate;

    private void Awake()
    {
        iconTemplate.gameObject.SetActive(false);
    }

    public void SetRecipeSo(RecipeSO recipeSO)
    {
        recipeNameText.text = recipeSO.recipeName;

        foreach (Transform child in iconContainer)
        {
            if (child ==iconTemplate)continue;
            {
             Destroy(child.gameObject);   
            }
        }

        foreach (KitchenObjectSO kitchenObjectSo in recipeSO.kitchenObjectsSoList)
        {
          Transform iconTransform= Instantiate(iconTemplate, iconContainer);
          iconTransform.gameObject.SetActive(true);
          iconTransform.GetComponent<Image>().sprite = kitchenObjectSo.sprite;
        } 
    }
}
