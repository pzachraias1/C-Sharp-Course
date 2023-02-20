namespace Project{
    class Student{
        string first;
        string last;
        string class_status;
        string student_ID;
        string dob;
        double gpa;

        public Student(){
            first = "";
            last ="";
            class_status = "";
            student_ID = "";
            dob = "";
            gpa =0.0;
        }

        public Student(string first, string last, string class_status, string student_ID, string dob, double gpa){
            this.first = first;
            this.last = last;
            this.class_status = class_status;
            this.student_ID = student_ID;
            this.dob = dob;
            this.gpa = gpa;
        }

        public string FirstName{
            set{this.first = value;}
            get{return this.first;}
        }

        public string LastName{
            set{this.last = value;}
            get{return this.last;}
        }

        public string Class_Status{
            set{this.class_status = value;}
            get{return this.class_status;}
        }

        public string Student_ID{
            set{this.student_ID = value;}
            get{return this.student_ID;}
        }

        public string Dob{
            set{this.dob = value;}
            get{return this.dob;}
        }

        public double Gpa{
            set{this.gpa = value;}
            get{return this.gpa;}
        }
        
        // public void setFirst(string first){
        //     this.first = first;
        // }

        // public void setLast(string last){
        //     this.last = last;
        // }

        // public void setClass_Status(string class_status){
        //     this.class_status = class_status;
        // }

        // public void setStudent_ID(string student_ID){
        //     this.student_ID = student_ID;
        // }

        // public void setDob(string dob){
        //     this.dob = dob;
        // }

        // public void setGpa(double gpa){
        //     this.gpa = gpa;
        // }

        // public string getFirst(){
        //     return this.first;
        // }

        // public string getLast(){
        //     return this.last;
        // }

        // public string getClass_Status(){
        //     return this.class_status;
        // }

        // public string getStudent_ID(){
        //     return this.student_ID;
        // }

        // public string getDob(){
        //     return this.dob;
        // }

        // public double getGpa(){
        //     return this.gpa;
        // }
    }
}