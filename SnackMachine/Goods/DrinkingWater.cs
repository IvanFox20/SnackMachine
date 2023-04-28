using SnackMachine.Models;

namespace SnackMachine.Goods;

public class DrinkingWater : BaseGood
{
    public DrinkingWater()
    {
        Price = 2;
        Count = 5;
        Name = "Питьевая вода";
    }
    public override void GiveGood(Vallet vallet)
    {
        Console.WriteLine("Выдана питьевая вода");
        base.GiveGood(vallet);
    }
    
    public override void ShowSelectionInfo()
    {
        Console.WriteLine("Выбрана питьевая вода");
    }
}