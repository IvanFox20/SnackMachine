using SnackMachine.Models;

namespace SnackMachine.Goods;

public class Snack : BaseGood
{
    public Snack()
    {
        Price = 3;
        Count = 5;
        Name = "Снэк";
    }
    public override void GiveGood(Vallet vallet)
    {
        Console.WriteLine("Выдан снэк");
        base.GiveGood(vallet);
    }

    public override void ShowSelectionInfo()
    {
        Console.WriteLine("Выбран снэк");
    }
}