using CarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAppTests
{
    [TestClass]
    public class CarStoreTests
    {
        [ClassInitialize]
        public static void CarStoreInit(TestContext context)
        {
            context.WriteLine("Car store init");
        }

        [ClassCleanup]
        public static void CarStoreCleanup()
        {

        }

        #region Collection Assert
        // For demo purpose
        [TestMethod]
        public void GetAllStoreCars_EqualCarsSameOrder_Equal()
        {
            // Arrange
            var car1 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            var car2 = new Car(CarType.Toyota, 20, DrivingMode.Reverse);
            var carStore1 = new CarStore(new List<Car> { car1, car2 });

            var car3 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            var car4 = new Car(CarType.Toyota, 20, DrivingMode.Reverse);
            var carStore2 = new CarStore(new List<Car> { car3, car4 });

            // Act
            var store1Cars = carStore1.GetAllStoreCars();
            var store2Cars = carStore2.GetAllStoreCars();

            // Assert
            CollectionAssert.AreEqual(store2Cars, store1Cars);
            CollectionAssert.AreNotEquivalent(store2Cars, store1Cars);

            //Assert.AreEqual(store2Cars, store1Cars); Fails as it compares instance of List class to another one not the collection objects
        }

        // For demo purpose
        [TestMethod]
        public void GetAllStoreCars_SameCarsDifferentOrder_Equivalent()
        {
            // Arrange
            var car1 = new Car(CarType.Audi, 10, DrivingMode.Forward);
            var car2 = new Car(CarType.Toyota, 20, DrivingMode.Reverse);
            var carStore1 = new CarStore(new List<Car> { car1, car2 });

            var carStore2 = new CarStore(new List<Car> { car2, car1 });

            // Act
            var store1Cars = carStore1.GetAllStoreCars();
            var store2Cars = carStore2.GetAllStoreCars();

            // Assert
            CollectionAssert.AreEquivalent(store2Cars, store1Cars);
            CollectionAssert.AreNotEqual(store2Cars, store1Cars);
        } 
        #endregion
    }
}
