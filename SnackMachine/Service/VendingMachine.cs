using SnackMachine.Goods;
using SnackMachine.Models;

namespace SnackMachine.Service;

public class VendingMachine //Стратегия, возможно Flyweight
{
    private readonly Vallet _vallet;

    private readonly IGood[] _goods = new IGood[]
    {
        new ChocolateBar(),
        new Snack(),
        new DrinkingWater()
    };

    public VendingMachine()
    {
        _vallet = new Vallet(0);
    }

    public void InsertMoney(int count)
    {
        _vallet.MoneyCount += count;
        GetGoodList();
    }

    public void Buy(int goodId)
    {
        IGood good = _goods[goodId];
        if (good.IsEnoughGood() && good.IsEnoughMoney(_vallet))
        {
            good.GiveGood(_vallet);
        }
        GetGoodList();
    }

    private void GetGoodList()
    {
        for (int i = 0;i < 3;i++)
        {
            IGood good = _goods[i];
            if (good.IsEnoughGood() && good.IsEnoughMoney(_vallet))
            {
                Console.WriteLine($"[{i}] {good.Name}, количество: {good.Count}, цена: {good.Price} ");
            }
        }
        Console.WriteLine($"Остаток средств: {_vallet.MoneyCount}");
    }
}