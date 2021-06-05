using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DiskTypeDAL
    {
        private QuanLyThueDiaDBContext context;
        public DiskTypeDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<DiskType> GetAllDiskType()
        {
            return context.DiskTypes.ToList();
        }
        public bool AddDiskType(DiskType diskType)
        {
            try
            {
                context.DiskTypes.Add(diskType);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateDiskType(DiskType diskType)
        {
            try
            {
                DiskType diskTypeUpdate = context.DiskTypes.Find(diskType.IdDiskType);
                diskTypeUpdate.LateFee = diskType.LateFee;
                diskTypeUpdate.Price = diskType.Price;
                diskTypeUpdate.TimeRented = diskType.TimeRented;
                diskTypeUpdate.TypeName = diskType.TypeName;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteDiskType(int idDiskType)
        {
            try
            {

                DiskType diskTypeDelete = context.DiskTypes.Find(idDiskType);
                context.DiskTypes.Remove(diskTypeDelete);
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
