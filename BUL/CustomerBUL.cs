using DAL;
using Entities;
using System.Collections.Generic;

namespace BUL
{
    public class CustomerBUL
    {
        CustomerDAL db;
        public CustomerBUL()
        {
            db = new CustomerDAL();
        }
        public List<Customer> GetCustomers()
        {
            return db.GetAllCustomer();
        }
        public Customer GetCustomer(int idCustomer)
        {
            return db.GetCustomer(idCustomer);
        }
        public Customer GetCustomer(string phoneNumber)
        {
            return db.GetCustomer(phoneNumber);
        }
        public bool AddCustomer(Customer customer)
        {
            return db.AddCustomer(customer);
        }
        public bool UpdateCustomer(Customer customer)
        {
            return db.UpdateCustomer(customer);
        }
        public bool DeleteCustomer(int idCustomer)
        {
            return db.DeleteCustomer(idCustomer);
        }
    }
}
