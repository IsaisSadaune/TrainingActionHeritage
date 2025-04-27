using UnityEngine;

public class SeaUrchin : AquaticBehavor
{
    private void Piquer()
    {
        Debug.Log("ouch");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Piquer);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "Oursin";
    }
}
