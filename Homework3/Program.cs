namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Question q = new Question();
        int [,] twoD = new int[,] {{12,33,4,5}, {3,65,8,5}, {12,33,4,9}, {84,5,23,6}};
        int x = 0;
        int y = 0;

        q.question3(twoD, ref x, ref y);

        Console.WriteLine(x + " " + y);
        Console.WriteLine(twoD[x,y]);
    }
}
