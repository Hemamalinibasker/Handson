using MyFoodSupply;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDetailtest
{
    //[TestFixture]
    public class Fooddetailtester
    {
        [Test]
        [TestCase("Dosai", 1, "2025/07/09", 200.98)]
        [TestCase("Parotta", 2, "2029/01/13", 90.00)]
        public void CreateFoodDetail_WhenCalled_ReturnFoodObject(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            FoodDetail result = p.CreateFoodDetail(name, dishType, expiryDate, price);
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.DishType, Is.EqualTo((FoodDetail.Category)dishType));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(result.Price, Is.EqualTo(price));

        }

        [Test]
       
         [TestCase("", 1, "2025/07/09", 200.98)]
       
        //[TestCase("burger", 1, "2029/01/13", 90.00)]
        public void CreateFoodDetail_FoodItemNull_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Pizza", 1, "2025/07/09", -7)]
        //[TestCase("Dosa", 1, "2029/01/13", 45)]
        public void CreateFoodDetail_PriceLessThanZero_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exception.Message);
        }

        [Test]
        //[TestCase("Pizza", 1, "2021/07/09", 70.00)]
        [TestCase("Dosa", 1, "2019/01/13", 50.00)]
        public void CreateFoodDetail_DateLessThanCurrentDate_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}
