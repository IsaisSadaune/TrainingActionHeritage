using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas ui;

    [SerializeField] private TextMeshProUGUI animalName;
    [SerializeField] private TextMeshProUGUI animalType;
    [SerializeField] private GameObject prefabButton;
    private List<GameObject> buttons = new();

    private void Awake()
    {
        ui.gameObject.SetActive(false);
    }

    public void ActivateUI()
    {
        foreach (GameObject gameObject in buttons) Destroy(gameObject);
        ui.gameObject.SetActive(true);
    }
    public void DesactivateUI()
    {
        ui.gameObject.SetActive(false);
    }

    public void SetAnimal(AnimalBehaviour animal)
    {
        animalName.text = animal.AnimalName;
        animalType.text = animal.AnimalType;

        foreach(Action a in animal.MethodePourPlusTard)
        {
            GameObject g = Instantiate(prefabButton, transform);
            buttons.Add(g);
            Button b = g.GetComponent<Button>();
            b.GetComponentInChildren<TextMeshProUGUI>().text = a.Method.Name;
            b.onClick.AddListener(a.Invoke);
        }
    }

    public void CloseTab()
    {
        AnimalsManager.AManager.CloseTab();
    }

}
