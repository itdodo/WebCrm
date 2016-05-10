using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Db.Oracle;

namespace Do.Dal
{
    public class RoleMenuDal:BaseDal<SysRoleMenu>
    {
        readonly PlatFormDB db = new PlatFormDB();
        /// <summary>
        /// 根据角色ID获取下属所有菜单列表
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public List<SysRoleMenu> GetMenuListByRoleId(string rid)
        {
            return db.SysRoleMenus.Where(c => c.RoleId == rid).ToList();
        }


        //public void DeleteByRole
    }
}
