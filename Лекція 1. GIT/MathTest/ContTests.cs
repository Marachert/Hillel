using Math;
using NUnit.Framework;

namespace MathTest
{
    [TestFixture]
    public class ContTests
    {
        [Test]
        public void SumOfNumbers_ShouldReturnCorrectNumber()
        {
            // Arrange
            int from = 1;
            int to = 3;
            int expectedResult = 6;

            // Act
            Count calc = new();
            int result = calc.SumOfNumbers(from, to);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
