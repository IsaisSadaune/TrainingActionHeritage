using UnityEngine;

public class Manta : AquaticBehavor
{
    private void Dard()
    {
        Debug.Log("poison");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Dard);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "Raie Manta";
    }
}
