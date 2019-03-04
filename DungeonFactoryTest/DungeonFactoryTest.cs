using System;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DungeonFactoryTest
{
    [TestClass]
    public class DungeonFactoryTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenerateDungeonbyArray_WithoutValidArray_ThrowsArgumentException()
        {
            //Arrange
            int[] perimeter = new[] {0, 1, 3};
            DungeonFactory.Factory factory = new DungeonFactory.Factory();

            //Act
            factory.GenerateDungeon(perimeter);
        }

        [TestMethod]
        public void GenerateDungeonbyArray_WithValidArray_ReturnsDungeon()
        {
            //Arrange
            int[] perimeter = new[] {1, 1};
            DungeonFactory.Factory factory = new DungeonFactory.Factory();

            //Act
            var result = factory.GenerateDungeon(perimeter);

            //Assert
            result.Should().BeOfType(typeof(DungeonFactory.Dungeon), "this generates a Dungeon object");
        }
    }
}
