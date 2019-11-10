using System;
using System.Data.SqlClient;

namespace VideogameDatabaseSystem.DatabaseSystem
{
    class Program
    {
        #region Public Methods

        public static void Main(string[] args)
        {            
            DatabaseConnector connector = SetupConnection();
            bool stop = false;
            //Console.WriteLine("Welcome to the Videogame Database. Currently there are {0} videogames in the database.", database.VideogameList.Count);

            while (!stop) {
                Console.WriteLine("Please select what you would like to do: (a)dd a game; (r)emove a game; (f)ind a game, (q)uit");
                string option = Console.ReadLine();
                stop = SelectOption(option, connector);
            }

            connector.CloseConnection();
        }

        #endregion

        #region Private Static Methods

        private static bool SelectOption(string option, DatabaseConnector connector)
        {
            bool stop = false;
            string query = "";

            if (string.Equals(option, "a", StringComparison.OrdinalIgnoreCase)) {
                query = AddVideogame();
            } else if (string.Equals(option, "r", StringComparison.OrdinalIgnoreCase)) {
                query = RemoveVideogame();
            } else if (string.Equals(option, "f", StringComparison.OrdinalIgnoreCase)) {
                query = FindVideogame();
            } else if (string.Equals(option, "q", StringComparison.OrdinalIgnoreCase)) {
                stop = true;
            } else {
                Console.WriteLine("Sorry, I didn't understand that.");
            }

            if (!query.Equals("")) {
                connector.ExecuteQuery(query);
            }

            return stop;
        }

        private static string AddVideogame()
        {
            Console.WriteLine("Please specify the title of the game: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please specify the type of the game (e.g. Platformer): ");
            string type = Console.ReadLine();
            Console.WriteLine("Please give a brief description of the game: ");
            string description = Console.ReadLine();
            Console.WriteLine("Please give the achievements earned in the game, if applicable: ");
            string achievements = Console.ReadLine();
            return FormulateQuery(title, type, description, achievements);
        }

        private static string RemoveVideogame()
        {
            Console.WriteLine("Please specify the title of the game you wish to remove from the database: ");
            string gameToRemove = Console.ReadLine();
            return FormulateDeleteQuery(gameToRemove);
        }

        private static string FindVideogame() 
        {
            Console.WriteLine("Please specify the title of the game you wish to see information about: ");
            string gameTitle = Console.ReadLine();
            return FormulateSelectQuery(gameTitle);
        }

        private static DatabaseConnector SetupConnection()
        {
            DatabaseConnector connector = new DatabaseConnector();
            connector.OpenConnection();
            return connector;
        }

        private static string FormulateQuery(string title, string type, string description, string achievements)
        {
            return String.Format(@"INSERT INTO [dbo].[game_list]([Title], [Type], [Description], [Achievements]) 
                VALUES('{0}', '{1}', '{2}', '{3}')", title, type, description, achievements);
        }

        private static string FormulateDeleteQuery(string title)
        {
            return String.Format("DELETE FROM [dbo].[game_list] WHERE [Title] = '{0}'", title);
        }

        private static string FormulateSelectQuery(string title)
        {
            return String.Format("SELECT * FROM [dbo].[game_list] WHERE [Title] = '{0}'", title);
        }

        #endregion
    }
}