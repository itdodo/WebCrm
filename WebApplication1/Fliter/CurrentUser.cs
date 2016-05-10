using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Do.Bll;
using Do.Db.Oracle;

namespace Do.Web.Backend.Fliter
{
    public class CurrentUser
    {
        //static CurrentUser()
        //{
        //    var userName = HttpContext.Current.User.Identity.Name;
        //    var userInfo = new UserBll().GetFirstRecord(c => c.UserName == userName);
        //    UserId = userInfo.UserId;
        //    UserName = userInfo.UserName;
        //    RoleId = userInfo.RoleId;
        //}

        //static string userName = HttpContext.Current.User.Identity.Name;
        //SysUser userInfo = new UserBll().GetFirstRecord(c => c.UserName == userName);

        public static string UserId { get; set; }
        public static string UserName { get; set; }
        public static string RoleId { get; set; }
        
        //public static CurrentUser UserInfo { get; set; }
    }
}
