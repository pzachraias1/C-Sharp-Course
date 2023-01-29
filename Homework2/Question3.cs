namespace Homework2
{
    internal class Question3
    {

        int age = 0;
        public void myMethod()
        {
            Console.Write("Enter your age: ");
            string input = "";
            input = Console.ReadLine();
            Validation(input);

            int day = age * 365;
            Console.WriteLine(day);

            switch (day)
            {
                case <= 3500:
                    Console.WriteLine("Child");
                    break;
                case <= 6750:
                    Console.WriteLine("Young Adult");
                    break;
                case <= 10950:
                    Console.WriteLine("Adult");
                    break;
                case <= 14600:
                    Console.WriteLine("Mid-life Crisis");
                    break;
                case <= 18250:
                    Console.WriteLine("Getting upthere");
                    break;
                case > 18250:
                    Console.WriteLine("Retired, hopefully");
                    break;
                default:
                    Console.WriteLine("Did not work");
                    break;
            }
        }

        public void Validation(string input)
        {
            if (int.TryParse(input, out age))
            {
                age = int.Parse(input);
            }
            else
            {
                Console.Write("Please enter an integer: ");
                input = Console.ReadLine();
                Validation(input);
            }
        }

    }
}