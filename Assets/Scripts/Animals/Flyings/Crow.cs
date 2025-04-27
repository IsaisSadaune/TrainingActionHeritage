using UnityEngine;

public class Crow : FlyingBehaviour
{
    private void Reflechir()
    {
        Debug.Log(":thinking:");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Reflechir);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "Corbeau";
    }
}
