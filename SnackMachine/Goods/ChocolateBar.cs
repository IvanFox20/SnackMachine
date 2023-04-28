using SnackMachine.Models;

namespace SnackMachine.Goods;

public class ChocolateBar : BaseGood
{
    public ChocolateBar()
    {
        Price = 1;
        Count = 5;
        Name = "Шоколадный батончик";
    }
    public override void GiveGood(Vallet vallet)
    {
        Console.WriteLine("Выдан шоколадный батончик");
        base.GiveGood(vallet);
    }
    public override void ShowSelectionInfo()
    {
        Console.WriteLine("Выбран шоколадный батончик");
    }
    
    
}