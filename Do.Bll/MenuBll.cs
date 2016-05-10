using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Do.Common;
using Do.Dal;
using Do.Db.Oracle;
namespace Do.Bll
{
    public class MenuBll:BaseBll<SysMenu>
    {
        readonly MenuDal dal = new MenuDal();
        public int AddMenu(SysMenu entity)
        {
            return dal.AddMenu(entity);
        }

        public List<SysMenu> GetList()
        {
            return dal.GetList();
        }

        public List<SysMenu> GetList(SearchModel model)
        {
            return dal.GetList(model);
        }

        /// <summary>
        /// 根据父级ID获取下面的子菜单
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<SysMenu> GetMenuByPid(string pid)
        {
            return dal.GetMenuByPid(pid);
        }
    }
}
