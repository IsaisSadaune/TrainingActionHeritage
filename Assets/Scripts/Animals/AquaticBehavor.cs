using UnityEngine;

public abstract class AquaticBehavor : AnimalBehaviour
{
    public void Nager()
    {
        Debug.Log("glouglou");
    }
    public void Plonger()
    {
        Debug.Log("glouglouglouuuuuuuuuuuuuuuuuu");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Nager);
        MethodePourPlusTard.Add(this.Plonger);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "aquatic";
    }
}
