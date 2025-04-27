using System.Collections.Generic;
using UnityEngine;

public class AnimalsManager : MonoBehaviour
{
    private static AnimalsManager animalsManager;
    public static AnimalsManager AManager => animalsManager;

    private void Awake()
    {
        if (animalsManager != null && animalsManager != this) Destroy(this.gameObject);
        else animalsManager = this;
        DontDestroyOnLoad(this.gameObject);
    }



    [SerializeField] private List<Vector3> spawnPoints = new();
    [SerializeField] private List<AnimalBehaviour> animalPrefab;
    [SerializeField] private UIManager uiManager;

    private GameObject activeAnimal;


    void Start()
    {
        AnimalBehaviour a;
        foreach (Vector3 v in spawnPoints)
        {
            int i = Random.Range(0, animalPrefab.Count);
            a = Instantiate(animalPrefab[i], v, animalPrefab[i].transform.rotation);
            a.SetName("animal " + v.ToString());
        }
    }

    public void SetActiveAnimal(AnimalBehaviour animal)
    {
        activeAnimal = animal.gameObject;
        uiManager.ActivateUI();
        uiManager.SetAnimal(animal);
    }

    public void CloseTab()
    {
        uiManager.DesactivateUI();
    }

}
