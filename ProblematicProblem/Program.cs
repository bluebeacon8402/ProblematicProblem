using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        public Random rng;        
        public static bool cont = true;
        public static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;            
            }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            
            string response2 = Console.ReadLine();
            
            if (response2.ToLower() == "sure")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            if (cont)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                
                string response3 = Console.ReadLine();
                
                if (response3.ToLower() == "yes")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }

                Console.WriteLine();

                while (cont)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    
                    string response4 = Console.ReadLine();

                    if (response4.ToLower() == "yes")
                    {
                        cont = true;
                    }
                    else
                    {
                        cont = false; 
                    }
                }
            }
            
            while (cont == false)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Random rng1 = new Random();
                int randomNumber = rng1.Next(activities.Count);

                string randomActivity = activities[randomNumber];

                if (userAge > 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                
                    int randomNumber2 = rng1.Next(activities.Count);

                    string randomActivity2 = activities[randomNumber];
                }

                Console.Write($"Ah got it! {userName}, your random activity is:{randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                string response5 = Console.ReadLine();

                if (response5.ToLower() == "keep")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }
            }
        }
    }
}
