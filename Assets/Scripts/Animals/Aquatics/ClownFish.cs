using UnityEngine;

public class ClownFish : AquaticBehavor
{
    private void Joker()
    {
        Debug.Log("On vit dans une soci�t�");
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
