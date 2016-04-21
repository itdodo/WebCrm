using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do.Dal
{
    public class UserInfoDal
    {
        public List<TUserInfo> GetUserList()
        {
            var db = new Fish();
            return db.TUserInfo.ToList();
        }
    }
}
