using MyFoodSupply;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyDetailTest
{
    [TestFixture]
    public class SupplyDetailTester
    {
        public FoodDetail get(int n)
        {
            if (n == 1)
            {
                return new FoodDetail()
                {

                    Name = "Food",
                    DishType = FoodDetail.Category.MainDish,
                    ExpiryDate = new DateTime(2021, 09, 08),
                    Price = 90.00
                };
            }
            else
            {
                return null;
            }

        }
        [Test]
        [TestCase(1, "2021/08/07", "BOOZ", 50.00, 1)]
        [TestCase(1, "2021/09/12", "ABC", 40.00, 1)]
        public void CreateSupplyDetail_WhenCalled_ReturnObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);
            SupplyDetail res = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m);
            Assert.That(res.Count, Is.EqualTo(foodItemCount));
            Assert.That(res.RequestDate, Is.EqualTo(requestDate));
            Assert.That(res.SellerName, Is.EqualTo(sellerName));
            Assert.That(res.FoodItem, Is.EqualTo(m));
        }
        [Test]
        [TestCase(-1, "2021/08/07", "Raj", 20.00, 1)]
        //[TestCase(22, "2021/07/02", "Ram", 50.00, 1)]
        public void CreateSupllyDetail_FoodItemCountLessThanZero_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m));
            Assert.AreEqual("Incorrect food item count. Please check", exception.Message);
        }
        [Test]
        //[TestCase(1, "2022/08/07", "Raj", 20.00, 1)]
        [TestCase(1, "1998/08/07", "samu", 20.00, 1)]
        public void CreateSupplyDetail_DateLessThanCurrentDate_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase(1, "2021/08/07", "abh", 20.00, 0)]
        //[TestCase(1, "2021/08/07", "abh", 20.00, 1)]
        public void CreateSupplyDetail_FoodItemObjectNull_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);
            SupplyDetail res = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m);
            Assert.That(res, Is.EqualTo(null));
        }
    }
}
