
using SnackMachine.Service;

namespace SnackMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(int.Parse(Console.ReadLine()));
            while (true)
            {
                vendingMachine.Buy(int.Parse(Console.ReadLine()));
            }
        }
    }
}