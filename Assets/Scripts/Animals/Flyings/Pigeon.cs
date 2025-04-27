using UnityEngine;

public class Pigeon : FlyingBehaviour
{
    private void Caca()
    {
        Debug.Log(":(");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Caca);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "pigeon";
    }
}
