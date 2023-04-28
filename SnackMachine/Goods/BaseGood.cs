using SnackMachine.Models;

namespace SnackMachine.Goods;

public abstract class BaseGood : IGood 
{
    public int Price { get; set; }
    public int Count { get; set; }
    public string Name { get; set; } = string.Empty;

    public virtual void GiveGood(Vallet vallet)
    {
        Count--;
        vallet.MoneyCount -= Price;
    }
    public abstract void ShowSelectionInfo();
    public virtual bool IsEnoughMoney(Vallet vallet)
    {
        return vallet.MoneyCount >= Price;
    }
    public virtual bool IsEnoughGood()
    {
        return Count > 0;
    }

}