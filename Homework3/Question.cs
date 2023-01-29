namespace Homework3
{
    class Question
    {

        public int question1(int[] num)
        {
            int total = 0;
            int counter = 0;

            while (counter != num.Length)
            {
                total = total + num[counter];
                counter++;
            }

            return total;
        }

        public int[] question2(ref int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;
            }

            return num;
        }

        public void question3(int[,] num, ref int x, ref int y)
        {
            int big = 0;

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (big < num[i, j])
                    {
                        x = i;
                        y = j;
                        big = num[i, j];
                    }
                }
            }
        }

        public bool question4(int[][] arrayJag, int target)
        {
            bool result = false;

            for (int i = 0; i < arrayJag.Length; i++)
            {
                for (int j = 0; j < arrayJag[i].Length; j++)
                {
                    if (arrayJag[i][j] == target)
                    {
                        result = true;
                        return result;
                    }
                }
            }

            return result;
        }

        public double question5()
        {
            double mg = 25.5;
            double gc = 2.22;
            double money = 35.0;

            double gallon = 0;

            double travel = 0;

            while (money >= gc)
            {
                gallon++;
                money = money - gc;
            }

            travel = gallon * mg;

            return travel;
        }

        public double question6()
        {
            Console.Write("Amount of money: ");
            double money = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cost of Gas: ");
            double gc = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vehicle mpg: ");
            double mg = Convert.ToDouble(Console.ReadLine());

            double travel = 0;
            double gallon = 0;

            while (money >= gc)
            {
                gallon++;
                money = money - gc;
            }

            travel = gallon * mg;

            return travel;
        }

        public double question1(double[] num)
        {
            double total = 0.0;

            for (int i = 0; i < num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }

        public double [] question2(ref double[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1.0;
            }

            return num;
        }
    }
}