namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void NameShouldReturnTheSameValues()
        {
            //arrange
            string name1 = "Kuba";
            string name2 = "Kuba";

            //act

            //assert
            Assert.AreEqual(name1, name2);

        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Kuba", "Majewski", 25);
            var employee2 = GetEmployee("Nadia", "Krzak", 32);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);

        }

        [Test]
        public void AgeShouldReturnTheSameValues()
        {
            //arrange
            int age1 = 25;
            int age2 = 25;

            //act

            //assert
            Assert.AreEqual(age1, age2);

        }

        [Test]
        public void NumberShouldReturnDifferentValues()
        {
            //arrange
            float number1 = 2.25f;
            float number2 = 4.4f;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
