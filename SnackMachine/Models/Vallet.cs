namespace SnackMachine.Models;

public class Vallet
{
    public int MoneyCount { get; set; }

    public Vallet(int count)
    {
        MoneyCount = count;
    }
}