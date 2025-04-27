using UnityEngine;

public class CatBehaviour : MammalBehaviour
{

    private void Miauler()
    {
        Debug.Log("miaou");
    }
    protected override void AddAction()
    {
        base.AddAction();
        MethodePourPlusTard.Add(this.Miauler);
    }
    protected override void SetAnimalType()
    {
        AnimalType = "chat";
    }
}
