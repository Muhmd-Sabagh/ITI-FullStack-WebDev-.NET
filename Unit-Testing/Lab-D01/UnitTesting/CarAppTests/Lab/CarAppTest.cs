using CarsApp;

namespace CarAppTests;

[TestClass]
public class CarAppTest
{
    public TestContext TestContext { get; set; }
    public Car TestCar { get; set; }
    public static CarStore StaticCarStore { get; set; }

    [ClassInitialize]
    public static void CarStoreTestsInit(TestContext context)
    {
        StaticCarStore = new CarStore(new List<Car>{
            new Car(CarType.Audi, 80, DrivingMode.Reverse),
            new Car(CarType.Honda, 120, DrivingMode.Forward),
            new Car(CarType.Mercedes, 0, DrivingMode.Stopped)
        });
        context.WriteLine("CarApp Test Init");
    }

    [ClassCleanup]
    public static void CarStoreTestsCleanup()
    {
    }

    [TestInitialize]
    public void TestInit()
    {
        TestCar = new Car();
        TestContext.WriteLine(TestContext.TestName + " init");
    }

    [TestCleanup]
    public void TestCleanup()
    {
        TestContext.WriteLine(TestContext.TestName + " clean up");
    }

    #region Assert Tests

    [TestMethod]
    public void GetMyCar_ExistingCar_SameCar()
    {
        // Arrange

        // Act
        var myCar = TestCar.GetMyCar();

        // Assert
        Assert.AreSame(myCar, TestCar, "GetMyCar should return the same instance of the car.");
    }

    [TestMethod]
    public void Brake_CarTypeMercedes_VelocityDecreasedBy20()
    {
        // Arrange
        TestCar = new Car(CarType.Mercedes, 100, DrivingMode.Forward);
        int initialVelocity = 100;

        // Act
        TestCar.Brake();

        // Assert
        Assert.AreEqual(initialVelocity - 20, TestCar.Velocity, "Mercedes car should decrease velocity by 20.");
    }

    #endregion

    #region String Assert Tests

    [TestMethod]
    public void ToString_ReturnsCorrectCarInfo()
    {
        // Arrange
        TestCar = new Car(CarType.Audi, 180, DrivingMode.Forward);

        // Act
        var carInfo = TestCar.ToString();

        // Assert
        StringAssert.Contains(carInfo, "Audi");
        StringAssert.Contains(carInfo, "180");
        StringAssert.Contains(carInfo, "Forward");
    }

    #endregion

    #region Collection Assert Tests

    [TestMethod]
    public void AddCars_ValidCarsList_CarsAddedSuccessfully()
    {
        // Arrange
        var newCar = new Car(CarType.Honda, 120, DrivingMode.Forward);

        // Act
        StaticCarStore.AddCar(newCar);

        // Assert
        CollectionAssert.Contains(StaticCarStore.Cars, newCar, "The new car should be added to the store.");
    }

    [TestMethod]
    public void GetAllStoreCars_EqualCarsSameOrder_EqualAndNotEquivalent()
    {
        // Arrange
        var newStore = new CarStore(new List<Car>{
            new Car(CarType.Audi, 80, DrivingMode.Reverse),
            new Car(CarType.Honda, 120, DrivingMode.Forward),
            new Car(CarType.Mercedes, 0, DrivingMode.Stopped)
        });

        // Act
        var newStoreCars = newStore.GetAllStoreCars();
        var staticStoreCars = StaticCarStore.GetAllStoreCars();

        // Assert
        CollectionAssert.AreEqual(newStoreCars, staticStoreCars, "The cars in the stores should be equal.");
        CollectionAssert.AreNotEquivalent(newStoreCars, staticStoreCars, "The cars in the stores should be equivalent.");
    }

    #endregion
}
