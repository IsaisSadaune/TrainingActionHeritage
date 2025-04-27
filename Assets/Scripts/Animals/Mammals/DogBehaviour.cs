using UnityEngine;
using System;

public class DogBehaviour : MammalBehaviour
{
    private void Aboyer()
    {
        Debug.Log("ouaf");
    }

    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Aboyer);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "chien";
    }
}
