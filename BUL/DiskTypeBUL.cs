using DAL;
using Entities;
using System.Collections.Generic;

namespace BUL
{
    public class DiskTypeBUL
    {
        DiskTypeDAL db;
        public DiskTypeBUL()
        {
            db = new DiskTypeDAL();
        }
        public List<DiskType> GetDiskTypes()
        {
            return db.GetAllDiskType();
        }
        public bool AddDidkType(DiskType diskType)
        {
            return db.AddDiskType(diskType);
        }
        public bool UpdateDiskType(DiskType diskType)
        {
            return db.UpdateDiskType(diskType);
        }
        public bool DeleteDiskType(int idDiskType)
        {
            return db.DeleteDiskType(idDiskType);
        }
    }
}
