using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Dal;
using Do.Db.Oracle;

namespace Do.Bll
{
    public class RoleMenuBll:BaseBll<SysRoleMenu>
    {
        readonly RoleMenuDal dal = new RoleMenuDal();
        public List<SysRoleMenu> GetMenuListByRoleId(string rid)
        {
            return dal.GetMenuListByRoleId(rid);
        }
    }
}
