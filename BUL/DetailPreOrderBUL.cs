using DAL;
using Entities;
using System.Collections.Generic;

namespace BUL
{
    public class DetailPreOrderBUL
    {
        private DetailPreOrderDAL db;
        public DetailPreOrderBUL()
        {
            db = new DetailPreOrderDAL();
        }
        public List<DetailPreOrder> GetDetailPreOrders()
        {
            return db.GetAllDetailPreOrderDAL();
        }
        public bool AddDetailPreOrder(DetailPreOrder detailPreOrder)
        {
            return db.AddDetailPreOrderDAL(detailPreOrder);
        }
        public bool UpdateDetailPreOrder(DetailPreOrder detailPreOrder)
        {
            return db.UpdateDetailPreOrderDAL(detailPreOrder);
        }
        public bool DeleteDetailPreOrder(int idDetailPreOrder)
        {
            return db.DeleteDetailPreOrderDAL(idDetailPreOrder);
        }
        public DetailPreOrder GetDetailPreOrder(int idDetailPreOrder)
        {
            return db.GetDetailPreOrder(idDetailPreOrder);
        }
        public bool UpdateAccepted(int idDetailPreOrder)
        {
            var s = GetDetailPreOrder(idDetailPreOrder);
            s.Accepted = true;
            return UpdateDetailPreOrder(s);
        }
    }
}
