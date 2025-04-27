using UnityEngine;

using System;
using System.Collections.Generic;
public class HorseBehaviour : MammalBehaviour
{
    private void Ruer()
    {
        Debug.Log("cataclop");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Ruer);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "horse";
    }
}
