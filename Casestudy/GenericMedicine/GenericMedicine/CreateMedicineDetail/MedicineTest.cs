using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMedicineDetail
{
    
        [TestFixture]
        public class MedicineDetailTests
        {
            [Test]
            [TestCase("BCCX", "Dolo", "Composition1", "2022/6/12", 20.00)]
            [TestCase("IJKL", "Loparet", "Composition2", "2023/7/11", 30.50)]
            public void CreateMedicineDetail_WhenCalled_ReturnMedicineObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
            {
                Program P = new Program();
                var result = P.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

                Assert.That(result.Name, Is.EqualTo(name));
                Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
                Assert.That(result.Composition, Is.EqualTo(composition));
                Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
                Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));
            }
        
        [Test]
        [TestCase("BCCX", "", "Composition1", "2022/6/12", 20.00)]
        //[TestCase("IJKL", "Loparet", "Composition2", "2023/7/11", 30.50)]
        public void CreateMedicineDetail_EmptyGenericMedicineName_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exception.Message);
        }
        [Test]
        //[TestCase("BCCX", "Dolo", "Composition1", "2022/6/12", 20.00)]
        [TestCase("IJKL", "Loparet", "Composition2", "2023/7/11", -30.50)]
        public void CreateMedicineDetail_pricevaluelessthan0_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
        }
        [Test]
        //[TestCase("BCCX", "Dolo", "Composition1", "2022/6/12", 20.00)]
        [TestCase("IJKL", "Loparet", "Composition2", "2018/7/11", 30.50)]
        public void CreateMedicineDetail_DateLessThanCurrentDate_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}

