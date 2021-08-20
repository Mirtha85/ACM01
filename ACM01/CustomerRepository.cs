using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM01
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId) {
            //Create the instance of the Customer class
            //Pass in the request id
            Customer customer = new Customer(customerId);
            //Code that  retrieves the defined customer
            //Temporary hard-code values to return
            // a populate customer
            if (customerId == 1)
            {
                customer.EmailAdress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
            
        }
        public bool Save(Customer customer) {
            // Code that saves the passed in customer
            return true;
        }
    }
}
