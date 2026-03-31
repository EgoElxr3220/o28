using o28;

internal class Program
{
    private static void Main(string[] args)
    {
        var intBox = new StorageBox<int>();
        intBox.Store(580);
        var item1 = intBox.Retrieve();
        Console.WriteLine(item1.ToString());

        var stringBox = new StorageBox<string>();
        stringBox.Store("Your mom");
        var item2 = stringBox.Retrieve();
        Console.WriteLine(item2.ToString());
    }
}