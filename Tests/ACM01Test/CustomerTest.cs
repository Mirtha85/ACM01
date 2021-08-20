using ACM01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM01Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //--Act
            string actual = customer.FullName;
            //--Assert

            Assert.AreEqual(expected,actual);

        }
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            Customer customerOne = new Customer
            {
                
                LastName = "Baggins",
                EmailAdress = "fbaggins@hobbittom.me"
               
            };
            var expected = true;
            //--Act
            var actual = customerOne.Validate();
            //--Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "Alex";
            Customer.InstanceCount += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Fidel";
            Customer.InstanceCount += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Wilfredo";
            Customer.InstanceCount += 1;

            //--Act

            //--Assert
            Assert.AreEqual(3,Customer.InstanceCount);


        }
        [TestMethod]
        public void ConstructorTest()
        {
            //--Arrange
            Customer c1 = new Customer(2);
            c1.FirstName = "Alex";
           

            //--Act

            //--Assert
            Assert.AreEqual(2, c1.CustomerId);


        }
    }
}
