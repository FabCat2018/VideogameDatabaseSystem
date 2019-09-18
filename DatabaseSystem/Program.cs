using System;

namespace VideogameDatabaseSystem.DatabaseSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            VideogameMockDatabase database = VideogameMockDatabase.Instance;
            bool stop = false;
            Console.WriteLine("Welcome to the Videogame Database. Currently there are {0} videogames in the database.", database.VideogameList.Count);

            while (!stop) {
                Console.WriteLine("Please select what you would like to do: (a)dd a game; (r)emove a game; (f)ind a game, (q)uit");
                string option = Console.ReadLine();
                stop = SelectOption(option, database);
            }
        }

        public static bool SelectOption(string option, VideogameMockDatabase database)
        {
            if (string.Equals(option, "a", StringComparison.OrdinalIgnoreCase)) {
                Videogame videogame = SpecifyParameters();
                database.Add(videogame);
                return false;
            } else if (string.Equals(option, "r", StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Please specify the title of the game you wish to remove from the database: ");
                string gameToRemove = Console.ReadLine();
                database.Remove(gameToRemove);
                return false;
            } else if (string.Equals(option, "f", StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Please specify the title of the game you wish to see information about: ");
                string gameTitle = Console.ReadLine();
                Videogame videogame = database.Search(gameTitle);
                if (videogame != null) {
                    DisplayInformation(videogame);
                } else {
                    Console.WriteLine("That game is currently not in the database.");
                }
                return false;
            } else if (string.Equals(option, "q", StringComparison.OrdinalIgnoreCase)) {
                return true;
            } else {
                Console.WriteLine("Sorry, I didn't understand that.");
                return false;
            }
        }

        public static Videogame SpecifyParameters()
        {
            Console.WriteLine("Please specify the title of the game: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please give a brief description of the game: ");
            string description = Console.ReadLine();
            Console.WriteLine("Please give the critical rating of the game (1-5): ");
            int criticRating = int.Parse(Console.ReadLine());
            return new Videogame(title, description, criticRating);
        }

        public static void DisplayInformation(Videogame videogame)
        {
            Console.WriteLine("\nTitle: {0}\nDescription: {1}\nCritic Rating: {2}", videogame.Title, videogame.Description, videogame.CriticRating);
        }
    }
}