using UnityEngine;

public class Bat : MammalBehaviour
{
    private void BoireSang()
    {
        Debug.Log("slurp");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.BoireSang);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "Chauve-Souris";
    }
}
