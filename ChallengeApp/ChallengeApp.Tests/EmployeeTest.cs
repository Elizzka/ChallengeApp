namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoPositiveScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Kuba", "Majewski", 25);
            employee.AddScore(6);
            employee.AddScore(7);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(13, result);

        }

        [Test]
        public void WhenEmployeeCollectTwoNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Natalia", "Konieczna", 34);
            employee.AddScore(-3);
            employee.AddScore(-7);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-10, result);

        }

        [Test]
        public void WhenEmployeeCollectNegativeScoreAndPositiveScore_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Paulina", "Kowalska", 42);
            employee.AddScore(-3);
            employee.AddScore(3);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);

        }
    }
}