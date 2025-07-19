using CarAPI.Entities;
using CarAPI.Models;
using CarAPI.Payment;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using CarAPITests.Fake;
using Moq;

namespace CarAPITests
{
    [TestClass]
    public class OwnerServiceTests
    {
        private Mock<IOwnersRepository> _ownersRepositoryMock;
        private Mock<ICarsRepository> _carsRepositoryMock; 
        private Mock<IPaymentService> _paymentServiceMock;
        private OwnersService _ownersService;

        [TestInitialize]
        public void OwnerServiceTestsInit()
        {
            _carsRepositoryMock = new Mock<ICarsRepository>();
            _ownersRepositoryMock = new Mock<IOwnersRepository>();
            _paymentServiceMock = new Mock<IPaymentService>();
            _ownersService = new OwnersService(
                _ownersRepositoryMock.Object,
                _carsRepositoryMock.Object,
                _paymentServiceMock.Object
                );
        }


        #region Actual Dependencies

        [TestMethod]
        public void BuyCar_ExistingCarExistingOwner_Successful_RealDependencies()
        {
            // Arrange
            var ownerService = new OwnersService(
                new OwnersRepository(new InMemoryContext()),
                new CarsRepository(new InMemoryContext()),
                new CardService()
                );
            var input = new BuyCarInput()
            {
                CarId = 3,
                OwnerId = 1,
                Amount = 100,
            };

            // Act
            var result = ownerService.BuyCar(input);

            // Assert
            StringAssert.Contains(result, "Successfull");

        }

        #endregion

        #region Fake

        [TestMethod]
        public void BuyCar_ExistingCarExistingOwner_Successful_Fake()
        {
            // Arrange
            var ownerService = new OwnersService(
                new FakeOwnersRepository(),
                new FakeCarsRepository(),
                new FakePaymentService()
                );
            var input = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 100,
            };

            // Act
            var result = ownerService.BuyCar(input);

            // Assert
            StringAssert.Contains(result, "Successfull");
        }

        #endregion

        #region Mocking

        [TestMethod]
        public void BuyCar_ExistingCarExistingOwner_Successful_Mocking()
        {
            // Arrange
            var input = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 100,
            };
            _ownersRepositoryMock.Setup(m => m.GetOwnerById(input.OwnerId)).Returns(new Owner());
            _carsRepositoryMock.Setup(m => m.GetCarById(input.CarId)).Returns(new Car());
            _paymentServiceMock.Setup(m => m.Pay(input.Amount)).Returns("Paid");

            // Act
            var result = _ownersService.BuyCar(input);

            // Assert
            StringAssert.Contains(result, "Successfull");
        }

        [TestMethod]
        public void BuyCar_NonExistingCar_NotFound_Mocking()
        {
            // Arrange
            var input = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 100,
            };
            _carsRepositoryMock.Setup(m => m.GetCarById(input.CarId)).Returns((Car)null);

            // Act
            var result = _ownersService.BuyCar(input);

            // Assert
            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("Car is not found"));
        }
        #endregion
    }
}