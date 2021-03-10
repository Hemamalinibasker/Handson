using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartonDetails
{
    [TestFixture]
    public class CartonDetailltest
    {
        public Medicine get(int n)
        {
            if (n == 1)
            {
                return new Medicine()
                {

                    Name = "BOOZ",
                    GenericMedicineName = "Dolo",
                    Composition = "composition1",
                    ExpiryDate = new DateTime(2027, 09, 08),
                    PricePerStrip = 90.00
                };
            }
            else
            {
                return null;
            }

        }
        [Test]
        [TestCase(1, "2021/08/07", "Sholingar nagar", 1)]
        [TestCase(5, "2021/08/07", "Vijaya nagar", 1)]
        public void CreateCartonDetail_WhenCalled_ReturnCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);
            CartonDetail res = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(res.MedicineStripCount, Is.EqualTo(medicineStripCount));
            Assert.That(res.LaunchDate, Is.EqualTo(launchDate));
            Assert.That(res.RetailerAddress, Is.EqualTo(retailerAddress));
        }
        [Test]
        [TestCase(1, "2021/08/07", "Sholingar nagar", 1)]
        [TestCase(-5, "2021/08/07", "Vijaya nagar", 1)]
        public void CreateCartonDetail_medicineStripCountLessThanZero_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect strip count. Please check", exception.Message);
        }
        [Test]
        [TestCase(1, "2020/08/07", "Sholingar nagar", 1)]
        //[TestCase(5, "2021/08/07", "Vijaya nagar", 1)]
        public void CreateCartonDetail_DateLessThanCurrentDate_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress,int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase(1, "2021/08/07", "Sholingar nagar",0)]
        //[TestCase(5, "2021/08/07", "Vijaya nagar",1)]
        public void CreateCartonDetail_MedicineObjectNull_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress,int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);
            CartonDetail res = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);

            Assert.That(res, Is.EqualTo(null));
        }
    }
}