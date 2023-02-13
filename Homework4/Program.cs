namespace Homework4;
class Program
{

    struct Point{
        public double x {get; set;}
        public double y {get; set;}
        public string title {get; set;}

        public Point(){
            this.x = 0;
            this.y = 0;
            this.title = "";
        }

        public Point(double x, double y, string title){
            this.x = x;
            this.y = y;
            this.title = title;
        }

        public Point(double xy){
            this.x = xy;
            this.y = xy;
            this.title = "";
        }

        public Point(double xy, string title){
            this.x = xy;
            this.y = xy;
            this.title = title;
        }

        public Point(double x, double y){
            this.x = x;
            this.y = y;
            this.title = "";
        }

        public Point(string title){
            this.x = 0;
            this.y = 0;
            this.title = title;
        }

        public double horiDistance(double x1, double x2){
            double result = 0.0;
            result = x2 - x1;
            return result;
        }

        public double verDistance(double y1, double y2){
            double result = 0;
            result = y2 - y1;
            return result;
        }

        public Point midpoint(Point p1, Point p2){
            Point result = new Point();
            double xResult = p1.x + p2.x;
            xResult = xResult/2;
            double yResult = p1.y + p2.y;
            yResult = yResult/2;

            result.x = xResult;
            result.y = yResult;
            result.title = "Midpoint";
            return result;
        }

        public double slope(Point p1, Point p2){
            double result = 0;
            double numerator = p2.y - p1.y;
            double denominator = p2.x - p1.x;
            result = numerator/denominator;
            return result;
        }

        public static Point operator+(Point a, Point b){
            Point result = new Point();
            result.x = a.x + b.x;
            result.y = a.y + b.y;
            result.title = "Used the + operator";
            return result;
        }

        public void printPoint(){
            Console.WriteLine("(" + this.x + "," + this.y + ") => " + this.title);
        }
    }

    enum Rank
    {
        AirForce,
        Army,
        Marine,
        General,
        Commander,
    }

    static void Main(string[] args)
    {

        char [] c= {'H','E'};
        for (int i = 0; i < c.Length; i++){
            c[i] = Char.ToLower(c[i]);
            Console.Write(c[i]);
        }
        Point p1 = new Point(3,4,"First");
        Point p2 = new Point (1, 6, "Second");
        double num = 0;
        string input = "";
        
        Console.Write("Let create a point, please enter a double: ");
        while(!(double.TryParse(Console.ReadLine(), out num))){
            Console.Write("Please enter a double: ");
        }
       Point p3 = new Point(num);
       p3.printPoint();

        Console.Write("Let create another point but with a title, first please enter a double: ");
        while(!(double.TryParse(Console.ReadLine(), out num))){
            Console.Write("Please enter a double: ");
        }
        Console.Write("Now enter a title for this point: ");
        input = Console.ReadLine();

        Point p4 = new Point(num, input);
        p4.printPoint();

        Console.WriteLine("Let us add the two points we created together");
        Point p5 = p3+p4;
        p5.printPoint();

    }

    static void EvaluateEnum(System.Enum e)
    {
        Array enumData = Enum.GetValues(e.GetType());

        for (int i = 0; i < enumData.Length; i++)
        {
            Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
        }
        Console.WriteLine();
    }
}
