using ACM01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM01Test
{
    [TestClass]
    public class CustomerReposotoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {   
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"

        };

            //--Act
            var actual = customerRepository.Retrieve(1);
            //--Assert
   
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);


        }
    }
}
