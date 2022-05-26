using BookletCore;

namespace BookletMain
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!!\n");

            var store = new Store();
            store.MyMethod();
            Console.Write($"Store number is {store.StoreNumber}");
        }
    };
}