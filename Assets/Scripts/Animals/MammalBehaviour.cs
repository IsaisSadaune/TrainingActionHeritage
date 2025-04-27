
using UnityEngine;
public abstract class MammalBehaviour : AnimalBehaviour
{
    private void Allaiter()
    {
        Debug.Log("lait");
    }
    private void PertePoils()
    {
        Debug.Log("perte de poils");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Allaiter);
        MethodePourPlusTard.Add(this.PertePoils);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "mammal";
    }
}
