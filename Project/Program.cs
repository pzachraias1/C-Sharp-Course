namespace Project;
class Program
{
    static void Main(string[] args)
    {
        var s1 = new Student[50];
        var s2 = new Student[50];
        int counter = 1;
        double num = 0;

        using (StreamReader file = new StreamReader("StudentList.txt"))
        {
            string line;
            int i = 0;

            s1[i] = new Student();
            s2[i] = new Student();
            while ((line = file.ReadLine()) != null)
            {
                int index = line.IndexOf(":");

                //---------------Get the line and get the info------------
                if (line.Contains("First"))
                {
                    s1[i].FirstName = line.Substring(index + 2);
                    s2[i].FirstName = line.Substring(index + 2);
                }
                else if (line.Contains("Last"))
                {
                    s1[i].LastName = line.Substring(index + 2);
                    s2[i].LastName = line.Substring(index + 2);
                }
                else if (line.Contains("Class"))
                {
                    s1[i].Class_Status = line.Substring(index + 2);
                    s2[i].Class_Status = line.Substring(index + 2);
                }
                else if (line.Contains("ID"))
                {
                    s1[i].Student_ID = line.Substring(index + 2);
                    s2[i].Student_ID = line.Substring(index + 2);
                }
                else if (line.Contains("DOB"))
                {
                    s1[i].Dob = line.Substring(index + 2);
                    s2[i].Dob = line.Substring(index + 2);
                }
                else if (line.Contains("GPA"))
                {
                    double gpa = Double.Parse(line.Substring(index + 2));
                    s1[i].Gpa = gpa;
                    s2[i].Gpa = gpa;
                }
                else if (line.Equals(""))
                {
                    i++;
                    s1[i] = new Student();
                    s2[i] = new Student();
                    counter++;
                }
            }
            file.Close();
        }
        for (int i = 0; i < counter; i++){
            Console.WriteLine(i + ".\t" + s1[i].FirstName);
        }
        Sort sor = new Sort(s2, counter);



        //---------TEXT GUI-----------------

        int exit = 0;
        do
        {
            int asw = 0;
            int asw2 = 0;
            int theOtherExit = 0;
            Console.WriteLine();
            Console.Write("Sorting Time Baby:\nPlease Type 1, 2, 3 for your choice.\n1. Last Name\n2. Student ID\n3. GPA\nany number to exit\nChoice: ");
            string line = Console.ReadLine();

            while (theOtherExit == 0)
            {
                if (int.TryParse(line, out asw))
                {
                    asw = asw;
                    theOtherExit++;
                }
                else
                {
                    Console.Write("Please enter an integer: ");
                    line = Console.ReadLine();
                }
            }

            if (asw == 1)
            {
                Console.Write("1. Ascending\n2. Descending\nAnswer: ");
                while (asw2 != 1 && asw2 != 2)
                {
                    theOtherExit = 0;
                    line = Console.ReadLine();
                    while (theOtherExit == 0)
                    {
                        if (int.TryParse(line, out asw2))
                        {
                            asw2 = asw2;
                            theOtherExit++;
                        }
                        else
                        {
                            Console.Write("Please enter an integer: ");
                            line = Console.ReadLine();
                        }
                    }
                    if (asw2 == 1 || asw2 == 2)
                    {

                    }
                    else
                    {
                        Console.Write("Please type 1 or 2: ");
                    }
                }

                if (asw2 == 1)
                {
                    s2 = sor.lastNameSortAs();
                }
                if (asw2 == 2)
                {
                    s2 = sor.lastNameSortDe();
                }
            }

            else if (asw == 2)
            {
                Console.Write("1. Ascending\n2. Descending\nAnswer: ");
                while (asw2 != 1 && asw2 != 2)
                {
                    theOtherExit = 0;
                    line = Console.ReadLine();
                    while (theOtherExit == 0)
                    {
                        if (int.TryParse(line, out asw2))
                        {
                            asw2 = asw2;
                            theOtherExit++;
                        }
                        else
                        {
                            Console.Write("Please enter an integer: ");
                            line = Console.ReadLine();
                        }
                    }
                    if (asw2 == 1 || asw2 == 2)
                    {

                    }
                    else
                    {
                        Console.Write("Please type 1 or 2: ");
                    }
                }

                if (asw2 == 1)
                {
                    s2 = sor.idSortAs();
                }
                if (asw2 == 2)
                {
                    s2 = sor.idSortDe();
                }
            }


            else if (asw == 3)
            {
                Console.Write("1. Ascending\n2. Descending\nAnswer: ");
                while (asw2 != 1 && asw2 != 2)
                {
                    theOtherExit = 0;
                    line = Console.ReadLine();
                    while (theOtherExit == 0)
                    {
                        if (int.TryParse(line, out asw2))
                        {
                            asw2 = asw2;
                            theOtherExit++;
                        }
                        else
                        {
                            Console.Write("Please enter an integer: ");
                            line = Console.ReadLine();
                        }
                    }
                    if (asw2 == 1 || asw2 == 2)
                    {

                    }
                    else
                    {
                        Console.Write("Please type 1 or 2: ");
                    }
                }

                if (asw2 == 1)
                {
                    s2 = sor.gpaSortAs();
                }
                if (asw2 == 2)
                {
                    s2 = sor.gpaSortDe();
                }
            }

            else
            {
                break;
            }

            Console.WriteLine("------------------Original----------------");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Last Name: " + s1[i].LastName + "\tID: " + s1[i].Student_ID + "\tGPA: " + s1[i].Gpa);
            }

            Console.WriteLine("------------------Sorted----------------");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Last Name: " + s2[i].LastName + "\tID: " + s2[i].Student_ID + "\tGPA: " + s2[i].Gpa);
            }

        } while (exit == 0);

    }

    public static void inputValidation(string s, int result)
    {
        int num = 0;
        if (int.TryParse(s, out num))
        {
            result = num;
        }
        else
        {
            Console.Write("Please enter an integer: ");
            s = Console.ReadLine();
            inputValidation(s, result);
        }
    }
}
