using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathAct = new BreathingActivity(30);
        ReflectingActivity reflectAct = new ReflectingActivity(30);
        ListingActivity listAct = new ListingActivity(30);

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathAct.Run();
                    break;

                case "2":
                    reflectAct.Run();
                    break;

                case "3":
                    listAct.Run();
                    break;

                case "4":
                    Console.WriteLine("Glad to help you!");
                    return;

                default:
                    Console.WriteLine("Number Invalid!");
                    break;
            }
        }
    }
}