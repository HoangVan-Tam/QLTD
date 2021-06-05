using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ListRentedDAL
    {
        QuanLyThueDiaDBContext context;
        public ListRentedDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<ListRented> GetAllListRented()
        {
            return context.ListRenteds.ToList();
        }
        public bool AddListRented(ListRented listRented)
        {
            try
            {
                context.ListRenteds.Add(listRented);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public ListRented GetListRented(int idListRented)
        {
            return context.ListRenteds.Find(idListRented);
        }
        public List<ListRented> GetAllListRented(string phoneNumber)
        {
            var result = context.Customers.Where(p => p.PhoneNumber == phoneNumber).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            return context.ListRenteds.Where(p=>p.IdCustomer==result.IdCustomer).ToList();
        }
        public bool UpdateListRented(ListRented listRented)
        {
            try
            {
                ListRented listRentedUpdate = context.ListRenteds.Find(listRented.IdListRented);
                listRentedUpdate.IdDisk = listRented.IdDisk;
                listRentedUpdate.IdCustomer = listRented.IdCustomer;
                listRentedUpdate.LateFee = listRented.LateFee;
                listRentedUpdate.RentalDate = listRented.RentalDate;
                listRentedUpdate.ExpectedReturnDate = listRented.ExpectedReturnDate;
                listRentedUpdate.ActualReturnDate = listRented.ActualReturnDate;
                listRentedUpdate.StatusOnBill = listRented.StatusOnBill;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteListRented(int idListRented)
        {
            try
            {
                ListRented listRentedDelete = context.ListRenteds.Find(idListRented);
                context.ListRenteds.Remove(listRentedDelete);
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
