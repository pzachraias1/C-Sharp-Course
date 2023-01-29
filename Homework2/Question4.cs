namespace Homework2
{
    internal class Question4
    {
        public void myMethod()
        {
            string s = "";
            double num = 0;
            double sum = 0;
            int counter = 0;
            Boolean flag = true;
            while (flag)
            {
                if (counter == 5)
                {
                    flag = false;
                }
                else
                {
                    Console.Write("Enter a number: ");
                    s = Console.ReadLine();
                    if (double.TryParse(s, out num))
                    {
                        sum += num;
                        counter++;
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.Write("Please enter a number:");
                        s = Console.ReadLine();
                    }
                }
            }
        }
    }
}