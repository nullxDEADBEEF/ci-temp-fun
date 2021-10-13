using NUnit.Framework;
using CITempFun;


namespace CITempFunTests
{
    public class Tests
    {
        [Test]
        public void CorrectStringReturn()
        {
            // Arrange
            // Act
            string actual = Program.FooText("Bar");
            // Assert
            Assert.AreEqual("FooBar", actual);
        }

        [Test]
        public void CanReturnSomethingElseThanFooBar()
        {
            // Arrange
            // Act
            string actual = Program.FooText("sRodar");
            // Assert
            Assert.AreNotEqual("FooBar", actual);
        }
    }
}