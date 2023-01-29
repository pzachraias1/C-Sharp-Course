namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Question q = new Question();
        
       double [] y = new double[10];

        y = q.question2(ref y);
        double total = q.question1(y);

        Console.WriteLine(total);

        for(int i = 0; i < y.Length; i++){
            Console.WriteLine(y[i]);
        }
    }
}
