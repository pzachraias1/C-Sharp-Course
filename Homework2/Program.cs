

namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Program prog = new Program();
        Question6 q = new Question6();

        q.myMethod();
    }
}

// static int numInput = 0;
// double numInput2 = 0.0;


// Program program = new Program();
// Console.Write("Please Enter 1 for Number input or 2 for Letter input or Enter anything to stop: ");
// string input = Console.ReadLine();

// if (input == "1")
// {
//     program.question2a();
// }
// else if (input == "2")
// {
//     program.question2b();
// }
// else
// {
//     Console.WriteLine("Ending Program");
// }



// public void question2a()
// {
//     Program program = new Program();
//     double[] inputArray = new double[4];
//     string num = "";
//     Console.WriteLine("Input 4 number please.");
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         Console.Write(i + 1 + ". ");
//         num = Console.ReadLine();
//         program.numValidation2(num, inputArray, i);
//     }

//     double average = 0.0;
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         average += inputArray[i];
//     }
//     average = average / inputArray.Length;

//     Console.WriteLine("Average = " + average);
// }

// public void numValidation2(string s, double[] arr, int i)
// {
//     Program program = new Program();
//     if (double.TryParse(s, out program.numInput2))
//     {
//         arr[i] = program.numInput2;
//     }
//     else
//     {
//         Console.Write("Please enter a number: ");
//         s = Console.ReadLine();
//         numValidation2(s, arr, i);
//     }
// }

// public void question2b()
// {
//     Program program = new Program();
//     char[] letter = new char[3];
//     string s = "";
//     Console.WriteLine("Please Enter 3 Letters");
//     for (int i = 0; i < letter.Length; i++)
//     {
//         Console.Write(i + 1 + ". ");
//         s = Console.ReadLine();
//         letterValidation(s, letter, i);
//     }

//     for (int i = letter.Length - 1; i >= 0; i--)
//     {
//         Console.Write(letter[i]);
//     }
//     Console.WriteLine("");
// }

// public void letterValidation(string s, char[] c, int i)
// {
//     double d = 0;
//     if (double.TryParse(s, out d))
//     {
//         Console.Write("Please enter a letter: ");
//         s = Console.ReadLine();
//         letterValidation(s, c, i);
//     }
//     else
//     {
//         c[i] = s[0];
//     }
// }


// static void question1()
// {
//     Console.Write("Enter a number: ");
//     string num = Console.ReadLine();
//     numValidation(num);
// }

// static void numValidation(string s)
// {
//     if (int.TryParse(s, out numInput))
//     {
//         if (numInput % 2 == 0)
//         {
//             Console.WriteLine(numInput + " is an Even Number");
//         }
//         else
//         {
//             Console.WriteLine(numInput + " is an Odd Number");
//         }
//     }
//     else
//     {
//         Console.Write("Please enter a number: ");
//         s = Console.ReadLine();
//         numValidation(s);
//     }
// }