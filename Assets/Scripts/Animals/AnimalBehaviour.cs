using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class AnimalBehaviour : MonoBehaviour
{
    public string AnimalType { get; protected set; }
    public string AnimalName { get; protected set; }

    public List<Action> MethodePourPlusTard = new();

    protected virtual void Awake()
    {
        AddAction();
        SetAnimalType();
    }

    protected virtual void SetAnimalType()
    {
        AnimalType = "animal";
    }

    private void OnMouseDown()
    {
        AnimalsManager.AManager.SetActiveAnimal(this);
    }

    public void SetName(string s) => AnimalName = s;

    private void Manger()
    {
        Debug.Log("Manger");
    }
    private void SeDeplacer()
    {
        Debug.Log("Déplacement");
    }

    protected virtual void AddAction()
    {
        MethodePourPlusTard.Add(this.Manger);
        MethodePourPlusTard.Add(this.SeDeplacer);
    }
}
