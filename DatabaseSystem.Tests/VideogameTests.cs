using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideogameDatabaseSystem.DatabaseSystem;

namespace VideogameDatabase.DatabaseSystem.Tests
{
    [TestClass]
    public class VideogameTests
    {
        #region Private Fields

        private Videogame videogame;

        #endregion

        #region Test Initialize

        [TestInitialize]
        public void TestInitialize()
        {
            videogame = new Videogame();
        }

        #endregion

        #region Properties Tests

        [TestMethod]
        public void TitleProp_GetAndSet_ReturnSameValueAsAssigned()
        {
            //Act
            videogame.Title = "a";
        
            //Assert
            Assert.AreEqual("a", videogame.Title);
        }

        [TestMethod]
        public void TypeProp_GetAndSet_ReturnSameValueAsAssigned()
        {
            //Act
            videogame.Type = "a";
        
            //Assert
            Assert.AreEqual("a", videogame.Type);
        }

        [TestMethod]
        public void DescriptionProp_GetAndSet_ReturnSameValueAsAssigned()
        {
            //Act
            videogame.Description = "a";
        
            //Assert
            Assert.AreEqual("a", videogame.Description);
        }

        [TestMethod]
        public void AchievementsProp_GetAndSet_ReturnSameValueAsAssigned()
        {    
            //Act
            videogame.Achievements = "a";
        
            //Assert
            Assert.AreEqual("a", videogame.Achievements);
        }

        #endregion

        #region Constructor Tests

        [TestMethod]
        public void Constructor_WhenCalled_ReturnsVideogameWithCorrectParameters()
        {
            //Arrange
            Videogame other = new Videogame("title", "type", "description", "achievements");
        
            //Act
            videogame = new Videogame("title", "type", "description", "achievements");

        
            //Assert
            Assert.AreEqual(other.Title, videogame.Title);
            Assert.AreEqual(other.Type, videogame.Type);
            Assert.AreEqual(other.Description, videogame.Description);
            Assert.AreEqual(other.Achievements, videogame.Achievements);
        }

        #endregion
    }
}