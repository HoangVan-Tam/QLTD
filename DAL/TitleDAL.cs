using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TitleDAL
    {
        QuanLyThueDiaDBContext context;
        public TitleDAL()
        {
            context = new QuanLyThueDiaDBContext();
        }
        public List<Title> GetAllTitle()
        {
            return context.Titles.ToList();
        }

        public Title GetTitlesByNameTitle(string nameTitle)
        {
            return context.Titles.Where(p=>p.NameTitle.Contains(nameTitle)).FirstOrDefault();
        }

        public List<Title> GetNewTitle()
        {
            return context.Titles.OrderByDescending(p=>p.IdTitle).Take(10).ToList();
        }

        
        public bool AddTitle(Title title)
        {
            try
            {
                context.Titles.Add(title);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateTitle(Title title)
        {
            try
            {
                Title titleUpdate = context.Titles.Find(title.IdTitle);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetLastTitle()
        {
            return context.Titles.ToList().Last().IdTitle;
        }

        public Title GetTitle(int idTitle)
        {
            return context.Titles.Where(p=>p.IdTitle==idTitle).FirstOrDefault();
        }

        public bool DeleteTitle(int idTitle)
        {
            try
            {
                Title titleDelete = context.Titles.Find(idTitle);
                context.Titles.Remove(titleDelete);
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
