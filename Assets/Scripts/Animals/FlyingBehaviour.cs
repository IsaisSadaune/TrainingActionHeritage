using UnityEngine;

public abstract class FlyingBehaviour : AnimalBehaviour
{
    private void Voler()
    {
        Debug.Log("cuicui");
    }
    private void Planer()
    {
        Debug.Log("fiouuuush");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Voler);
        MethodePourPlusTard.Add(this.Planer);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "mammal";
    }
}
