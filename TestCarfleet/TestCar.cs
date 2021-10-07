using NUnit.Framework;
using Carfleet;

namespace TestCarfleet
{
    public class TestCar
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Distance_NominalCase_Success()
        {
            //given - contexte de départ
            int expectedDistance = 200;
            int actualDistance;
            Car car = new Car("VD123", "Mercedes", "C34", "félaj", 400);
            car.OdometerCurrentValue = 600;

            //when - événement
            actualDistance = car.Distance();

            //then - résultat attendu
            Assert.AreEqual(expectedDistance, actualDistance);

        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}