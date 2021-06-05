using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CustomerDAL
    {
        QuanLyThueDiaDBContext context;
        public CustomerDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<Customer> GetAllCustomer()
        {
            return context.Customers.ToList();
        }
        public Customer GetCustomer(int idCustomer)
        {
            return context.Customers.Find(idCustomer);
        }
        public Customer GetCustomer(string phoneNumer)
        {
            return context.Customers.Where(p=>p.PhoneNumber==phoneNumer).FirstOrDefault();
        }
        public bool AddCustomer(Customer customer)
        {
            try
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           

        }
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                Customer customerUpdate = context.Customers.Find(customer.IdCustomer);
                customerUpdate.Address = customer.Address;
                customerUpdate.CustomerName = customer.CustomerName;
                customerUpdate.PhoneNumber = customer.PhoneNumber;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCustomer(int idCustomer)
        {
            try
            {
                Customer customerDelete = context.Customers.Find(idCustomer);
                context.Customers.Remove(customerDelete);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
