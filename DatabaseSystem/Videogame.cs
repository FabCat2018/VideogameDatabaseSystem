using System;
using System.Drawing;

namespace VideogameDatabaseSystem.DatabaseSystem
{
    ///<summary>Contains information including title, description, critical ratings, and image.</summary>
    public class Videogame
    {
        #region Properties
        public string Title { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Achievements { get; set; }

        #endregion

        #region Constructors

        //Should be used for testing purposes only
        public Videogame() {}

        public Videogame(string gameTitle, string gameType, string gameDescription, string gameAchievements)
        {
            this.Title = gameTitle;
            this.Type = gameType;
            this.Description = gameDescription;
            this.Achievements = gameAchievements;
        }

        #endregion
    }
}