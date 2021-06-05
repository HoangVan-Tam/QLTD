using DAL;
using Entities;
using System.Collections.Generic;
namespace BUL
{
    public class DiskBUL
    {
        private DiskDAL db;
        public DiskBUL()
        {
            db = new DiskDAL();
        }
        public List<Disk> GetDisks()
        {
            return db.GetAllDisk();
        }

        public List<Disk> GetDisks(int idTitle)
        {
            return db.GetAllDisk(idTitle);
        } 
        public Disk GetDisk(int idDisk)
        {
            return db.GetDisk(idDisk);
        }

        public List<Disk> GetDiskRamdon(int titleId)
        {
            return db.GetDiskRamdon(titleId);
        }

        public bool AddDisk(Disk disk)
        {
            disk.DiskRentalStatus = "OnShelf";
            disk.DiskStatus = "Good";
            return db.AddDisk(disk);
        }
        public bool UpdateDisk(Disk disk)
        {
            return db.UpdateDisk(disk);
        }
        public bool Delete(int idDisk)
        {
            return db.DeleteDisk(idDisk);
        }
    }
}
