namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsShouldReturnMinGrade()
        {
            //arrange
            var employee = new Employee("Maja", "Wiœniewska");
            employee.AddGrade(1);
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(4);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(1, statistics.Min);

        }

        [Test]
        public void WhenGetStatisticsShouldReturnMaxGrade()
        {
            //arrange
            var employee = new Employee("Maja", "Wiœniewska");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }

        [Test]
        public void WhenGetStatisticsShouldReturnAverageGrade()
        {
            //arrange
            var employee = new Employee("Maja", "Wiœniewska");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(7);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Average);

        }
    }
}