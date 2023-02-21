namespace Project{
    class Student{
        string first;//instnace for first name
        string last;//instance for last name
        string class_status;//instance for class status
        string student_ID;//instance for student id
        string dob;//instance for date of birth
        double gpa;//instance for gpa

        //constructor for student. defaulted one
        public Student(){
            first = "";
            last ="";
            class_status = "";
            student_ID = "";
            dob = "";
            gpa =0.0;
        }
        
        //constructor with parameter. no needed or was not use.
        public Student(string first, string last, string class_status, string student_ID, string dob, double gpa){
            this.first = first;
            this.last = last;
            this.class_status = class_status;
            this.student_ID = student_ID;
            this.dob = dob;
            this.gpa = gpa;
        }

        //getter and setter for first name instance
        public string FirstName{
            set{this.first = value;}
            get{return this.first;}
        }

        //getter and setter for last name
        public string LastName{
            set{this.last = value;}
            get{return this.last;}
        }

        //getter and setter for class status
        public string Class_Status{
            set{this.class_status = value;}
            get{return this.class_status;}
        }
        
        //getter and setter for student id
        public string Student_ID{
            set{this.student_ID = value;}
            get{return this.student_ID;}
        }

        //getter and setter for date for birth
        public string Dob{
            set{this.dob = value;}
            get{return this.dob;}
        }

        //getter and setter for gpa
        public double Gpa{
            set{this.gpa = value;}
            get{return this.gpa;}
        }
    }
}