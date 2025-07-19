using CarsApp;

namespace CarAppTests
{
    [TestClass]
    public class CarTests
    {
        public static Car StaticCar { get; set; }
        public Car TestCar { get; set; }
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void CarTestsInit(TestContext context)
        {
            StaticCar = new Car();
            context.WriteLine("Car tests init");
        }

        [ClassCleanup] 
        public static void CarTestsCleanup()
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            TestCar = new Car();
            TestContext.WriteLine("Test init");
        }

        [TestCleanup] 
        public void TestCleanup() 
        {
            TestContext.WriteLine("Test clean up");
        }

        public CarTests()
        {
            Console.WriteLine("CTOR called");
        }

        #region Assert

        [TestMethod]
        public void TimeToCoverProvidedDistance_Distance200Velocity100_Time2()
        {
            // Arrange
            TestCar.Velocity = 100;

            // Act
            var actualResult = TestCar.TimeToCoverProvidedDistance(200);

            // Assert
            Assert.AreEqual(2, actualResult);
        }

        //[Ignore]
        [TestMethod]
        public void GetMyCar_ExistingCar_SameCar()
        {
            // Arrange
            //var car = new Car();

            // Act
            var myCar = TestCar.GetMyCar();

            // Assert
            Assert.AreSame(myCar, TestCar);
        }

        [Owner("Waleed")]
        [Priority(1)]
        [TestCategory("Cat 1")]
        // For demo purpose
        [TestMethod]
        public void GetMyCar_2DifferentCarsSameState_Equal()
        {
            var car1 = new Car(CarType.Toyota, 0, DrivingMode.Forward);
            var car2 = new Car(CarType.Toyota, 0, DrivingMode.Forward);

            var myCar1 = car1.GetMyCar();
            var myCar2 = car2.GetMyCar();

            Assert.AreNotSame(myCar1, myCar2);
            Assert.AreEqual(myCar1, myCar2);
        }

        [Owner("Ahmed")]
        [Priority(2)]
        [TestCategory("Cat 2")]
        [TestMethod]
        public void IsStopped_Velocity0_True()
        {
            var car = new Car();

            var actualResult = car.IsStopped();

            Assert.IsTrue(actualResult);
        }

        #endregion

        #region Exception

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void Accelerate_HondaCar_ThrowNotImplementedException()
        {
            var car = new Car();
            car.Type = CarType.Honda;

            car.Accelerate();

            // Assert.ThrowsException<NotImplementedException>(() => car.Accelerate());
        }

        #endregion

        #region String Assert

        [TestMethod]
        public void GetDirection_CarMovingForward_ReturnForward()
        {
            var car = new Car();
            car.DrivingMode = DrivingMode.Forward;

            var actualResult = car.GetDirection();

            StringAssert.Matches(actualResult, new System.Text.RegularExpressions.Regex("Forward"));
        }

        #endregion
    }
}