using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCom.Tests
{
    [TestFixture]
    public class CustomerTests
    {

        Mock<IMailSender> mock;
        CustomerComm obj;

        [Test]
        [TestCase("hemamalinibasker@gmail.com", "Hema", true)]
        //[TestCase("abc@gmail.com", "Message", false)]
        public void OneTimeSetUp(string toaddress, string name, bool expected)

        {
            mock = new Mock<IMailSender>();

            mock.Setup(p => p.SendMail(toaddress, name)).Returns(expected);
            obj = new CustomerComm(mock.Object);

            bool actual = obj.SendMailToCustomer(toaddress, name);
            Assert.AreEqual(expected, actual);
        }
    }

}

    
   