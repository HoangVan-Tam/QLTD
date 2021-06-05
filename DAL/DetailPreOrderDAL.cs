using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DetailPreOrderDAL
    {
        private QuanLyThueDiaDBContext context;
        public DetailPreOrderDAL()
        {
            context= new QuanLyThueDiaDBContext();
        }
        public List<DetailPreOrder> GetAllDetailPreOrderDAL()
        {
            return context.DetailPreOrders.ToList();
        }
        public DetailPreOrder GetDetailPreOrder(int idDetailPreOrder)
        {
            return context.DetailPreOrders.Find(idDetailPreOrder);
        }
        public bool AddDetailPreOrderDAL(DetailPreOrder detailpreorder)
        {
            try
            {
                context.DetailPreOrders.Add(detailpreorder);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //trigger giam so luong list
            //trigger cap nhat lai trang thai cua dia
        }
        public bool UpdateDetailPreOrderDAL(DetailPreOrder detailPreOrder)
        {
            try
            {
                DetailPreOrder detailPreOrderUpdate = context.DetailPreOrders.Find(detailPreOrder.IdDetailPreOrder);
                detailPreOrderUpdate.IdDisk = detailPreOrder.IdDisk;
                detailPreOrderUpdate.IdListTitlePreOrder = detailPreOrder.IdListTitlePreOrder;
                detailPreOrderUpdate.IdCustomer = detailPreOrder.IdCustomer;
                context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool DeleteDetailPreOrderDAL(int idDetailPreOrder)
        {
            try
            {
                DetailPreOrder detailPreOrderDelete = context.DetailPreOrders.Find(idDetailPreOrder);
                context.DetailPreOrders.Remove(detailPreOrderDelete);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteDetailPreOrderOfCustomerDAL(int idCustomer)
        {
            try
            {
                IQueryable<DetailPreOrder> listDelete = context.DetailPreOrders.Where(x => x.IdCustomer == idCustomer);
                context.DetailPreOrders.RemoveRange(listDelete);
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
