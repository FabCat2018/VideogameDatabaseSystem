using System;
using System.Collections.Generic;

namespace VideogameDatabaseSystem.DatabaseSystem
{
    ///<summary>Database class to be used for demonstration purposes. Refactor after real database set-up.</summary>
    public sealed class VideogameMockDatabase
    {
        #region Private Fields
        private static VideogameMockDatabase instance;
        private List<Videogame> videogameList = new List<Videogame>();

        #endregion

        #region Properties
        public static VideogameMockDatabase Instance
        { 
            get
            {
                if (instance == null) {
                    instance = new VideogameMockDatabase();
                }
                return instance;
            }
        }

        ///<summary>Currently functions as the database.</summary>
        public List<Videogame> VideogameList 
        { 
            get { return videogameList; } 
        }

        #endregion

        #region Constructors
        private VideogameMockDatabase() {}

        #endregion

        #region Public Methods
        ///<summary>Adds a Videogame to the database.</summary>
        public void Add(Videogame videogame)
        {
            VideogameList.Add(videogame);
        }

        ///<summary>Removes a Videogame from the database.</summary>
        public void Remove(string videogameTitle)
        {
            Videogame videogame = Search(videogameTitle);
            if (videogame != null) {
                VideogameList.Remove(videogame);
            } else {
                Console.WriteLine("That game is not currently in the database.");
            }
        }

        ///<summary>Uses linear search to locate Videogame within database based on Title, then returns said Videogame.</summary>
        public Videogame Search(string title)
        {
            for (int i = 0; i < VideogameList.Count; i++)
            {
                if (title.Equals(VideogameList[i].Title)) {
                    return VideogameList[i];
                }
            }
            return null;
        }
        
        //Implement a sorting algorithm to allow binary search, to increase efficiency. Low-priority.

        #endregion
    }
}