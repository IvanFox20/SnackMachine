using SnackMachine.Models;

namespace SnackMachine.Goods;

public interface IGood
{
    public int Price { get; set; }
    public int Count { get; set; }
    public string Name { get; set; }
    public void GiveGood(Vallet vallet);
    public void ShowSelectionInfo();

    public bool IsEnoughMoney(Vallet vallet);
    public bool IsEnoughGood();
}