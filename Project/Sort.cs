namespace Project
{
    class Sort
    {
        Student[] student;
        int size;

        public Sort(Student[] s, int size)
        {
            this.size = size;
            this.student = s;
        }

        public Student[] lastNameSortAs() //bubble sort. ascending order
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (student[i].getLast().CompareTo(student[j].getLast()) == 1)
                    {
                        Student temp = student[i];
                        student[i] = student[j];
                        student[j] = temp;
                    }
                }
            }
            return this.student;
        }

        public Student[] lastNameSortDe() //bubble sort. decending order
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (student[i].getLast().CompareTo(student[j].getLast()) == -1)
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

            int index = student.Length;
            for (int i = 1; i < size; ++i)
            {
                Student temp = student[i];
                int j = i - 1;

                while (j >= 0 && student[j].getStudent_ID().CompareTo(temp.getStudent_ID()) == 1)
                {
                    student[j + 1] = student[j];
                    j = j - 1;
                }
                student[j + 1] = temp;
            }

            return this.student;
        }

        public Student[] idSortDe() //insertion sort. descending order
        {

            for (int i = 1; i < size; ++i)
            {
                Student temp = student[i];
                int j = i - 1;

                while (j >= 0 && student[j].getStudent_ID().CompareTo(temp.getStudent_ID()) == -1)
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

                while (j >= 0 && student[j].getGpa() > temp.getGpa())
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

                while (j >= 0 && student[j].getGpa() < temp.getGpa())
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