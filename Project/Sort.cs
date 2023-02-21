namespace Project
{
    class Sort
    {
        Student[] student;//create a student array
        int size;//create a size integer

        public Sort(Student[] s, int size)//constructor for sorting
        {
            this.size = size;//initialize the size
            this.student = s;//initialize the student object
        }

        //Method is going to do sorting and for the Student array. it will return a new Student Array with sorted
        public Student[] lastNameSortAs() //bubble sort. ascending order
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (student[i].LastName.CompareTo(student[j].LastName) == 1)//check if student[i] > s[j]
                    {
                        Student temp = student[i];//let temp hold the value for the one being compare to
                        student[i] = student[j];//let the one being compare with be equal to value that is greater than it
                        student[j] = temp;//let the value that is greater be equal to the temporary one.
                    }
                }
            }
            return this.student;//return the new manipulated student array.
        }

        //method is going to do sorting. it will the manipulated Student array that is sorted.
        public Student[] lastNameSortDe() //bubble sort. decending order
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (student[i].LastName.CompareTo(student[j].LastName) == -1)//check if s[i] < s[j]
                    {
                        Student temp = student[i];
                        student[i] = student[j];
                        student[j] = temp;
                    }
                }
            }
            return this.student;
        }

        public Student[] idSortAs() // insertion sort. ascending order
        {
            for (int i = 1; i < size; ++i)
            {
                Student temp = student[i];//set a temporary student option. that is equal to the index i student array
                int j = i - 1;//it is going to start at the index before i. It is going back to 0

                while (j >= 0 && student[j].Student_ID.CompareTo(temp.Student_ID) == 1)//will keep looping until s[j]>temp
                {
                    student[j + 1] = student[j];//switch if temp is less than s[j]
                    j = j - 1;//decrement until 0
                }
                student[j + 1] = temp;//insert the temp into the proper index.
            }

            return this.student;//return the manippulated array
        }

        public Student[] idSortDe() //insertion sort. descending order
        {

            for (int i = 1; i < size; ++i)
            {
                Student temp = student[i];
                int j = i - 1;

                while (j >= 0 && student[j].Student_ID.CompareTo(temp.Student_ID) == -1)
                {
                    student[j + 1] = student[j];
                    j = j - 1;
                }
                student[j + 1] = temp;
            }

            return this.student;
        }

        public Student[] gpaSortAs() //sorting GPA. using insertion sort
        {

            for (int i = 1; i < size; ++i)
            {
                Student temp = student[i];
                int j = i - 1;

                while (j >= 0 && student[j].Gpa > temp.Gpa)
                {
                    student[j + 1] = student[j];
                    j = j - 1;
                }
                student[j + 1] = temp;
            }

            return this.student;
        }

        public Student[] gpaSortDe() //sorting GPA. using insertion sort
        {

            for (int i = 1; i < size; ++i)
            {
                Student temp = student[i];
                int j = i - 1;

                while (j >= 0 && student[j].Gpa < temp.Gpa)
                {
                    student[j + 1] = student[j];
                    j = j - 1;
                }
                student[j + 1] = temp;
            }

            return this.student;
        }
    }
}