namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        Vessel[] ves = new Vessel[10];
        string ship_name = "";
        double top_speed = 0.0;
        int fleet;
        bool loopDone = true;
        int choice = 0;
        string input = "";
        int index = 0;

        while(loopDone){
            Console.Write("Type 1 if you want to create a ship, type 2 to print a ship information, or press any number if done: ");
             input = Console.ReadLine();
            while(!int.TryParse(input,out choice)){
                Console.Write("Please enter a number please: ");
                input = Console.ReadLine();
            }

            if(choice == 1){
                ves[index] = new Vessel();
                Console.WriteLine("Let create a Ship. Let start with its attribute: ");
                Console.Write("Let's start by naming the ship: ");
                ship_name = Console.ReadLine();
                ves[index].Name = ship_name;

                Console.Write("What the type of the ship: ");
                ves[index].Type = Console.ReadLine();

                Console.Write("Crew Compliment: ");
                ves[index].Crew_compliment = Console.ReadLine();

                Console.Write("Displacement: ");
                ves[index].Displacement = Console.ReadLine();

                Console.Write("Top Speed: ");
                input = "";
                input = Console.ReadLine();
                while(!double.TryParse(input, out top_speed)){
                    Console.Write("Please write a number please: ");
                    input = Console.ReadLine();
                }
                ves[index].Top_speed = top_speed;

                int changeFleet = 0;
                string fleetChangeInput = "";
                Console.Write("Press 1 if you would like to change Fleet, any number to not change: ");
                fleetChangeInput = Console.ReadLine();
                while(!int.TryParse(fleetChangeInput, out changeFleet)){
                    Console.Write("Please enter a integer please: ");
                    fleetChangeInput = Console.ReadLine();
                }
                if (changeFleet == 1){
                    Console.Write("Enter a number to change the fleet to: ");
                    input = "";
                    input = Console.ReadLine();
                    while(!int.TryParse(input, out fleet)){
                        Console.Write("Pleae Enter a integer please: ");
                        input = Console.ReadLine();
                    }
                    ves[index].Fleet = fleet;
                }

                index++;
            }
            else if (choice == 2){
                for(int i = 0; i != index; i++){
                    ves[i].PrintVessel();
                }
            }
            else{
                Console.WriteLine("Ending");
                loopDone = false;
            }
        }




        // ves.PrintVessel();
    }
}
