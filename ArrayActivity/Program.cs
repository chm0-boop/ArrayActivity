using System;
using System.Collections;
using ArrayClassLibrary;
using ArrayClassLibrary.Activities;

namespace ArrayActivity
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Activities Menu =====");
                Console.WriteLine("1. Array Manipulation");
                Console.WriteLine("2. Linear Search");
                Console.WriteLine("3. String Reversal");
                Console.WriteLine("4. String Split and Count");
                Console.WriteLine("5. Exit");
                Console.WriteLine("===========================");
                Console.Write("\nChoose an activity: ");
                string choice = Console.ReadLine();

                ActivityBase activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new ArrayManipulationActivity();
                        break;
                    case "2":
                        activity = new LinearSearchTask();
                        break;
                    case "3":
                        activity = new StringReversalActivity();
                        break;
                    case "4":
                        activity = new StringSplitAndCount();
                        break;
                    case "5":
                        activity = null;
                        break;
                    default:
                        activity = null;
                        break;
                }

                if (activity == null)
                {
                    if (choice == "5")
                    {
                        Console.WriteLine("Bye! Luv u sir!");
                        break;
                    }

                    Console.WriteLine("\nInvalid choice. Press any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();
                activity.Run();

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}