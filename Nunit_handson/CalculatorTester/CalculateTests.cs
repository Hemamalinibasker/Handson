using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nunit_handson;

namespace CalculatorTester
{
   
        [TestFixture]
        public class CalculatorTests
        {
            private Calculator calculator;
            private int total;

            [SetUp]
            public void SetUp()
            {
                calculator = new Calculator();
                total = 0;
            }

            [Test]
            [TestCase(3, 5, 8)]
            //[TestCase(3,5,9)]
            public void addMethod(int a, int b, int total)
            {

                var result = calculator.Add(a, b);

                Assert.That(result, Is.EqualTo(total));
            }
            [TearDown]
            public void CleanUpMethod()
            {
                total = 0;
            }

        }
    }

