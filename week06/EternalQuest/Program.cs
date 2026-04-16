using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        // - Added file saving/loading
        while (true)
        {
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();
            // - Implemented polymorphism across goal types
            // - Designed scalable goal system
            if (choice == "1")
            {
                Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int pts = int.Parse(Console.ReadLine());

                if (type == "1")
                    manager.AddGoal(new SimpleGoal(name, desc, pts));

                else if (type == "2")
                    manager.AddGoal(new EternalGoal(name, desc, pts));

                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                }
            }
            else if (choice == "2")
                manager.DisplayGoals();

            else if (choice == "3")
            {
                manager.DisplayGoals();
                Console.Write("Select goal: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
            else if (choice == "4")
                manager.ShowScore();

            else if (choice == "5")
                manager.Save("goals.txt");

            else if (choice == "6")
                manager.Load("goals.txt");

            else if (choice == "7")
                break;
        }
    }
}