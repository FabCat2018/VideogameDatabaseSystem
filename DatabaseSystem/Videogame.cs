using System;
using System.Drawing;

namespace VideogameDatabaseSystem.DatabaseSystem
{
    ///<summary>Contains information including title, description, critical ratings, and image.</summary>
    public class Videogame
    {
        #region Properties
        public string Title { get; private set; }

        public string Description { get; private set; }

        public int CriticRating { get; private set; }

        // public Image Image

        #endregion

        #region Constructors
        public Videogame(string gameTitle, string gameDescription, int gameCriticRating /*Image gameImage*/)
        {
            this.Title = gameTitle;
            this.Description = gameDescription;
            this.CriticRating = gameCriticRating;
            // this.Image = gameImage;
        }

        #endregion
    }
}