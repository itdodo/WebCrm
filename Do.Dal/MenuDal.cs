using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Entity;

namespace Do.Dal
{
    public class MenuDal
    {
        readonly TestDb db = new TestDb();
        public int AddMenu(Menu entity)
        {
            if (entity != null)
            {
                entity.CreateAt = DateTime.Now;
                entity.UserName = "Dong";
                db.Menus.Add(entity);
                return db.SaveChanges();
            }

            return 0;
        }


        public List<Menu> GetList()
        {
            return db.Menus.OrderByDescending(c=>c.MenuId).ToList();
        }
    }
}
