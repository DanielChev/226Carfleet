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
            //given - contexte de d�part
            int expectedDistance = 200;
            int actualDistance;
            Car car = new Car("VD123", "Mercedes", "C34", "f�laj", 400);
            car.OdometerCurrentValue = 600;

            //when - �v�nement
            actualDistance = car.Distance();

            //then - r�sultat attendu
            Assert.AreEqual(expectedDistance, actualDistance);

        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}