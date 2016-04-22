using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Do.Dal;
using Do.Entity;

namespace Do.Bll
{
    public class MenuBll
    {
        readonly MenuDal dal = new MenuDal();
        public int AddMenu(Menu entity)
        {
            return dal.AddMenu(entity);
        }

        public List<Menu> GetList()
        {
            return dal.GetList();
        }
    }
}
