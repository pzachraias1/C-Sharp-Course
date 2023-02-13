namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Tools t = new Tools();
        Furniture f = new Furniture();

        Console.WriteLine(t.waterResistance + "\t" +f.waterResistance);
    }
}
