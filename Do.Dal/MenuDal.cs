using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Common;
using Do.Db.Oracle;

namespace Do.Dal
{
    public class MenuDal:BaseDal<SysMenu>
    {
        readonly PlatFormDB db = new PlatFormDB();
        public int AddMenu(SysMenu entity)
        {
            if (entity != null)
            {
                entity.MenuId = Guid.NewGuid().ToString();
                entity.CreateAt = DateTime.Now;
                entity.CreateBy = "Dong";
                //entity.ParentId = "0";
                db.SysMenus.Add(entity);
                return db.SaveChanges();
            }
            return 0;
        }


        public List<SysMenu> GetList()
        {
            return db.SysMenus.OrderByDescending(c=>c.MenuId).ToList();
        }

        public List<SysMenu> GetList(SearchModel model)
        {
            return db.SysMenus.OrderByDescending(c => c.MenuId).Take(model.PageSize*(model.PageIndex+1)).Skip(model.PageSize*model.PageIndex).ToList();
        }

        public int DeleteMenu(string id)
        {
            var entity = db.SysMenus.Find(id);
            db.SysMenus.Remove(entity);
            return db.SaveChanges();
        }

        /// <summary>
        /// 根据父级ID获取下面的子菜单
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<SysMenu> GetMenuByPid(string pid)
        {
            var entity = db.SysMenus.Where(c => c.ParentId == pid).OrderBy(c=>c.Sort).ThenBy(c=>c.CreateAt);
            return entity.ToList();
        }
    }
}
