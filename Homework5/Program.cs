namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        Vessel ves = new Vessel();

        Console.WriteLine(ves.Fleet);

        Vessel ves2 = new Vessel("Aloha", "Man-o-War", 5, "Pirate", "South", 66.4, 8);
        Console.WriteLine(ves2.Hull_number);
    }
}
