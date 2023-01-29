namespace Homework2{
    class Question6{

        double num = 0;
        public void myMethod(){
            double total = 555;
            Console.WriteLine("Total = " + total);
            do{
                Console.Write("Enter a number to subtract from total: ");
                string s = Console.ReadLine();
                Validation(s);

                total = total - num;

                Console.WriteLine("Total = " + total);
            }while(total > 0);
        }

        public void Validation(string s){
            if (double.TryParse(s, out num)){
                num = num;
            }
            else {
                Console.Write("Please enter a number: ");
                s = Console.ReadLine();
                Validation(s);
            }
        }
    }
}