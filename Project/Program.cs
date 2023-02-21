namespace Project;
class Program
{
    static void Main(string[] args)
    {
        string t1 = "2";
        string t2 = "5";
        Console.WriteLine(t1.CompareTo(t2));
        var s1 = new Student[50];//create an array of Student object.
        var s2 = new Student[50];//Student array object that is going to be the one being sorted out
        int counter = 1;//will be the counter for the number of array object created. starting from 1 as it is initialize to the first thing.
            //using counter instead of Length since Length is equal to 50, and we want to keep track of new object create.

        //using stream reader to read the lines from StudentList.txt
        using (StreamReader file = new StreamReader("StudentList.txt"))
        {
            string line;//will be the line for each of the line in the StudentList.txt
            int i = 0;//be the index for the new object array.

            s1[i] = new Student();//create a new object for original
            s2[i] = new Student();//create a new objec for the mauniplated array.
            while ((line = file.ReadLine()) != null)//will get line from StudentList.txt until no more line
            {
                int index = line.IndexOf(":");//get the index of the colon in that line. If there is any

                //---------------Get the line and get the info------------
                if (line.Contains("First"))//line contain First
                {
                    s1[i].FirstName = line.Substring(index + 2);//set s1 first name
                    s2[i].FirstName = line.Substring(index + 2);//set s2 first name
                }
                else if (line.Contains("Last"))//line contain last
                {
                    s1[i].LastName = line.Substring(index + 2);//set s1 last name
                    s2[i].LastName = line.Substring(index + 2);//set s2 last name
                }
                else if (line.Contains("Class"))//if the line contain class
                {
                    s1[i].Class_Status = line.Substring(index + 2);//set class stutus for s1
                    s2[i].Class_Status = line.Substring(index + 2);//set class status for s2
                }
                else if (line.Contains("ID"))//if the line contain ID
                {
                    s1[i].Student_ID = line.Substring(index + 2);//set the id number of s1
                    s2[i].Student_ID = line.Substring(index + 2);//set the id number for s2
                }
                else if (line.Contains("DOB"))//if the line contain DOB
                {
                    s1[i].Dob = line.Substring(index + 2);//set date of birth for s1
                    s2[i].Dob = line.Substring(index + 2);//set the birth for s2
                }
                else if (line.Contains("GPA"))//if the line contain gpa
                {
                    double gpa = Double.Parse(line.Substring(index + 2));//convert the line from string to double
                    s1[i].Gpa = gpa;//set the gpa for s1
                    s2[i].Gpa = gpa;//set the gpa for s2
                }
                else if (line.Equals(""))//if the line is nothing, then do the following
                {
                    i++;//moving to the next index of the array. all of the field in object has been filled
                    s1[i] = new Student();//create a new object student for original array.
                    s2[i] = new Student();//create a new object student for manuiplated array
                    counter++;//increment the number of lenght of array.
                }
            }
            file.Close();//close it so no data leak.
        }

        //To Printing out the list of student
        for (int i = 0; i < counter; i++){
            Console.WriteLine(i +1 + ".\t" + s1[i].FirstName);
            Console.WriteLine("\t"+ s1[i].LastName);
            Console.WriteLine("\t" + s1[i].Class_Status);
            Console.WriteLine("\t" + s1[i].Dob);
            Console.WriteLine("\t" + s1[i].Gpa);
            Console.WriteLine();
        }

        Sort sor = new Sort(s2, counter);//Create a Sorting Object. We are adding s2 because we want to manipulated



        //---------TEXT GUI-----------------

        int exit = 0;//we will use this to exit the do while loop. It will atleast run once.
        do
        {
            int asw = 0;//the first option. either choice lastname, id, or gpa for sorting
            int asw2 = 0;//secont option, either to go ascending or descending order. not needed but a cool perk
            int theOtherExit = 0;//validing that the input is integer only. if not, it will loop
            Console.WriteLine();//formatting purpose. to make it look presentable.
            //option menu for the first selection
            Console.Write("Sorting Time Baby:\nPlease Type 1, 2, 3 for your choice.\n1. Last Name\n2. Student ID\n3. GPA\nany number to exit\nChoice: ");
            string line = Console.ReadLine();//input for the first option menu.

            //validating input to make it an integer
            while (theOtherExit == 0)
            {
                //check if input is integer, it yes, it will store it in asw and exit the loop
                if (int.TryParse(line, out asw))
                {
                    asw = asw;//not necessary but just incase.
                    theOtherExit++;//exit level here.
                }
                else
                {
                    Console.Write("Please enter an integer: ");//prompt for another input until integer is enter.
                    line = Console.ReadLine();//get the input
                }
            }
            
            //if input is 1, do this. meaning it will do lastname sorting
            if (asw == 1)
            {
                Console.Write("1. Ascending\n2. Descending\nAnswer: ");//asking to choice 1 or 2

                //doing a while loop since there is no turning exiting for this. it will keep looping until
                //it is enter 1 or 2
                while (asw2 != 1 && asw2 != 2)
                {
                    theOtherExit = 0;//reset the exit
                    line = Console.ReadLine();//get the input from the user.
                    while (theOtherExit == 0)//input validation. check if input is integer.
                    {
                        if (int.TryParse(line, out asw2))//check input if integer
                        {
                            asw2 = asw2;//again, not necessary but just in case. store it into itself
                            theOtherExit++;//exit mechanic here.
                        }
                        else
                        {
                            Console.Write("Please enter an integer: ");//please DO ENTER integer please
                            line = Console.ReadLine();//get input
                        }
                    }
                    if (asw2 == 1 || asw2 == 2)//to check if input is either 1 or 2
                    {
                        //nothing to put here. for some reason, it works
                    }
                    else
                    {
                        Console.Write("Please type 1 or 2: ");//prompt to re enter 1 or 2;
                    }
                }

                if (asw2 == 1)//ascending order
                {
                    s2 = sor.lastNameSortAs();
                }
                if (asw2 == 2)//descending order
                {
                    s2 = sor.lastNameSortDe();
                }
            }

            //same as the one above but for sorting ID
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

            //Same thing above but option to sort GPA
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

            //any number input will exit the while loop.
            else
            {
                break;
            }

            //print out the original list
            Console.WriteLine("------------------Original----------------");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Last Name: " + s1[i].LastName + "\tID: " + s1[i].Student_ID + "\tGPA: " + s1[i].Gpa);
            }

            //print out the sorted list.
            Console.WriteLine("------------------Sorted----------------");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Last Name: " + s2[i].LastName + "\tID: " + s2[i].Student_ID + "\tGPA: " + s2[i].Gpa);
            }

        } while (exit == 0);

    }

}
