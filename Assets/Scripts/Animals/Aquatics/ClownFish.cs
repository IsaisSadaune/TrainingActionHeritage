using UnityEngine;

public class ClownFish : AquaticBehavor
{
    private void Joker()
    {
        Debug.Log("On vit dans une société");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Joker);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "Poisson-Clown";
    }
}
