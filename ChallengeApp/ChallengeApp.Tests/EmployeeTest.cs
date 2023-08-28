namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoPositiveScores_ShouldCorrectResult()
        {
            //arrange
            var employee1 = new Employee("Kuba", "Majewski", 25);
            employee1.AddScore(6);
            employee1.AddScore(7);

            //act
            var result = employee1.Result;

            //assert
            Assert.AreEqual(13, result);

        }

        [Test]
        public void WhenEmployeeCollectTwoNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var employee2 = new Employee("Natalia", "Konieczna", 34);
            employee2.AddScore(-3);
            employee2.AddScore(-7);

            //act
            var result = employee2.Result;

            //assert
            Assert.AreEqual(-10, result);

        }

        [Test]
        public void WhenEmployeeCollectNegativeScoreAndPositiveScore_ShouldCorrectResult()
        {
            //arrange
            var employee3 = new Employee("Paulina", "Kowalska", 42);
            employee3.AddScore(-3);
            employee3.AddScore(3);

            //act
            var result = employee3.Result;

            //assert
            Assert.AreEqual(0, result);

        }
    }
}