using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideogameDatabaseSystem.DatabaseSystem;

namespace VideogameDatabase.DatabaseSystem.Tests
{
    [TestClass]
    public class VideogameMockDatabaseTests
    {
        [TestMethod]
        public void Add_EmptyDatabase_OneElementAdded()
        {
            //Arrange
            var database = VideogameMockDatabase.Instance;
            var videogame = new Videogame("a", "b", 1);

            //Act
            database.Add(videogame);

            //Assert
            Assert.AreEqual(database.VideogameList.Count, 1);
        }
    }
}
