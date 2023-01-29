namespace Homework2{
    class Question5{
        public void myMethod(){
            Boolean flag = true;
            Console.Write("Please type Q to end the program: ");
            string s = Console.ReadLine();

            while(flag){
                if (s[0] == 'Q'){
                    flag = false;
                }
                else{
                    Console.Write("Type Q to end: ");
                    s = Console.ReadLine();
                }
            }
        }
    }
}