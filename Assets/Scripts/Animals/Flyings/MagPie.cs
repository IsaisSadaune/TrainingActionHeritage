using UnityEngine;

public class MagPie : FlyingBehaviour
{
    private void Vol()
    {
        Debug.Log("Stealth : 100");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Vol);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "Pie";
    }
}
