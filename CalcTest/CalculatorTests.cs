using Lesson11_UnT;

namespace CalcTest
{
    [TestFixture]
    public class Tests
    {
        private Calculator _calculator;
        
        [SetUp]
        public void Setup()
        {
            //Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalledWithPositive_ReturnSumOfPositive()
        {
            //Act
            var actual = _calculator.Add(4, 5); 

            //Assert
            Assert.That(actual, Is.EqualTo(9));
        }

        [Test]
        public void Add_WhenCalledWithNegative_ReturnSumOfNegative()
        {
            //Act
            var actual = _calculator.Add(-4, -5);

            //Assert
            Assert.That(actual, Is.EqualTo(-9));
        }
        
        [Test]
        public void Devis_WhenCalledWithValidDenominator_ReturnZero()
        {
            //Act
            var actual = _calculator.Devision(-4, 0);

            //Assert
            Assert.That(actual, Is.EqualTo(0));
        }
        [Test]
        public void Devis_WhenCalledWithValidData_ReturnDevisionResult()
        {
            //Act
            var actual = _calculator.Devision(-4, 2);

            //Assert
            Assert.That(actual, Is.EqualTo(-2));
        }
        [Test]
        public void Subtr_WhenCalledWithNegative_ReturnSubtrResult()
        {
            //Act
            var actual = _calculator.Subtract(-4, -5);

            //Assert
            Assert.That(actual, Is.EqualTo(1));
        }
        [Test]
        public void Subtr_WhenCalledWithPositive_ReturnSubtrResult()
        {
            //Act
            var actual = _calculator.Subtract(5, 4);

            //Assert
            Assert.That(actual, Is.EqualTo(1));
        }

    }
}