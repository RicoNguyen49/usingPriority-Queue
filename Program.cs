using System;
using System.Collections.Generic;

class Program
{
    public class Title
    {
        public string Game { get; set; } = string.Empty;
        public int Year { get; set; }
        public Title(string game, int year)
        {
            Game = game;
            Year = year;
        }
    }
    static void Main(string[] args)
    {
        Queue<string> myGames = new Queue<string>();

        Console.WriteLine("Using Queue");
        // Add 5 games to the Queue
        myGames.Enqueue("valorant");
        myGames.Enqueue("Fortnite");
        myGames.Enqueue("Fifa");
        myGames.Enqueue("2K");
        myGames.Enqueue("GTA 5");

        // Check if the queue contains a specific item
        string gameCheck = "Fortnite";
        bool containsGame = myGames.Contains(gameCheck);
        Console.WriteLine($"Does the queue contain '{gameCheck}'? {containsGame}");

        // Remove first game from the queue
        string removedGame = myGames.Dequeue();
        Console.WriteLine($"Removed game: {removedGame}");

        // Count the games in the queue and display the count
        int gameCount = myGames.Count;
        Console.WriteLine($"Number of games in the queue: {gameCount}");

        // Print all the games in the queue
        Console.WriteLine("all games in the queue:");
        foreach (string item in myGames)
        {
            Console.WriteLine(item);
        }



            // Creates the members list with patient objects and their priorities
            // serves as seed data
            var patients = new List < (Title, int) >()
            {
             (new("Valorant", 2017), 4),
             (new("Fornite", 2017), 2),
             (new("Fifa", 2023), 1),
             (new("2k", 2023), 5),
             (new("GTA 5", 2012), 3)
            };
            // Creates a priority queue and adds the List of patients and priorities to the queue 
            var GameQueue = new PriorityQueue <Title, int > (patients);
            int selection = Menu();
            string game;
            int year, priority;
            while(selection != 4)
            {
                switch (selection)
                {
                    case 1: // Add
                        Console.WriteLine("game name: ");
                        game = Console.ReadLine();
                        Console.WriteLine("Year: ");
                        year=int.Parse(Console.ReadLine());
                        Console.WriteLine("Game Priority: ");
                        priority = int.Parse(Console.ReadLine());
                    GameQueue.Enqueue(new Title(game, year), priority);
                        break;
                    case 2:

                    GameQueue.TryPeek(out Title nextPatient, out int patientPriority);
                        
                    Console.WriteLine($"Highest priority game: {nextPatient.Game}, Year {nextPatient.Year}");
                        break;
                    case 3: 

                    GameQueue.TryDequeue(out Title dischargePatient, out int dischargePriority);
                        Console.WriteLine($"Remove game: {dischargePatient.Game}, Year {dischargePatient.Year}");
                        break;

                    default:
                        Console.WriteLine("You have made an invalid selection, please try again");
                        break;
                }
                selection = Menu();
            }          
 
        }
        static int Menu()
        {
            Console.WriteLine("Game piority Queue");
            Console.WriteLine("1 to Add a Game \n2 to View the Highest Priority Game\n3 to Remove game \n4 to Quit");
            int choice = int.Parse( Console.ReadLine() );
            return choice;
        }
}

