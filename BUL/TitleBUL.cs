using DAL;
using Entities;
using Entities.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BUL
{
    public class TitleBUL
    {
        private TitleDAL db;
        public TitleBUL()
        {
            db = new TitleDAL();
        }
        public List<TitleDTO> GetTitles()
        {
            DiskBUL diskBUL = new DiskBUL();
            List<TitleDTO> lst = new List<TitleDTO>();
            var result = db.GetAllTitle();
            for(int i=0;i<result.Count();i++)
            {
                TitleDTO titleDTO = new TitleDTO()
                {
                    IdDiskType = result[i].IdDiskType,
                    totalDisks = result[i].TotalDiskOnShelf,
                    IdTitle = result[i].IdTitle,
                    NameTitle = result[i].NameTitle,
                    TotalDiskOnShelf = diskBUL.GetDisks(result[i].IdTitle).Where(p => p.DiskRentalStatus == "OnShelf").Count(),
                };
                lst.Add(titleDTO);
            }
            return lst;
        }


        public List<TitleDTO> GetNewTitle()
        {
            DiskBUL diskBUL = new DiskBUL();
            List<TitleDTO> lst = new List<TitleDTO>();
            var result = db.GetNewTitle();
            for (int i = 0; i < result.Count(); i++)
            {
                TitleDTO titleDTO = new TitleDTO()
                {
                    IdDiskType = result[i].IdDiskType,
                    totalDisks = result[i].TotalDiskOnShelf,
                    IdTitle = result[i].IdTitle,
                    NameTitle = result[i].NameTitle,
                    TotalDiskOnShelf = diskBUL.GetDisks(result[i].IdTitle).Where(p => p.DiskRentalStatus == "OnShelf").Count(),
                };
                lst.Add(titleDTO);
            }
            return lst;
        }

        public int CountNumberDiskOnShelf(int titleId, int totalDisk)
        {
            DiskBUL diskBUL = new DiskBUL();
            return totalDisk - diskBUL.GetDisks(titleId).Where(p => p.DiskRentalStatus == "Rented").Count();
        }
        public Title GetTitleByNameTitle (string titleName)
        {
            return db.GetTitlesByNameTitle(titleName);
        }


        public List<Title> GetListTitles()
        {
            return db.GetAllTitle();
        }
        public bool AddTitle(Title title)
        {
            return db.AddTitle(title);
        }
        public bool UpdateTitle(Title title)
        {
            return db.UpdateTitle(title);
        }
        public bool DeleteTitle(int idTitle)
        {
            return db.DeleteTitle(idTitle);
        }
        public int TotalDiskOfTitle(int idTitle)
        {
            DiskDAL dbDisk = new DiskDAL();
            return dbDisk.GetAllDisk().Where(x => x.IdTitle == idTitle).Count();
        }
        public Title GetTitle(int idTitle)
        {
            return db.GetTitle(idTitle);
        }

        public int GetLastTitle()
        {
            return db.GetLastTitle();
        }
    }
}
