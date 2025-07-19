using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using Moq;

namespace CarAPITests;

[TestClass]
public class CarAPITest
{
    private Mock<InMemoryContext> _context;
    private CarsRepository _carsRepository;
    private CarsService _carsService;
    public TestContext TestContext { get; set; }
    public Car TestCar { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
        _context = new Mock<InMemoryContext>();
        _carsRepository = new CarsRepository(_context.Object);
        _carsService = new CarsService(_carsRepository);
        TestCar = new Car(1, CarType.Audi, 180);

        _context.Setup(c => c.Cars).Returns(new List<Car>
        {
            new Car(1, CarType.Audi, 180),
            new Car(2, CarType.BMW, 200),
            new Car(3, CarType.Audi, 220)
        });

        TestContext.WriteLine(TestContext.TestName + " :Mocked InMemoryContext and created a test car.");
    }

    [TestCleanup]
    public void TestCleanup()
    {
        _context = null!;
        TestCar = null!;
        TestContext.WriteLine(TestContext.TestName + " :Cleaned up after test.");
    }

    #region CarsRepository Tests

    [TestMethod]
    public void Remove_ExistingCar_ReturnsTrue()
    {
        // Arrange

        // Act
        var result = _carsRepository.Remove(1);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Remove_NonExistingCar_ReturnsFalse()
    {
        // Arrange

        // Act
        var result = _carsRepository.Remove(99);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void GetAllCars_ReturnsAllCars()
    {
        // Arrange

        // Act
        var result = _carsRepository.GetAllCars();

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.Count);
    }

    #endregion

    #region CarsService Tests

    [TestMethod]
    public void GetCarById_ExistingCar_ReturnsCar()
    {
        // Arrange

        // Act
        var result = _carsService.GetCarById(1);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Id);
    }

    [TestMethod]
    public void GetCarById_NonExistingCar_ReturnsNull()
    {
        // Arrange
        // Act
        var result = _carsService.GetCarById(99);
        // Assert
        Assert.IsNull(result);
    }

    #endregion
}
