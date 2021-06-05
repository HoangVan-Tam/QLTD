using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Entities.DTO;

namespace BUL
{
    public class ListRentedBUL
    {
        private const string UNPAID = "Unpaid";
        private const string PAID = "Unpaid";
        private ListRentedDAL db;
        public ListRentedBUL()
        {
            db = new ListRentedDAL();
        }
        public List<ListRented> GetListRenteds()
        {
            return db.GetAllListRented();
        }
        public ListRented GetListRented(int idListRented)
        {
            return db.GetListRented(idListRented);
        }
        public List<ListRented> GetAllListRented(string phoneNumber)
        {
            
            return db.GetAllListRented(phoneNumber).Where(p => p.ActualReturnDate == null).ToList();
        }
        public List<ListRented> ListLate(int idCustomer)
        {
            return db.GetAllListRented().Where(x => x.IdCustomer == idCustomer && x.StatusOnBill != null && x.StatusOnBill.Equals(UNPAID)).ToList();
        }
        
        public bool AddListRented(ListRented listRented)
        {
            return db.AddListRented(listRented);
        }
        public bool UpdateListRented(ListRented listRented)
        {
            return db.UpdateListRented(listRented);
        }
        public bool DeleteListRented(int idListRented)
        {
            return db.DeleteListRented(idListRented);
        }
        public bool ReturnDisk(int idListRented)
        {
            ListRented rented = GetListRented(idListRented);
            rented.ActualReturnDate = DateTime.Today;
            return UpdateListRented(rented);
            
        }
        public bool PayTheBill(int idListRented)
        {
            ListRented rented = GetListRented(idListRented);
            rented.StatusOnBill = PAID;
            return UpdateListRented(rented);

        }

    }
}
